// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
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

        internal SomeClass(TValue value) => Value = value;
    }
}
#pragma warning restore IDE1006