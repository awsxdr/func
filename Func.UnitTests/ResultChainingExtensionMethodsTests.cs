using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;

namespace Func.UnitTests
{
    using NUnit.Framework;

    using static Func.Result;

    [TestFixture]
    public class ResultChainingExtensionMethodsTests
    {
        private static Random _random = new Random();

        [TestCaseSource(nameof(ValuelessTestCases))]
        public void ValuelessResults_ShouldCorrectlyTransferResult(Result first, Result second, Type expectedResultType)
        {
            var result = first.And(second);

            result.Should().BeAssignableTo(expectedResultType);
        }

        [Test]
        public void FirstItemWithValue_WithSecondItemWithoutValue_ShouldReturnExpectedValueOnSuccess()
        {
            var value = _random.Next();

            var result = Succeed(value).And(Succeed());

            result.Should().BeAssignableTo<Success<int>>()
                .Which.Value.Should().Be(value);
        }

        [Test]
        public void FirstItemWithoutValue_WithSecondItemWithValue_ShouldReturnExpectedValueOnSuccess()
        {
            var value = _random.Next();

            var result = Succeed().And(Succeed(value));

            result.Should().BeAssignableTo<Success<int>>()
                .Which.Value.Should().Be(value);
        }

        [Test]
        public void BothItemsWithValue_ShouldReturnsTupleOfValues()
        {
            var values = new[] {_random.Next(), _random.Next()};

            var result = Succeed(values[0]).And(Succeed(values[1]));

            result.Should().BeAssignableTo<Success<(int, int)>>()
                .Which.Value.Should().Be((values[0], values[1]));
        }

        [Test]
        public void FirstItemWithTupleValue_WithSecondItemWithSingleValue_ShouldReturnCombinedTuple()
        {
            var values = Enumerable.Range(0, 3).Select(_ => _random.Next()).ToArray();

            var result = Succeed((values[0], values[1])).And(Succeed(values[2]));
            
            result.Should().BeAssignableTo<Success<(int, int, int)>>()
                .Which.Value.Should().Be((values[0], values[1], values[2]));
        }

        [Test]
        public void FirstItemWithSingleValue_WithSecondItemWithTupleValue_ShouldReturnCombinedTuple()
        {
            var values = Enumerable.Range(0, 3).Select(_ => _random.Next()).ToArray();

            var result = Succeed(values[0]).And(Succeed((values[1], values[2])));

            result.Should().BeAssignableTo<Success<(int, int, int)>>()
                .Which.Value.Should().Be((values[0], values[1], values[2]));
        }

        [Test]
        public void BothWithTupleValues_ShouldReturnCombinedTuple()
        {
            var values = Enumerable.Range(0, 4).Select(_ => _random.Next()).ToArray();

            var result = Succeed((values[0], values[1])).And(Succeed((values[2], values[3])));

            result.Should().BeAssignableTo<Success<(int, int, int, int)>>()
                .Which.Value.Should().Be((values[0], values[1], values[2], values[3]));
        }

        private static IEnumerable<TestCaseData> ValuelessTestCases =>
            new[]
            {
                new TestCaseData(Succeed(), Succeed(), typeof(Success)),
                new TestCaseData(Fail<TestError1>(), Succeed(), typeof(Failure<TestError1>)),
                new TestCaseData(Succeed(), Fail<TestError1>(), typeof(Failure<TestError1>)),
                new TestCaseData(Fail<TestError1>(), Fail<TestError2>(), typeof(Failure<TestError1>)),
            };

        private class TestError1 : ResultError {}
        private class TestError2 : ResultError { }
    }
}