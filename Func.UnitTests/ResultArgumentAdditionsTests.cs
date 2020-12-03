namespace Func.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Threading.Tasks;
    using static Result;

    [TestFixture]
    public class ResultArgumentAdditionsTests
    {
        [Test]
        public void Then_With1Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed().Then((int arg1) => Succeed(arg1 + 2), 1);
            ((Success<int>)result).Value.Should().Be(3);
        }

        [Test]
        public void Then_With1Arguments_ShouldReturnSuccess()
        {
            var result = Succeed().Then((int arg1) => Succeed(), 1);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task Then_With1Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().Then((int arg1) => Succeed(arg1 + 2).ToTask(), 1);
            ((Success<int>)result).Value.Should().Be(3);
        }

        [Test]
        public async Task Then_With1Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().Then((int arg1) => Succeed().ToTask(), 1);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void ValueThen_With1Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed(2).Then((int arg1, int arg2) => Succeed(arg1 + arg2), 1);
            ((Success<int>)result).Value.Should().Be(3);
        }

        [Test]
        public void ValueThen_With1Arguments_ShouldReturnSuccess()
        {
            var result = Succeed(2).Then((int arg1) => Succeed(), 1);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task ValueThen_With1Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(2).Then((int arg1, int arg2) => Succeed(arg1 + arg2).ToTask(), 1);
            ((Success<int>)result).Value.Should().Be(3);
        }

        [Test]
        public async Task ValueThen_With1Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(2).Then((int arg1) => Succeed().ToTask(), 1);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With1Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1) => Succeed(arg1 + 2), 1);
            ((Success<int>)result).Value.Should().Be(3);
        }

        [Test]
        public async Task AsyncThen_With1Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1) => Succeed(), 1);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With1Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1) => Succeed(arg1 + 2).ToTask(), 1);
            ((Success<int>)result).Value.Should().Be(3);
        }

        [Test]
        public async Task AsyncThen_With1Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1) => Succeed().ToTask(), 1);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With1Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed(2).ToTask().Then((int arg1, int arg2) => Succeed(arg1 + arg2), 1);
            ((Success<int>)result).Value.Should().Be(3);
        }

        [Test]
        public async Task AsyncValueThen_With1Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed(2).ToTask().Then((int arg1, int arg2) => Succeed(), 1);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With1Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(2).ToTask().Then((int arg1, int arg2) => Succeed(arg1 + arg2).ToTask(), 1);
            ((Success<int>)result).Value.Should().Be(3);
        }

        [Test]
        public async Task AsyncValueThen_With1Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(2).ToTask().Then((int arg1, int arg2) => Succeed().ToTask(), 1);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void Then_With2Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed().Then((int arg1, int arg2) => Succeed(arg1 + arg2 + 3), 1, 2);
            ((Success<int>)result).Value.Should().Be(6);
        }

        [Test]
        public void Then_With2Arguments_ShouldReturnSuccess()
        {
            var result = Succeed().Then((int arg1, int arg2) => Succeed(), 1, 2);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task Then_With2Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().Then((int arg1, int arg2) => Succeed(arg1 + arg2 + 3).ToTask(), 1, 2);
            ((Success<int>)result).Value.Should().Be(6);
        }

        [Test]
        public async Task Then_With2Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().Then((int arg1, int arg2) => Succeed().ToTask(), 1, 2);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void ValueThen_With2Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed(3).Then((int arg1, int arg2, int arg3) => Succeed(arg1 + arg2 + arg3), 1, 2);
            ((Success<int>)result).Value.Should().Be(6);
        }

        [Test]
        public void ValueThen_With2Arguments_ShouldReturnSuccess()
        {
            var result = Succeed(3).Then((int arg1, int arg2) => Succeed(), 1, 2);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task ValueThen_With2Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(3).Then((int arg1, int arg2, int arg3) => Succeed(arg1 + arg2 + arg3).ToTask(), 1, 2);
            ((Success<int>)result).Value.Should().Be(6);
        }

        [Test]
        public async Task ValueThen_With2Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(3).Then((int arg1, int arg2) => Succeed().ToTask(), 1, 2);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With2Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2) => Succeed(arg1 + arg2 + 3), 1, 2);
            ((Success<int>)result).Value.Should().Be(6);
        }

        [Test]
        public async Task AsyncThen_With2Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2) => Succeed(), 1, 2);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With2Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2) => Succeed(arg1 + arg2 + 3).ToTask(), 1, 2);
            ((Success<int>)result).Value.Should().Be(6);
        }

        [Test]
        public async Task AsyncThen_With2Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2) => Succeed().ToTask(), 1, 2);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With2Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed(3).ToTask().Then((int arg1, int arg2, int arg3) => Succeed(arg1 + arg2 + arg3), 1, 2);
            ((Success<int>)result).Value.Should().Be(6);
        }

        [Test]
        public async Task AsyncValueThen_With2Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed(3).ToTask().Then((int arg1, int arg2, int arg3) => Succeed(), 1, 2);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With2Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(3).ToTask().Then((int arg1, int arg2, int arg3) => Succeed(arg1 + arg2 + arg3).ToTask(), 1, 2);
            ((Success<int>)result).Value.Should().Be(6);
        }

        [Test]
        public async Task AsyncValueThen_With2Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(3).ToTask().Then((int arg1, int arg2, int arg3) => Succeed().ToTask(), 1, 2);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void Then_With3Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed().Then((int arg1, int arg2, int arg3) => Succeed(arg1 + arg2 + arg3 + 4), 1, 2, 3);
            ((Success<int>)result).Value.Should().Be(10);
        }

        [Test]
        public void Then_With3Arguments_ShouldReturnSuccess()
        {
            var result = Succeed().Then((int arg1, int arg2, int arg3) => Succeed(), 1, 2, 3);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task Then_With3Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().Then((int arg1, int arg2, int arg3) => Succeed(arg1 + arg2 + arg3 + 4).ToTask(), 1, 2, 3);
            ((Success<int>)result).Value.Should().Be(10);
        }

        [Test]
        public async Task Then_With3Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().Then((int arg1, int arg2, int arg3) => Succeed().ToTask(), 1, 2, 3);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void ValueThen_With3Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed(4).Then((int arg1, int arg2, int arg3, int arg4) => Succeed(arg1 + arg2 + arg3 + arg4), 1, 2, 3);
            ((Success<int>)result).Value.Should().Be(10);
        }

        [Test]
        public void ValueThen_With3Arguments_ShouldReturnSuccess()
        {
            var result = Succeed(4).Then((int arg1, int arg2, int arg3) => Succeed(), 1, 2, 3);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task ValueThen_With3Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(4).Then((int arg1, int arg2, int arg3, int arg4) => Succeed(arg1 + arg2 + arg3 + arg4).ToTask(), 1, 2, 3);
            ((Success<int>)result).Value.Should().Be(10);
        }

        [Test]
        public async Task ValueThen_With3Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(4).Then((int arg1, int arg2, int arg3) => Succeed().ToTask(), 1, 2, 3);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With3Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3) => Succeed(arg1 + arg2 + arg3 + 4), 1, 2, 3);
            ((Success<int>)result).Value.Should().Be(10);
        }

        [Test]
        public async Task AsyncThen_With3Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3) => Succeed(), 1, 2, 3);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With3Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3) => Succeed(arg1 + arg2 + arg3 + 4).ToTask(), 1, 2, 3);
            ((Success<int>)result).Value.Should().Be(10);
        }

        [Test]
        public async Task AsyncThen_With3Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3) => Succeed().ToTask(), 1, 2, 3);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With3Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed(4).ToTask().Then((int arg1, int arg2, int arg3, int arg4) => Succeed(arg1 + arg2 + arg3 + arg4), 1, 2, 3);
            ((Success<int>)result).Value.Should().Be(10);
        }

        [Test]
        public async Task AsyncValueThen_With3Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed(4).ToTask().Then((int arg1, int arg2, int arg3, int arg4) => Succeed(), 1, 2, 3);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With3Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(4).ToTask().Then((int arg1, int arg2, int arg3, int arg4) => Succeed(arg1 + arg2 + arg3 + arg4).ToTask(), 1, 2, 3);
            ((Success<int>)result).Value.Should().Be(10);
        }

        [Test]
        public async Task AsyncValueThen_With3Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(4).ToTask().Then((int arg1, int arg2, int arg3, int arg4) => Succeed().ToTask(), 1, 2, 3);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void Then_With4Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed().Then((int arg1, int arg2, int arg3, int arg4) => Succeed(arg1 + arg2 + arg3 + arg4 + 5), 1, 2, 3, 4);
            ((Success<int>)result).Value.Should().Be(15);
        }

        [Test]
        public void Then_With4Arguments_ShouldReturnSuccess()
        {
            var result = Succeed().Then((int arg1, int arg2, int arg3, int arg4) => Succeed(), 1, 2, 3, 4);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task Then_With4Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().Then((int arg1, int arg2, int arg3, int arg4) => Succeed(arg1 + arg2 + arg3 + arg4 + 5).ToTask(), 1, 2, 3, 4);
            ((Success<int>)result).Value.Should().Be(15);
        }

        [Test]
        public async Task Then_With4Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().Then((int arg1, int arg2, int arg3, int arg4) => Succeed().ToTask(), 1, 2, 3, 4);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void ValueThen_With4Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed(5).Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5), 1, 2, 3, 4);
            ((Success<int>)result).Value.Should().Be(15);
        }

        [Test]
        public void ValueThen_With4Arguments_ShouldReturnSuccess()
        {
            var result = Succeed(5).Then((int arg1, int arg2, int arg3, int arg4) => Succeed(), 1, 2, 3, 4);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task ValueThen_With4Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(5).Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5).ToTask(), 1, 2, 3, 4);
            ((Success<int>)result).Value.Should().Be(15);
        }

        [Test]
        public async Task ValueThen_With4Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(5).Then((int arg1, int arg2, int arg3, int arg4) => Succeed().ToTask(), 1, 2, 3, 4);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With4Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4) => Succeed(arg1 + arg2 + arg3 + arg4 + 5), 1, 2, 3, 4);
            ((Success<int>)result).Value.Should().Be(15);
        }

        [Test]
        public async Task AsyncThen_With4Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4) => Succeed(), 1, 2, 3, 4);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With4Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4) => Succeed(arg1 + arg2 + arg3 + arg4 + 5).ToTask(), 1, 2, 3, 4);
            ((Success<int>)result).Value.Should().Be(15);
        }

        [Test]
        public async Task AsyncThen_With4Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4) => Succeed().ToTask(), 1, 2, 3, 4);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With4Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed(5).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5), 1, 2, 3, 4);
            ((Success<int>)result).Value.Should().Be(15);
        }

        [Test]
        public async Task AsyncValueThen_With4Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed(5).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(), 1, 2, 3, 4);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With4Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(5).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5).ToTask(), 1, 2, 3, 4);
            ((Success<int>)result).Value.Should().Be(15);
        }

        [Test]
        public async Task AsyncValueThen_With4Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(5).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed().ToTask(), 1, 2, 3, 4);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void Then_With5Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + 6), 1, 2, 3, 4, 5);
            ((Success<int>)result).Value.Should().Be(21);
        }

        [Test]
        public void Then_With5Arguments_ShouldReturnSuccess()
        {
            var result = Succeed().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(), 1, 2, 3, 4, 5);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task Then_With5Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + 6).ToTask(), 1, 2, 3, 4, 5);
            ((Success<int>)result).Value.Should().Be(21);
        }

        [Test]
        public async Task Then_With5Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed().ToTask(), 1, 2, 3, 4, 5);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void ValueThen_With5Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed(6).Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6), 1, 2, 3, 4, 5);
            ((Success<int>)result).Value.Should().Be(21);
        }

        [Test]
        public void ValueThen_With5Arguments_ShouldReturnSuccess()
        {
            var result = Succeed(6).Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(), 1, 2, 3, 4, 5);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task ValueThen_With5Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(6).Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6).ToTask(), 1, 2, 3, 4, 5);
            ((Success<int>)result).Value.Should().Be(21);
        }

        [Test]
        public async Task ValueThen_With5Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(6).Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed().ToTask(), 1, 2, 3, 4, 5);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With5Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + 6), 1, 2, 3, 4, 5);
            ((Success<int>)result).Value.Should().Be(21);
        }

        [Test]
        public async Task AsyncThen_With5Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(), 1, 2, 3, 4, 5);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With5Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + 6).ToTask(), 1, 2, 3, 4, 5);
            ((Success<int>)result).Value.Should().Be(21);
        }

        [Test]
        public async Task AsyncThen_With5Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5) => Succeed().ToTask(), 1, 2, 3, 4, 5);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With5Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed(6).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6), 1, 2, 3, 4, 5);
            ((Success<int>)result).Value.Should().Be(21);
        }

        [Test]
        public async Task AsyncValueThen_With5Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed(6).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(), 1, 2, 3, 4, 5);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With5Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(6).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6).ToTask(), 1, 2, 3, 4, 5);
            ((Success<int>)result).Value.Should().Be(21);
        }

        [Test]
        public async Task AsyncValueThen_With5Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(6).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed().ToTask(), 1, 2, 3, 4, 5);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void Then_With6Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + 7), 1, 2, 3, 4, 5, 6);
            ((Success<int>)result).Value.Should().Be(28);
        }

        [Test]
        public void Then_With6Arguments_ShouldReturnSuccess()
        {
            var result = Succeed().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(), 1, 2, 3, 4, 5, 6);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task Then_With6Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + 7).ToTask(), 1, 2, 3, 4, 5, 6);
            ((Success<int>)result).Value.Should().Be(28);
        }

        [Test]
        public async Task Then_With6Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed().ToTask(), 1, 2, 3, 4, 5, 6);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public void ValueThen_With6Arguments_ShouldReturnExpectedResult()
        {
            var result = Succeed(7).Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7), 1, 2, 3, 4, 5, 6);
            ((Success<int>)result).Value.Should().Be(28);
        }

        [Test]
        public void ValueThen_With6Arguments_ShouldReturnSuccess()
        {
            var result = Succeed(7).Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(), 1, 2, 3, 4, 5, 6);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task ValueThen_With6Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(7).Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7).ToTask(), 1, 2, 3, 4, 5, 6);
            ((Success<int>)result).Value.Should().Be(28);
        }

        [Test]
        public async Task ValueThen_With6Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(7).Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed().ToTask(), 1, 2, 3, 4, 5, 6);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With6Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + 7), 1, 2, 3, 4, 5, 6);
            ((Success<int>)result).Value.Should().Be(28);
        }

        [Test]
        public async Task AsyncThen_With6Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(), 1, 2, 3, 4, 5, 6);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncThen_With6Arguments_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + 7).ToTask(), 1, 2, 3, 4, 5, 6);
            ((Success<int>)result).Value.Should().Be(28);
        }

        [Test]
        public async Task AsyncThen_With6Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed().ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => Succeed().ToTask(), 1, 2, 3, 4, 5, 6);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With6Arguments_ShouldReturnExpectedResult()
        {
            var result = await Succeed(7).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7), 1, 2, 3, 4, 5, 6);
            ((Success<int>)result).Value.Should().Be(28);
        }

        [Test]
        public async Task AsyncValueThen_With6Arguments_ShouldReturnSuccess()
        {
            var result = await Succeed(7).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) => Succeed(), 1, 2, 3, 4, 5, 6);
            (result is Success).Should().BeTrue();
        }

        [Test]
        public async Task AsyncValueThen_With6Argument_AndAsyncFunc_ShouldReturnExpectedResult()
        {
            var result = await Succeed(7).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) => Succeed(arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7).ToTask(), 1, 2, 3, 4, 5, 6);
            ((Success<int>)result).Value.Should().Be(28);
        }

        [Test]
        public async Task AsyncValueThen_With6Arguments_AndAsyncFunc_ShouldReturnSuccess()
        {
            var result = await Succeed(7).ToTask().Then((int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) => Succeed().ToTask(), 1, 2, 3, 4, 5, 6);
            (result is Success).Should().BeTrue();
        }

    }
}
