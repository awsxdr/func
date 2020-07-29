// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
#if NET45
    using System;
#endif

#if NET45
    public static class OptionHelper
#else
    public interface Option
#endif
    {
        public static Option<TValue> Some<TValue>(TValue value) =>
            new SomeClass<TValue>(value);

        public static Option None() => new NoneClass<object>();

        public static Option<TValue> None<TValue>() => new NoneClass<TValue>();
    }

#if NET45
    public interface Option
    {
        Option GetValue<TValue>(Action<TValue> valueReceiver);
        Option IfNone(Action ifNone);
    }
#endif

    public interface Option<TValue> : Option
    {
    }
}
#pragma warning restore IDE1006