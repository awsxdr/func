namespace Func.UnitTests
{
	using System;
	using NUnit.Framework;
	using FluentAssertions;

	[TestFixture]
	public class UnionTests
	{
		[Test]
		public void UnionWith2Types_ConvertsFromType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2> union = value;
			switch(union.Value)
			{
				case Some<TestType1> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType1> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith2Types_ReturnsExpectedValue_WithType1()
		{
			Union<TestType1, TestType2> union = new TestType1();
			union.Is<TestType1>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith2Types_OutputsValue_WithType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2> union = value;
			union.Is<TestType1>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith2Types_ConvertsFromType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2> union = value;
			switch(union.Value)
			{
				case Some<TestType2> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType2> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith2Types_ReturnsExpectedValue_WithType2()
		{
			Union<TestType1, TestType2> union = new TestType2();
			union.Is<TestType2>().Should().BeTrue();
			union.Is<TestType1>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith2Types_OutputsValue_WithType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2> union = value;
			union.Is<TestType2>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith3Types_ConvertsFromType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3> union = value;
			switch(union.Value)
			{
				case Some<TestType1> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType1> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith3Types_ReturnsExpectedValue_WithType1()
		{
			Union<TestType1, TestType2, TestType3> union = new TestType1();
			union.Is<TestType1>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith3Types_OutputsValue_WithType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3> union = value;
			union.Is<TestType1>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith3Types_ConvertsFromType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3> union = value;
			switch(union.Value)
			{
				case Some<TestType2> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType2> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith3Types_ReturnsExpectedValue_WithType2()
		{
			Union<TestType1, TestType2, TestType3> union = new TestType2();
			union.Is<TestType2>().Should().BeTrue();
			union.Is<TestType1>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith3Types_OutputsValue_WithType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3> union = value;
			union.Is<TestType2>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith3Types_ConvertsFromType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3> union = value;
			switch(union.Value)
			{
				case Some<TestType3> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType3> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith3Types_ReturnsExpectedValue_WithType3()
		{
			Union<TestType1, TestType2, TestType3> union = new TestType3();
			union.Is<TestType3>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith3Types_OutputsValue_WithType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3> union = value;
			union.Is<TestType3>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith4Types_ConvertsFromType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4> union = value;
			switch(union.Value)
			{
				case Some<TestType1> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType1> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith4Types_ReturnsExpectedValue_WithType1()
		{
			Union<TestType1, TestType2, TestType3, TestType4> union = new TestType1();
			union.Is<TestType1>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith4Types_OutputsValue_WithType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4> union = value;
			union.Is<TestType1>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith4Types_ConvertsFromType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4> union = value;
			switch(union.Value)
			{
				case Some<TestType2> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType2> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith4Types_ReturnsExpectedValue_WithType2()
		{
			Union<TestType1, TestType2, TestType3, TestType4> union = new TestType2();
			union.Is<TestType2>().Should().BeTrue();
			union.Is<TestType1>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith4Types_OutputsValue_WithType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4> union = value;
			union.Is<TestType2>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith4Types_ConvertsFromType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4> union = value;
			switch(union.Value)
			{
				case Some<TestType3> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType3> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith4Types_ReturnsExpectedValue_WithType3()
		{
			Union<TestType1, TestType2, TestType3, TestType4> union = new TestType3();
			union.Is<TestType3>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith4Types_OutputsValue_WithType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4> union = value;
			union.Is<TestType3>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith4Types_ConvertsFromType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4> union = value;
			switch(union.Value)
			{
				case Some<TestType4> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType4> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith4Types_ReturnsExpectedValue_WithType4()
		{
			Union<TestType1, TestType2, TestType3, TestType4> union = new TestType4();
			union.Is<TestType4>().Should().BeTrue();
			union.Is<TestType3>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith4Types_OutputsValue_WithType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4> union = value;
			union.Is<TestType4>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith5Types_ConvertsFromType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			switch(union.Value)
			{
				case Some<TestType1> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType1> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith5Types_ReturnsExpectedValue_WithType1()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = new TestType1();
			union.Is<TestType1>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith5Types_OutputsValue_WithType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			union.Is<TestType1>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith5Types_ConvertsFromType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			switch(union.Value)
			{
				case Some<TestType2> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType2> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith5Types_ReturnsExpectedValue_WithType2()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = new TestType2();
			union.Is<TestType2>().Should().BeTrue();
			union.Is<TestType1>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith5Types_OutputsValue_WithType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			union.Is<TestType2>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith5Types_ConvertsFromType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			switch(union.Value)
			{
				case Some<TestType3> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType3> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith5Types_ReturnsExpectedValue_WithType3()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = new TestType3();
			union.Is<TestType3>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith5Types_OutputsValue_WithType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			union.Is<TestType3>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith5Types_ConvertsFromType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			switch(union.Value)
			{
				case Some<TestType4> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType4> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith5Types_ReturnsExpectedValue_WithType4()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = new TestType4();
			union.Is<TestType4>().Should().BeTrue();
			union.Is<TestType3>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith5Types_OutputsValue_WithType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			union.Is<TestType4>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith5Types_ConvertsFromType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			switch(union.Value)
			{
				case Some<TestType5> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType5> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith5Types_ReturnsExpectedValue_WithType5()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = new TestType5();
			union.Is<TestType5>().Should().BeTrue();
			union.Is<TestType4>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith5Types_OutputsValue_WithType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5> union = value;
			union.Is<TestType5>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith6Types_ConvertsFromType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			switch(union.Value)
			{
				case Some<TestType1> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType1> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith6Types_ReturnsExpectedValue_WithType1()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = new TestType1();
			union.Is<TestType1>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith6Types_OutputsValue_WithType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			union.Is<TestType1>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith6Types_ConvertsFromType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			switch(union.Value)
			{
				case Some<TestType2> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType2> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith6Types_ReturnsExpectedValue_WithType2()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = new TestType2();
			union.Is<TestType2>().Should().BeTrue();
			union.Is<TestType1>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith6Types_OutputsValue_WithType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			union.Is<TestType2>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith6Types_ConvertsFromType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			switch(union.Value)
			{
				case Some<TestType3> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType3> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith6Types_ReturnsExpectedValue_WithType3()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = new TestType3();
			union.Is<TestType3>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith6Types_OutputsValue_WithType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			union.Is<TestType3>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith6Types_ConvertsFromType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			switch(union.Value)
			{
				case Some<TestType4> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType4> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith6Types_ReturnsExpectedValue_WithType4()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = new TestType4();
			union.Is<TestType4>().Should().BeTrue();
			union.Is<TestType3>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith6Types_OutputsValue_WithType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			union.Is<TestType4>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith6Types_ConvertsFromType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			switch(union.Value)
			{
				case Some<TestType5> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType5> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith6Types_ReturnsExpectedValue_WithType5()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = new TestType5();
			union.Is<TestType5>().Should().BeTrue();
			union.Is<TestType4>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith6Types_OutputsValue_WithType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			union.Is<TestType5>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith6Types_ConvertsFromType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			switch(union.Value)
			{
				case Some<TestType6> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType6> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith6Types_ReturnsExpectedValue_WithType6()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = new TestType6();
			union.Is<TestType6>().Should().BeTrue();
			union.Is<TestType5>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith6Types_OutputsValue_WithType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6> union = value;
			union.Is<TestType6>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith7Types_ConvertsFromType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			switch(union.Value)
			{
				case Some<TestType1> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType1> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith7Types_ReturnsExpectedValue_WithType1()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = new TestType1();
			union.Is<TestType1>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith7Types_OutputsValue_WithType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			union.Is<TestType1>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith7Types_ConvertsFromType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			switch(union.Value)
			{
				case Some<TestType2> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType2> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith7Types_ReturnsExpectedValue_WithType2()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = new TestType2();
			union.Is<TestType2>().Should().BeTrue();
			union.Is<TestType1>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith7Types_OutputsValue_WithType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			union.Is<TestType2>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith7Types_ConvertsFromType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			switch(union.Value)
			{
				case Some<TestType3> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType3> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith7Types_ReturnsExpectedValue_WithType3()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = new TestType3();
			union.Is<TestType3>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith7Types_OutputsValue_WithType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			union.Is<TestType3>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith7Types_ConvertsFromType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			switch(union.Value)
			{
				case Some<TestType4> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType4> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith7Types_ReturnsExpectedValue_WithType4()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = new TestType4();
			union.Is<TestType4>().Should().BeTrue();
			union.Is<TestType3>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith7Types_OutputsValue_WithType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			union.Is<TestType4>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith7Types_ConvertsFromType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			switch(union.Value)
			{
				case Some<TestType5> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType5> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith7Types_ReturnsExpectedValue_WithType5()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = new TestType5();
			union.Is<TestType5>().Should().BeTrue();
			union.Is<TestType4>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith7Types_OutputsValue_WithType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			union.Is<TestType5>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith7Types_ConvertsFromType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			switch(union.Value)
			{
				case Some<TestType6> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType6> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith7Types_ReturnsExpectedValue_WithType6()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = new TestType6();
			union.Is<TestType6>().Should().BeTrue();
			union.Is<TestType5>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith7Types_OutputsValue_WithType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			union.Is<TestType6>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith7Types_ConvertsFromType7()
		{
			var value = new TestType7();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			switch(union.Value)
			{
				case Some<TestType7> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType7> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith7Types_ReturnsExpectedValue_WithType7()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = new TestType7();
			union.Is<TestType7>().Should().BeTrue();
			union.Is<TestType6>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith7Types_OutputsValue_WithType7()
		{
			var value = new TestType7();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7> union = value;
			union.Is<TestType7>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith8Types_ConvertsFromType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			switch(union.Value)
			{
				case Some<TestType1> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType1> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith8Types_ReturnsExpectedValue_WithType1()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = new TestType1();
			union.Is<TestType1>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith8Types_OutputsValue_WithType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			union.Is<TestType1>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith8Types_ConvertsFromType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			switch(union.Value)
			{
				case Some<TestType2> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType2> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith8Types_ReturnsExpectedValue_WithType2()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = new TestType2();
			union.Is<TestType2>().Should().BeTrue();
			union.Is<TestType1>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith8Types_OutputsValue_WithType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			union.Is<TestType2>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith8Types_ConvertsFromType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			switch(union.Value)
			{
				case Some<TestType3> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType3> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith8Types_ReturnsExpectedValue_WithType3()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = new TestType3();
			union.Is<TestType3>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith8Types_OutputsValue_WithType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			union.Is<TestType3>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith8Types_ConvertsFromType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			switch(union.Value)
			{
				case Some<TestType4> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType4> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith8Types_ReturnsExpectedValue_WithType4()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = new TestType4();
			union.Is<TestType4>().Should().BeTrue();
			union.Is<TestType3>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith8Types_OutputsValue_WithType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			union.Is<TestType4>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith8Types_ConvertsFromType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			switch(union.Value)
			{
				case Some<TestType5> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType5> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith8Types_ReturnsExpectedValue_WithType5()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = new TestType5();
			union.Is<TestType5>().Should().BeTrue();
			union.Is<TestType4>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith8Types_OutputsValue_WithType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			union.Is<TestType5>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith8Types_ConvertsFromType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			switch(union.Value)
			{
				case Some<TestType6> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType6> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith8Types_ReturnsExpectedValue_WithType6()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = new TestType6();
			union.Is<TestType6>().Should().BeTrue();
			union.Is<TestType5>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith8Types_OutputsValue_WithType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			union.Is<TestType6>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith8Types_ConvertsFromType7()
		{
			var value = new TestType7();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			switch(union.Value)
			{
				case Some<TestType7> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType7> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith8Types_ReturnsExpectedValue_WithType7()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = new TestType7();
			union.Is<TestType7>().Should().BeTrue();
			union.Is<TestType6>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith8Types_OutputsValue_WithType7()
		{
			var value = new TestType7();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			union.Is<TestType7>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith8Types_ConvertsFromType8()
		{
			var value = new TestType8();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			switch(union.Value)
			{
				case Some<TestType8> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType8> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith8Types_ReturnsExpectedValue_WithType8()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = new TestType8();
			union.Is<TestType8>().Should().BeTrue();
			union.Is<TestType7>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith8Types_OutputsValue_WithType8()
		{
			var value = new TestType8();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8> union = value;
			union.Is<TestType8>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith9Types_ConvertsFromType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			switch(union.Value)
			{
				case Some<TestType1> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType1> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith9Types_ReturnsExpectedValue_WithType1()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = new TestType1();
			union.Is<TestType1>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith9Types_OutputsValue_WithType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			union.Is<TestType1>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith9Types_ConvertsFromType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			switch(union.Value)
			{
				case Some<TestType2> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType2> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith9Types_ReturnsExpectedValue_WithType2()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = new TestType2();
			union.Is<TestType2>().Should().BeTrue();
			union.Is<TestType1>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith9Types_OutputsValue_WithType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			union.Is<TestType2>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith9Types_ConvertsFromType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			switch(union.Value)
			{
				case Some<TestType3> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType3> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith9Types_ReturnsExpectedValue_WithType3()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = new TestType3();
			union.Is<TestType3>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith9Types_OutputsValue_WithType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			union.Is<TestType3>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith9Types_ConvertsFromType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			switch(union.Value)
			{
				case Some<TestType4> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType4> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith9Types_ReturnsExpectedValue_WithType4()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = new TestType4();
			union.Is<TestType4>().Should().BeTrue();
			union.Is<TestType3>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith9Types_OutputsValue_WithType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			union.Is<TestType4>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith9Types_ConvertsFromType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			switch(union.Value)
			{
				case Some<TestType5> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType5> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith9Types_ReturnsExpectedValue_WithType5()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = new TestType5();
			union.Is<TestType5>().Should().BeTrue();
			union.Is<TestType4>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith9Types_OutputsValue_WithType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			union.Is<TestType5>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith9Types_ConvertsFromType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			switch(union.Value)
			{
				case Some<TestType6> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType6> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith9Types_ReturnsExpectedValue_WithType6()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = new TestType6();
			union.Is<TestType6>().Should().BeTrue();
			union.Is<TestType5>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith9Types_OutputsValue_WithType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			union.Is<TestType6>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith9Types_ConvertsFromType7()
		{
			var value = new TestType7();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			switch(union.Value)
			{
				case Some<TestType7> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType7> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith9Types_ReturnsExpectedValue_WithType7()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = new TestType7();
			union.Is<TestType7>().Should().BeTrue();
			union.Is<TestType6>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith9Types_OutputsValue_WithType7()
		{
			var value = new TestType7();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			union.Is<TestType7>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith9Types_ConvertsFromType8()
		{
			var value = new TestType8();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			switch(union.Value)
			{
				case Some<TestType8> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType8> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith9Types_ReturnsExpectedValue_WithType8()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = new TestType8();
			union.Is<TestType8>().Should().BeTrue();
			union.Is<TestType7>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith9Types_OutputsValue_WithType8()
		{
			var value = new TestType8();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			union.Is<TestType8>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith9Types_ConvertsFromType9()
		{
			var value = new TestType9();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			switch(union.Value)
			{
				case Some<TestType9> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType9> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith9Types_ReturnsExpectedValue_WithType9()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = new TestType9();
			union.Is<TestType9>().Should().BeTrue();
			union.Is<TestType8>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith9Types_OutputsValue_WithType9()
		{
			var value = new TestType9();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9> union = value;
			union.Is<TestType9>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType1> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType1> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType1()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType1();
			union.Is<TestType1>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType1()
		{
			var value = new TestType1();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType1>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType2> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType2> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType2()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType2();
			union.Is<TestType2>().Should().BeTrue();
			union.Is<TestType1>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType2()
		{
			var value = new TestType2();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType2>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType3> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType3> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType3()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType3();
			union.Is<TestType3>().Should().BeTrue();
			union.Is<TestType2>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType3()
		{
			var value = new TestType3();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType3>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType4> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType4> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType4()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType4();
			union.Is<TestType4>().Should().BeTrue();
			union.Is<TestType3>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType4()
		{
			var value = new TestType4();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType4>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType5> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType5> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType5()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType5();
			union.Is<TestType5>().Should().BeTrue();
			union.Is<TestType4>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType5()
		{
			var value = new TestType5();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType5>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType6> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType6> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType6()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType6();
			union.Is<TestType6>().Should().BeTrue();
			union.Is<TestType5>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType6()
		{
			var value = new TestType6();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType6>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType7()
		{
			var value = new TestType7();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType7> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType7> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType7()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType7();
			union.Is<TestType7>().Should().BeTrue();
			union.Is<TestType6>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType7()
		{
			var value = new TestType7();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType7>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType8()
		{
			var value = new TestType8();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType8> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType8> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType8()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType8();
			union.Is<TestType8>().Should().BeTrue();
			union.Is<TestType7>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType8()
		{
			var value = new TestType8();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType8>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType9()
		{
			var value = new TestType9();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType9> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType9> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType9()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType9();
			union.Is<TestType9>().Should().BeTrue();
			union.Is<TestType8>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType9()
		{
			var value = new TestType9();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType9>(out var v);
			v.Id.Should().Be(value.Id);
		}

		[Test]
		public void UnionWith10Types_ConvertsFromType10()
		{
			var value = new TestType10();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			switch(union.Value)
			{
				case Some<TestType10> v: 
					v.Value.Id.Should().Be(value.Id);
					break;
				default: 
					throw new AssertionException($"Union value was expected to be of type Some<TestType10> but found {union.Value.GetType().Name}");
			}
		}

		[Test]
		public void Is_OnUnionWith10Types_ReturnsExpectedValue_WithType10()
		{
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = new TestType10();
			union.Is<TestType10>().Should().BeTrue();
			union.Is<TestType9>().Should().BeFalse();
		}

		[Test]
		public void Is_OnUnionWith10Types_OutputsValue_WithType10()
		{
			var value = new TestType10();
			Union<TestType1, TestType2, TestType3, TestType4, TestType5, TestType6, TestType7, TestType8, TestType9, TestType10> union = value;
			union.Is<TestType10>(out var v);
			v.Id.Should().Be(value.Id);
		}


		private abstract class TestType
		{
			public Guid Id { get; } = Guid.NewGuid();
		}

		private class TestType1 : TestType
		{
		}
		private class TestType2 : TestType
		{
		}
		private class TestType3 : TestType
		{
		}
		private class TestType4 : TestType
		{
		}
		private class TestType5 : TestType
		{
		}
		private class TestType6 : TestType
		{
		}
		private class TestType7 : TestType
		{
		}
		private class TestType8 : TestType
		{
		}
		private class TestType9 : TestType
		{
		}
		private class TestType10 : TestType
		{
		}
	}
}


