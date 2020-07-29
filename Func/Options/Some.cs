// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
#if NET45
    using System;
#endif

    public interface Some : Option
    {
    }

    public interface Some<TValue> : Some, Option<TValue>
    {
        TValue Value { get; }
    }

    internal class SomeClass<TValue> : Some<TValue>
    {
        public TValue Value { get; }

#if NET45
        public Option GetValue<TDesiredValue>(Action<TDesiredValue> valueReceiver)
        {
            if (Value is TDesiredValue v)
                valueReceiver(v);

            return this;
        }

        public Option IfNone(Action ifNone) => this;
#endif

        internal SomeClass(TValue value) => Value = value;
    }
}
#pragma warning restore IDE1006