namespace Func.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;
    using System.Threading.Tasks;
    using static Result;

    [TestFixture]
    public class ResultTests
    {
        [Test]
        public void Then_OnSuccess_ShouldExecute()
        {
            var called = false;
            Result Test()
            {
                called = true;
                return Succeed();
            }

            TestMethod(true)()
                .Then(Test);

            called.Should().BeTrue();
        }

        [Test]
        public void Then_OnFailure_ShouldNotExecute()
        {
            var called = false;
            Result Test()
            {
                called = true;
                return Succeed();
            }

            TestMethod(false)()
                .Then(Test);

            called.Should().BeFalse();
        }

        [Test]
        public void Failure_BlocksCallChain()
        {
            var callCount = 0;

            Func<Result> Test(bool shouldSucceed) => () =>
            {
                ++callCount;
                return shouldSucceed? Succeed() : Fail(new TestError());
            };
                

            var result = 
                Succeed()
                .Then(Test(true))
                .Then(Test(true))
                .Then(Test(false))
                .Then(Test(true));

            callCount.Should().Be(3);
        }

        [Test]
        public void Result_OnSucceed_IsSuccess()
        {
            var result = Succeed();

            result.Should().BeAssignableTo<Success>();
        }

        [Test]
        public void Result_OnSucceedWithValue_IsSuccess()
        {
            var result = Succeed(1234);

            result.Should().BeAssignableTo<Success>();
        }

        [Test]
        public void Result_OnSucceedWithValue_IsTypedSuccess()
        {
            var result = Succeed(1234);

            result.Should().BeAssignableTo<Success<int>>();
        }

        [Test]
        public void Result_OnSucceedWithValue_ContainsValue()
        {
            var result = Succeed(1234) as Success<int>;

            result.Value.Should().Be(1234);
        }

        [Test]
        public void Result_OnFail_IsFailure()
        {
            var result = Fail(new TestError());

            result.Should().BeAssignableTo<Failure>();
        }

        [Test]
        public void Result_OnFail_IsTypedFailure()
        {
            var result = Fail(new TestError());

            result.Should().BeAssignableTo<Failure<TestError>>();
        }

        [Test]
        public void Result_OnFail_PassesErrorDownChain()
        {
            var result =
                TestMethod(true)()
                .Then(TestMethod(true))
                .Then(TestMethod(false))
                .Then(TestMethod(true))
                .Then(TestMethod(true))
                as Failure<TestError>;

            result.Error.Data.Should().Be(4321);
        }

        [Test]
        public void Then_WithValue_PassesValue()
        {
            var result =
                Succeed(12)
                .Then(x => Succeed($"{x}.34"))
                .Then(x => Succeed(double.Parse(x)))
                as Success<double>;

            result.Value.Should().Be(12.34);
        }

        [Test]
        public async Task Then_WithTask_ChainsSuccesses()
        {
            var callCount = 0;

            Func<Result> Test(bool shouldSucceed) => () =>
            {
                ++callCount;
                return shouldSucceed ? Succeed() : Fail(new TestError());
            };

            Func<Task<Result>> AsyncTest(bool shouldSucceed) => () =>
                Test(shouldSucceed)().ToTask();

            await
                Succeed()
                    .Then(AsyncTest(true))
                    .Then(Test(true))
                    .Then(AsyncTest(true))
                    .Then(Test(true));

            callCount.Should().Be(4);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public async Task Then_WithTask_ReturnsExpectedResultType(bool shouldSucceed)
        {
            var result = await
                Succeed()
                    .Then(TestMethod(true))
                    .Then(AsyncTestMethod(true))
                    .Then(AsyncTestMethod(true))
                    .Then(TestMethod(true))
                    .Then(TestMethod(true))
                    .Then(AsyncTestMethod(shouldSucceed));

            (result is Success).Should().Be(shouldSucceed);
        }

        [Test]
        public async Task Then_WithTask_ShouldBreakOnFail()
        {
            var callCount = 0;

            Func<Result> Test(bool shouldSucceed) => () =>
            {
                ++callCount;
                return shouldSucceed ? Succeed() : Fail(new TestError());
            };

            Func<Task<Result>> AsyncTest(bool shouldSucceed) => () =>
                Test(shouldSucceed)().ToTask();

            await
                Succeed()
                    .Then(AsyncTest(true))
                    .Then(Test(true))
                    .Then(AsyncTest(false))
                    .Then(Test(true));

            callCount.Should().Be(3);
        }

        [Test]
        public void CaptureResult_WithActionWithoutException_ReturnsSuccess()
        {
            static void TestMethod() { }
            var result = CaptureResult(TestMethod, _ => new TestError());

            result.Should().BeAssignableTo<Success>();
        }

        [Test]
        public void CaptureResult_WithActionWithException_ReturnsFailure()
        {
            static void TestMethod() => throw new Exception();
            var result = CaptureResult(TestMethod, _ => new TestError());

            result.Should().BeAssignableTo<Failure<TestError>>();
        }

        [Test]
        public void CaptureResult_WithActionWithException_PassesExceptionToCatchMethod()
        {
            static void TestMethod() => throw new Exception("This is a test");
            var result = CaptureResult(TestMethod, ex => new TestError { Message = ex.Message });

            ((result as Failure<TestError>)?.Error.Message ?? "").Should().Be("This is a test");
        }

        [Test]
        public void CaptureResult_WithFuncWithoutException_ReturnsSuccess()
        {
            static int TestMethod() => 123;
            var result = CaptureResult(TestMethod, _ => new TestError());

            result.Should().BeAssignableTo<Success<int>>();
        }

        [Test]
        public void CaptureResult_WithFuncWithoutException_ReturnsValue()
        {
            static int TestMethod() => 123;
            var result = CaptureResult(TestMethod, _ => new TestError());

            ((result as Success<int>)?.Value ?? -1).Should().Be(123);
        }

        [Test]
        public void CaptureResult_WithFuncWithException_ReturnsFailure()
        {
            static int TestMethod() => throw new Exception();
            var result = CaptureResult(TestMethod, _ => new TestError());

            result.Should().BeAssignableTo<Failure<TestError>>();
        }

        [Test]
        public void CaptureResult_WithFuncWithException_PassesExceptionToCatchMethod()
        {
            static int TestMethod() => throw new Exception("This is a test");
            var result = CaptureResult(TestMethod, ex => new TestError { Message = ex.Message });

            ((result as Failure<TestError>)?.Error.Message ?? "").Should().Be("This is a test");
        }

        [Test]
        public async Task CaptureResult_WithAsyncActionWithoutException_ReturnsSuccess()
        {
            static Task TestMethod() => Task.CompletedTask;
            var result = await CaptureResult(TestMethod, _ => new TestError());

            result.Should().BeAssignableTo<Success>();
        }

        [Test]
        public async Task CaptureResult_WithAsyncActionWithException_ReturnsFailure()
        {
            static Task TestMethod() => throw new Exception();
            var result = await CaptureResult(TestMethod, _ => new TestError());

            result.Should().BeAssignableTo<Failure<TestError>>();
        }

        [Test]
        public async Task CaptureResult_WithAsyncActionWithException_PassesExceptionToCatchMethod()
        {
            static Task TestMethod() => throw new Exception("This is a test");
            var result = await CaptureResult(TestMethod, ex => new TestError { Message = ex.Message });

            ((result as Failure<TestError>)?.Error.Message ?? "").Should().Be("This is a test");
        }

        [Test]
        public async Task CaptureResult_WithAsyncFuncWithoutException_ReturnsSuccess()
        {
            static Task<int> TestMethod() => 123.ToTask();
            var result = await CaptureResult(TestMethod, _ => new TestError());

            result.Should().BeAssignableTo<Success<int>>();
        }

        [Test]
        public async Task CaptureResult_WithAsyncFuncWithoutException_ReturnsValue()
        {
            static Task<int> TestMethod() => 123.ToTask();
            var result = await CaptureResult(TestMethod, _ => new TestError());

            ((result as Success<int>)?.Value ?? -1).Should().Be(123);
        }

        [Test]
        public async Task CaptureResult_WithAsyncFuncWithException_ReturnsFailure()
        {
            static Task<int> TestMethod() => throw new Exception();
            var result = await CaptureResult(TestMethod, _ => new TestError());

            result.Should().BeAssignableTo<Failure<TestError>>();
        }

        [Test]
        public async Task CaptureResult_WithAsyncFuncWithException_PassesExceptionToCatchMethod()
        {
            static Task<int> TestMethod() => throw new Exception("This is a test");
            var result = await CaptureResult(TestMethod, ex => new TestError { Message = ex.Message });

            ((result as Failure<TestError>)?.Error.Message ?? "").Should().Be("This is a test");
        }

        private static Func<Result> TestMethod(bool shouldSucceed) => () =>
            shouldSucceed
            ? Succeed()
            : Fail(new TestError { Data = 4321 });

        private static Func<Task<Result>> AsyncTestMethod(bool shouldSucceed) => () =>
            TestMethod(shouldSucceed)().ToTask();

        private class TestError : ResultError
        {
            public int Data { get; set; }
            public string Message { get; set; }
        }
    }

}
