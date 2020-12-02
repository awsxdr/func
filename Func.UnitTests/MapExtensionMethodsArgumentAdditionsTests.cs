namespace Func.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Threading.Tasks;

    [TestFixture]
    public partial class MapExtensionMethodsTests
    {
        [Test]
        public void Map_Curries_With2Arguments()
        {
            static string TestMethod(int argument1, int argument2) =>
                $"{argument1}, {argument2}";

            var result = 2.Map(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Map_CurriesFromTask_With2Arguments()
        {
            static string TestMethod(int argument1, int argument2) =>
                $"{argument1}, {argument2}";

            var result = await Task.FromResult(2).Map(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With2Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2) =>
                Task.FromResult($"{argument1}, {argument2}");

            var result = await Task.FromResult(2).Map(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public void Map_Curries_With3Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3) =>
                $"{argument1}, {argument2}, {argument3}";

            var result = 3.Map(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Map_CurriesFromTask_With3Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3) =>
                $"{argument1}, {argument2}, {argument3}";

            var result = await Task.FromResult(3).Map(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With3Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2, int argument3) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}");

            var result = await Task.FromResult(3).Map(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public void Map_Curries_With4Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}";

            var result = 4.Map(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Map_CurriesFromTask_With4Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}";

            var result = await Task.FromResult(4).Map(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With4Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}");

            var result = await Task.FromResult(4).Map(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public void Map_Curries_With5Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            var result = 5.Map(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Map_CurriesFromTask_With5Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            var result = await Task.FromResult(5).Map(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With5Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}");

            var result = await Task.FromResult(5).Map(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public void Map_Curries_With6Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            var result = 6.Map(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Map_CurriesFromTask_With6Arguments()
        {
            static string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            var result = await Task.FromResult(6).Map(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With6Arguments()
        {
            static Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}");

            var result = await Task.FromResult(6).Map(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

    }
}
