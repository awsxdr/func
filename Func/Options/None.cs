// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    public interface None : Option
    {
    }

    public interface None<TValue> : None, Option<TValue>
    {
    }

    internal class NoneClass<TValue> : None<TValue>
    {
    }
}
#pragma warning restore IDE1006