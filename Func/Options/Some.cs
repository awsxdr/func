// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    using System;

    public interface Some : Option
    {
    }

    public interface Some<TValue> : Some, Option<TValue>, IEquatable<TValue>, IEquatable<Some<TValue>>
    {
        TValue Value { get; }
    }

    internal class SomeClass<TValue> : Some<TValue>
    {
        public TValue Value { get; }

#if !NETSTANDARD2_1
        public Option GetValue<TDesiredValue>(Action<TDesiredValue> valueReceiver)
        {
            if (Value is TDesiredValue v)
                valueReceiver(v);

            return this;
        }

        public Option IfNone(Action ifNone) => this;
#endif

        internal SomeClass(TValue value) => Value = value;

        public bool Equals(TValue other) => Value.Equals(other);
        public bool Equals(Some<TValue> other) => Value.Equals(other.Value);

        public static implicit operator TValue(SomeClass<TValue> value) => value.Value;
        public static implicit operator SomeClass<TValue>(TValue value) => new SomeClass<TValue>(value);

        public override string ToString() => Value.ToString();
    }
}
#pragma warning restore IDE1006