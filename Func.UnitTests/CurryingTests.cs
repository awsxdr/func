namespace Func.UnitTests
{
    using System;

    using FluentAssertions;
    using NUnit.Framework;

    using static Currying;

    [TestFixture]
    public class CurryingTests
    {
        [Test]
        public void Curry_With2Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, string> TestMethod = (x1, x2) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With2Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, string> TestMethod = (x1, x2) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With2Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int> TestMethod = (x1, x2) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With3Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, string> TestMethod = (x1, x2, x3) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With3Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, string> TestMethod = (x1, x2, x3) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With3Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int> TestMethod = (x1, x2, x3) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With4Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, string> TestMethod = (x1, x2, x3, x4) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With4Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, string> TestMethod = (x1, x2, x3, x4) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With4Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int> TestMethod = (x1, x2, x3, x4) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With5Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With5Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With5Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With6Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With6Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With6Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With7Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With7Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6)(7);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With7Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6, x7) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With8Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With8Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6)(7)(8);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With8Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With9Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With9Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With9Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With10Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With10Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With10Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With11Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With11Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With11Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With12Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With12Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With12Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int, int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With13Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With13Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With13Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With14Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With14Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With14Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With15Arguments_CallsCurriedFunc()
        {
            var hasBeenCalled = false;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) =>
            {
                hasBeenCalled = true;
                return "Test";
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15);

            hasBeenCalled.Should().BeTrue();
        }

        [Test]
        public void Curry_With15Arguments_ReturnsCurriedFuncValue()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, string> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) => "Test";

            var curriedMethod = Curry(TestMethod);

            var result = curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15);

            result.Should().Be("Test");
        }

        [Test]
        public void Curry_With15Arguments_CallsCurriedAction()
        {
            var hasBeenCalled = false;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> TestMethod = (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) =>
            {
                hasBeenCalled = true;
            };

            var curriedMethod = Curry(TestMethod);

            curriedMethod(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15);

            hasBeenCalled.Should().BeTrue();
        }

    }
}
