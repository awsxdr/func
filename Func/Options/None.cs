// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
#if !NETSTANDARD2_1
    using System;
#endif

    public interface None : Option
    {
    }

    public interface None<TValue> : None, Option<TValue>
    {
    }

    internal class NoneClass<TValue> : None<TValue>
    {
#if !NETSTANDARD2_1
        public Option GetValue<TValue1>(Action<TValue1> valueReceiver) => this;
        public Option IfNone(Action ifNone)
        {
            ifNone();
            return this;
        }
#endif

        public override bool Equals(object obj) =>
            obj is None<TValue>;

        public override int GetHashCode() => base.GetHashCode();

        public override string ToString() => "{ Empty }";
    }
}
#pragma warning restore IDE1006