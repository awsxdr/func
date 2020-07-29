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

    public interface None : Option
    {
    }

    public interface None<TValue> : None, Option<TValue>
    {
    }

    public interface Some : Option
    {
    }

    public interface Some<TValue> : Some, Option<TValue>
    {
        TValue Value { get; }
    }

    internal class NoneClass<TValue> : None<TValue>
    {
    }

    internal class SomeClass<TValue> : Some<TValue>
    {
        public TValue Value { get; }

        internal SomeClass(TValue value) => Value = value;
    }
}
