namespace Func.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Threading.Tasks;

    using static Func.Result;

    [TestFixture]
    public partial class MapExtensionMethodsTests
    {
        [Test]
        public void ThenMap_Curries_With2Arguments()
        {
            static string TestMethod(int argument1, int argument2) =>
                $"{argument1}, {argument2}";

            var result = Succeed(2).ThenMap(TestMethod, 1);

            ((Success<string>)result).Value.Should().Be("1, 2");
        }

        [Test]
        public async Task ThenMap_CurriesFromTask_With2Arguments()
        {
            static string TestMethod(int argument1, int argument2) =>
                $"{argument1}, {argument2}";

            var result = await Succeed(2).ToTask().ThenMap(TestMethod, 1);

            ((Success<string>)result).Value.Should().Be("1, 2");
        }

        [Test]
        public async Task ThenMap_CurriesFromTaskWithTask_With2Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2) =>
                Task.FromResult($"{argument1}, {argument2}");

            var result = await Succeed(2).ToTask().ThenMap(TestMethod, 1);

            ((Success<string>)result).Value.Should().Be("1, 2");
        }

        [Test]
        public void ThenMap_Curries_With3Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3) =>
                $"{argument1}, {argument2}, {argument3}";

            var result = Succeed(3).ThenMap(TestMethod, 1, 2);

            ((Success<string>)result).Value.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task ThenMap_CurriesFromTask_With3Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3) =>
                $"{argument1}, {argument2}, {argument3}";

            var result = await Succeed(3).ToTask().ThenMap(TestMethod, 1, 2);

            ((Success<string>)result).Value.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task ThenMap_CurriesFromTaskWithTask_With3Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2, int argument3) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}");

            var result = await Succeed(3).ToTask().ThenMap(TestMethod, 1, 2);

            ((Success<string>)result).Value.Should().Be("1, 2, 3");
        }

        [Test]
        public void ThenMap_Curries_With4Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}";

            var result = Succeed(4).ThenMap(TestMethod, 1, 2, 3);

            ((Success<string>)result).Value.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task ThenMap_CurriesFromTask_With4Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}";

            var result = await Succeed(4).ToTask().ThenMap(TestMethod, 1, 2, 3);

            ((Success<string>)result).Value.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task ThenMap_CurriesFromTaskWithTask_With4Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}");

            var result = await Succeed(4).ToTask().ThenMap(TestMethod, 1, 2, 3);

            ((Success<string>)result).Value.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public void ThenMap_Curries_With5Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            var result = Succeed(5).ThenMap(TestMethod, 1, 2, 3, 4);

            ((Success<string>)result).Value.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task ThenMap_CurriesFromTask_With5Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            var result = await Succeed(5).ToTask().ThenMap(TestMethod, 1, 2, 3, 4);

            ((Success<string>)result).Value.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task ThenMap_CurriesFromTaskWithTask_With5Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}");

            var result = await Succeed(5).ToTask().ThenMap(TestMethod, 1, 2, 3, 4);

            ((Success<string>)result).Value.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public void ThenMap_Curries_With6Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            var result = Succeed(6).ThenMap(TestMethod, 1, 2, 3, 4, 5);

            ((Success<string>)result).Value.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task ThenMap_CurriesFromTask_With6Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            var result = await Succeed(6).ToTask().ThenMap(TestMethod, 1, 2, 3, 4, 5);

            ((Success<string>)result).Value.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task ThenMap_CurriesFromTaskWithTask_With6Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}");

            var result = await Succeed(6).ToTask().ThenMap(TestMethod, 1, 2, 3, 4, 5);

            ((Success<string>)result).Value.Should().Be("1, 2, 3, 4, 5, 6");
        }

    }
}
