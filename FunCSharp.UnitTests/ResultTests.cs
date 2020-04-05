namespace FunCSharp.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;
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

            (result is Success).Should().BeTrue();
        }

        [Test]
        public void Result_OnSucceedWithValue_IsSuccess()
        {
            var result = Succeed(1234);

            (result is Success).Should().BeTrue();
        }

        [Test]
        public void Result_OnSucceedWithValue_IsTypedSuccess()
        {
            var result = Succeed(1234);

            (result is Success<int>).Should().BeTrue();
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

            (result is Failure).Should().BeTrue();
        }

        [Test]
        public void Result_OnFail_IsTypedFailure()
        {
            var result = Fail(new TestError());

            (result is Failure<TestError>).Should().BeTrue();
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

        private Func<Result> TestMethod(bool shouldSucceed) => () =>
            shouldSucceed
            ? Succeed()
            : Fail(new TestError { Data = 4321 });

        private class TestError : ResultError
        {
            public int Data { get; set; }
        }
    }

}
