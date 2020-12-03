namespace Func.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Threading.Tasks;

    [TestFixture]
    public partial class TeeExtensionMethodsTests
    {
        [Test]
        public void Tee_Curries_With2ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2) =>
                result = $"{argument1}, {argument2}";

            2.Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With2ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2) =>
                result = $"{argument1}, {argument2}";

            await Task.FromResult(2).Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With2ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2)
            {
                result = $"{argument1}, {argument2}";
                return Task.CompletedTask;
            }

            await Task.FromResult(2).Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With2ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2)
            {
                result = $"{argument1}, {argument2}";
                return Task.CompletedTask;
            }

            await 2.Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public void Tee_Curries_With2ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2) =>
                result = $"{argument1}, {argument2}";

            2.Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With2ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2) =>
                result = $"{argument1}, {argument2}";

            await Task.FromResult(2).Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With2ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2)
            {
                result = $"{argument1}, {argument2}";
                return result.ToTask();
            }

            await Task.FromResult(2).Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With2ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2)
            {
                result = $"{argument1}, {argument2}";
                return result.ToTask();
            }

            await 2.Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public void Tee_Curries_With3ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3) =>
                result = $"{argument1}, {argument2}, {argument3}";

            3.Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With3ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3) =>
                result = $"{argument1}, {argument2}, {argument3}";

            await Task.FromResult(3).Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With3ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3)
            {
                result = $"{argument1}, {argument2}, {argument3}";
                return Task.CompletedTask;
            }

            await Task.FromResult(3).Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With3ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3)
            {
                result = $"{argument1}, {argument2}, {argument3}";
                return Task.CompletedTask;
            }

            await 3.Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public void Tee_Curries_With3ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3) =>
                result = $"{argument1}, {argument2}, {argument3}";

            3.Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With3ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3) =>
                result = $"{argument1}, {argument2}, {argument3}";

            await Task.FromResult(3).Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With3ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3)
            {
                result = $"{argument1}, {argument2}, {argument3}";
                return result.ToTask();
            }

            await Task.FromResult(3).Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With3ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3)
            {
                result = $"{argument1}, {argument2}, {argument3}";
                return result.ToTask();
            }

            await 3.Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public void Tee_Curries_With4ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";

            4.Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With4ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";

            await Task.FromResult(4).Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With4ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";
                return Task.CompletedTask;
            }

            await Task.FromResult(4).Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With4ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";
                return Task.CompletedTask;
            }

            await 4.Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public void Tee_Curries_With4ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";

            4.Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With4ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";

            await Task.FromResult(4).Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With4ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";
                return result.ToTask();
            }

            await Task.FromResult(4).Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With4ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";
                return result.ToTask();
            }

            await 4.Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public void Tee_Curries_With5ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            5.Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With5ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            await Task.FromResult(5).Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With5ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";
                return Task.CompletedTask;
            }

            await Task.FromResult(5).Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With5ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";
                return Task.CompletedTask;
            }

            await 5.Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public void Tee_Curries_With5ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            5.Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With5ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            await Task.FromResult(5).Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With5ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";
                return result.ToTask();
            }

            await Task.FromResult(5).Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With5ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";
                return result.ToTask();
            }

            await 5.Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public void Tee_Curries_With6ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            6.Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With6ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            await Task.FromResult(6).Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With6ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";
                return Task.CompletedTask;
            }

            await Task.FromResult(6).Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With6ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";
                return Task.CompletedTask;
            }

            await 6.Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public void Tee_Curries_With6ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            6.Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With6ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            await Task.FromResult(6).Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With6ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";
                return result.ToTask();
            }

            await Task.FromResult(6).Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With6ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";
                return result.ToTask();
            }

            await 6.Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

    }
}
