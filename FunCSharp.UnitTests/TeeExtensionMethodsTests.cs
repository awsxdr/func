namespace FunCSharp.UnitTests
{
    using System.Threading.Tasks;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public partial class TeeExtensionMethodsTests
    {
        [Test]
        public void Tee_WithAction_InvokesMethod()
        {
            var called = false;
            void TestMethod(int value) => called = true;

            123.Tee(TestMethod);

            called.Should().BeTrue();
        }

        [Test]
        public void Tee_WithFunc_InvokesMethod()
        {
            var called = false;
            int TestMethod(int value)
            {
                called = true;
                return 321;
            }

            123.Tee(TestMethod);

            called.Should().BeTrue();
        }

        [Test]
        public void Tee_WithBasicInputAndOutput_DoesNotTransformValue()
        {
            123.Tee(x => 444 - x).Should().Be(123);
        }

        [Test]
        public async Task Tee_WithTask_ReturnsTask()
        {
            var result = await Task.FromResult(123).Tee(x => Task.FromResult(444 - x));

            result.Should().Be(123);
        }

        [Test]
        public async Task Tee_WithTaskInput_ReturnsTask()
        {
            var result = await Task.FromResult(123).Tee(x => 444 - x);

            result.Should().Be(123);
        }

        [Test]
        public async Task Tee_ChainsTasks()
        {
            static string IntToString(int value) => value.ToString();

            var result = await
                123
                .Tee(x => Task.FromResult(444 - x))
                .Tee(x => x * 2)
                .Tee(IntToString)
                .Tee(x => Task.FromResult(x + x))
                .Tee(x => x - 2);

            result.Should().Be(123);
        }
    }
}
