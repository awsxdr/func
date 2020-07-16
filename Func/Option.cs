namespace Func
{
    using System;

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

    public interface Some<TValue> : Some, Option<TValue>, IEquatable<TValue>, IEquatable<Some<TValue>>
    {
        TValue Value { get; }
    }

    internal class NoneClass<TValue> : None<TValue>
    {
        public override bool Equals(object obj) =>
            obj is None<TValue> ? true : false;

        public override int GetHashCode() => base.GetHashCode();

        public override string ToString() => "{ Empty }";
    }

    internal class SomeClass<TValue> : Some<TValue>
    {
        public TValue Value { get; }

        internal SomeClass(TValue value) => Value = value;

        public bool Equals(TValue other) => Value.Equals(other);
        public bool Equals(Some<TValue> other) => Value.Equals(other.Value);

        public static implicit operator TValue(SomeClass<TValue> value) => value.Value;
        public static implicit operator SomeClass<TValue>(TValue value) => new SomeClass<TValue>(value);

        public override string ToString() => Value.ToString();
    }
}
