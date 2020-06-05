namespace Func.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Threading.Tasks;

    [TestFixture]
    public partial class MapExtensionMethodsTests
    {
        [Test]
        public void Map_WithBasicInputAndOutput_TransformsValue()
        {
            123.Map(x => 444 - x).Should().Be(321);
        }

        [Test]
        public async Task Map_WithTask_ReturnsTask()
        {
            var result = await Task.FromResult(123).Map(x => Task.FromResult(444 - x));

            result.Should().Be(321);
        }

        [Test]
        public async Task Map_WithTaskInput_ReturnsTask()
        {
            var result = await Task.FromResult(123).Map(x => 444 - x);

            result.Should().Be(321);
        }

        [Test]
        public async Task Map_ChainsTasks()
        {
            static string IntToString(int value) => value.ToString();

            var result = await
                123
                .Map(x => Task.FromResult(444 - x))
                .Map(x => x * 2)
                .Map(IntToString)
                .Map(x => Task.FromResult(x + x))
                .Map(int.Parse);

            result.Should().Be(642642);
        }
    }
}
