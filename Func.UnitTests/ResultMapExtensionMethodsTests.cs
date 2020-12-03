namespace Func.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Threading.Tasks;

    using static Func.Result;

    [TestFixture]
    public partial class ResultMapExtensionMethodsTests
    {
        [Test]
        public void ThenMap_WithBasicInputAndOutput_TransformsValue()
        {
            var result = Succeed(123).ThenMap(x => 444 - x);
            
            ((Success<int>)result).Value.Should().Be(321);
        }

        [Test]
        public async Task ThenMap_WithTask_ReturnsTask()
        {
            var result = await Succeed(123).ThenMap(x => (444 - x).ToTask());

            ((Success<int>)result).Value.Should().Be(321);
        }

        [Test]
        public async Task ThenMap_WithTaskInput_ReturnsTask()
        {
            var result = await Succeed(123).ToTask().ThenMap(x => 444 - x);

            ((Success<int>)result).Value.Should().Be(321);
        }

        [Test]
        public async Task ThenMap_ChainsTasks()
        {
            static string IntToString(int value) => value.ToString();

            var result = await
                Succeed(123)
                .ThenMap(x => (444 - x).ToTask())
                .ThenMap(x => x * 2)
                .ThenMap(IntToString)
                .ThenMap(x => (x + x).ToTask())
                .ThenMap(int.Parse);

            ((Success<int>)result).Value.Should().Be(642642);
        }
    }
}
