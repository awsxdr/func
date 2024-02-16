namespace Func.UnitTests
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

        [Test]
        public void Option_WithValue_ShouldEqualOptionWithSameValue()
        {
            var option1 = Some(1234);
            var option2 = Some(1234);

            option1.Equals(option2).Should().BeTrue();
        }

        [Test]
        public void Option_WithValue_ShouldNotEqualOptionWithDifferentValue()
        {
            var option1 = Some(1234);
            var option2 = Some(4321);

            option1.Equals(option2).Should().BeFalse();
        }

        [Test]
        public void Option_WithValue_ShouldNotEqualOptionWithoutValue()
        {
            var option1 = Some(1234);
            var option2 = None<int>();

            option1.Equals(option2).Should().BeFalse();
        }

        [Test]
        public void Option_WithoutValue_ShouldEqualOptionWithoutValueOfSameType()
        {
            var option1 = None<int>();
            var option2 = None<int>();

            option1.Equals(option2).Should().BeTrue();
        }

        [Test]
        public void Option_WithoutValue_ShouldNotEqualOptionWithoutValueOfDifferentType()
        {
            var option1 = None<int>();
            var option2 = None<string>();

            option1.Equals(option2).Should().BeFalse();
        }

        [Test]
        public void Option_WithoutValue_ShouldNotEqualOptionWithValue()
        {
            var option1 = None<int>();
            var option2 = Some(1234);

            option1.Equals(option2).Should().BeFalse();
        }
    }
}
