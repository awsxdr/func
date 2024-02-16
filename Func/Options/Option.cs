// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
#if !NETSTANDARD2_1
    using System;
#endif

#if NETSTANDARD2_1
    public interface Option
#else
    public static class OptionHelper
#endif
    {
        public static Option<TValue> Some<TValue>(TValue value) =>
            new SomeClass<TValue>(value);

        public static Option None() => new NoneClass<object>();

        public static Option<TValue> None<TValue>() => new NoneClass<TValue>();
    }

#if !NETSTANDARD2_1
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