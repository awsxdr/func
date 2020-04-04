namespace FunCSharp.Option
{
    public interface Option
    {
        public static Option Some<TValue>(TValue value) =>
            new SomeClass<TValue>(value);

        public static Option None() => new NoneClass();
    }

    public interface None : Option
    {
    }

    public interface Some : Option
    {
    }

    public interface Some<TValue> : Some
    {
        TValue Value { get; }
    }

    internal class NoneClass : None
    {
    }

    internal class SomeClass<TValue> : Some<TValue>
    {
        public TValue Value { get; }

        internal SomeClass(TValue value) => Value = value;
    }
}
