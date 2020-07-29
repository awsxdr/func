// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
#if NET45
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
#if NET45
        public Option GetValue<TValue1>(Action<TValue1> valueReceiver) => this;
        public Option IfNone(Action ifNone)
        {
            ifNone();
            return this;
        }
#endif
    }
}
#pragma warning restore IDE1006