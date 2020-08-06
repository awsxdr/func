namespace Func
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtensionMethods
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> func) =>
            @this.Select(x => x.Tee(func));

        public static IEnumerable<T> ForEach<T, TIgnored>(this IEnumerable<T> @this, Func<T, TIgnored> func) =>
            @this.Select(x => x.Tee(func));

        public static void Evaluate<T>(this IEnumerable<T> @this) =>
            _ = @this.ToList();
    }
}
