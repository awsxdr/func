namespace FunCSharp.UnitTests
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
            string TestMethod(int argument1, int argument2) =>
                $"{argument1}, {argument2}";

            var result = 2.Map(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Map_CurriesFromTask_With2Arguments()
        {
            string TestMethod(int argument1, int argument2) =>
                $"{argument1}, {argument2}";

            var result = await Task.FromResult(2).Map(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With2Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2) =>
                Task.FromResult($"{argument1}, {argument2}");

            var result = await Task.FromResult(2).Map(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public void Map_Curries_With3Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3) =>
                $"{argument1}, {argument2}, {argument3}";

            var result = 3.Map(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Map_CurriesFromTask_With3Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3) =>
                $"{argument1}, {argument2}, {argument3}";

            var result = await Task.FromResult(3).Map(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With3Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}");

            var result = await Task.FromResult(3).Map(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public void Map_Curries_With4Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}";

            var result = 4.Map(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Map_CurriesFromTask_With4Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}";

            var result = await Task.FromResult(4).Map(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With4Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}");

            var result = await Task.FromResult(4).Map(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public void Map_Curries_With5Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            var result = 5.Map(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Map_CurriesFromTask_With5Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            var result = await Task.FromResult(5).Map(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With5Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}");

            var result = await Task.FromResult(5).Map(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public void Map_Curries_With6Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            var result = 6.Map(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Map_CurriesFromTask_With6Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            var result = await Task.FromResult(6).Map(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With6Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}");

            var result = await Task.FromResult(6).Map(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public void Map_Curries_With7Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";

            var result = 7.Map(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public async Task Map_CurriesFromTask_With7Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";

            var result = await Task.FromResult(7).Map(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With7Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}");

            var result = await Task.FromResult(7).Map(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public void Map_Curries_With8Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";

            var result = 8.Map(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public async Task Map_CurriesFromTask_With8Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";

            var result = await Task.FromResult(8).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With8Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}");

            var result = await Task.FromResult(8).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public void Map_Curries_With9Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";

            var result = 9.Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public async Task Map_CurriesFromTask_With9Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";

            var result = await Task.FromResult(9).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With9Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}");

            var result = await Task.FromResult(9).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public void Map_Curries_With10Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";

            var result = 10.Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public async Task Map_CurriesFromTask_With10Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";

            var result = await Task.FromResult(10).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With10Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}");

            var result = await Task.FromResult(10).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public void Map_Curries_With11Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";

            var result = 11.Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public async Task Map_CurriesFromTask_With11Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";

            var result = await Task.FromResult(11).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With11Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}");

            var result = await Task.FromResult(11).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public void Map_Curries_With12Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";

            var result = 12.Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public async Task Map_CurriesFromTask_With12Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";

            var result = await Task.FromResult(12).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With12Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}");

            var result = await Task.FromResult(12).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public void Map_Curries_With13Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";

            var result = 13.Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public async Task Map_CurriesFromTask_With13Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";

            var result = await Task.FromResult(13).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With13Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}");

            var result = await Task.FromResult(13).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public void Map_Curries_With14Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";

            var result = 14.Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public async Task Map_CurriesFromTask_With14Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";

            var result = await Task.FromResult(14).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With14Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}");

            var result = await Task.FromResult(14).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public void Map_Curries_With15Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";

            var result = 15.Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

        [Test]
        public async Task Map_CurriesFromTask_With15Arguments()
        {
            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15) =>
                $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";

            var result = await Task.FromResult(15).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

        [Test]
        public async Task Map_CurriesFromTaskWithTask_With15Arguments()
        {
            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15) =>
                Task.FromResult($"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}");

            var result = await Task.FromResult(15).Map(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

    }
}
