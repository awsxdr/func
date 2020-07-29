// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    public interface Option
    {
        public static Option<TValue> Some<TValue>(TValue value) =>
            new SomeClass<TValue>(value);

        public static Option None() => new NoneClass<object>();

        public static Option<TValue> None<TValue>() => new NoneClass<TValue>();
    }

    public interface Option<TValue> : Option
    {
    }
}
#pragma warning restore IDE1006