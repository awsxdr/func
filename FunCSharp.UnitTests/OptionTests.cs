namespace FunCSharp.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;

    using static Option;

    [TestFixture]
    public class OptionTests
    {
        [Test]
        public void Option_WithValue_IsSome()
        {
            var option = Some(1234);

            (option is Some).Should().BeTrue();
        }

        [Test]
        public void Option_WithValue_IsTypedSome()
        {
            var option = Some(1234);

            (option is Some<int>).Should().BeTrue();
        }

        [Test]
        public void Option_WithValue_WorksWithSwitchStatement()
        {
            var option = Some(1234);

            var result = option switch
            {
                Some<string> _ => false,
                Some<int> _ => true,
                Some _ => false,
                None _ => false,
                _ => false
            };

            result.Should().BeTrue();
        }

        [Test]
        public void Option_WithoutValue_IsNone()
        {
            var option = None();

            (option is None).Should().BeTrue();
        }

        [Test]
        public void Option_WithoutValue_WorksWithSwitchStatement()
        {
            var option = None();

            var result = option switch
            {
                Some<string> _ => false,
                Some<int> _ => false,
                Some _ => false,
                None _ => true,
                _ => false
            };

            result.Should().BeTrue();
        }

        [Test]
        public void Option_WithValue_CanRetrieveValue()
        {
            var option = Some(1234);

            (option as Some<int>).Value.Should().Be(1234);
        }
    }
}
