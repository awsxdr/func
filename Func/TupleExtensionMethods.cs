namespace Func
{
    public static class TupleExtensionMethods
    {
        public static (T1, T2, T3) Combine<T1, T2, T3>(this (T1, T2) @this, T3 other) =>
            (@this.Item1, @this.Item2, other);
        public static (T1, T2, T3, T4) Combine<T1, T2, T3, T4>(this (T1, T2, T3) @this, T4 other) =>
            (@this.Item1, @this.Item2, @this.Item3, other);
        public static (T1, T2, T3, T4, T5) Combine<T1, T2, T3, T4, T5>(this (T1, T2, T3, T4) @this, T5 other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, other);
        public static (T1, T2, T3, T4, T5, T6) Combine<T1, T2, T3, T4, T5, T6>(this (T1, T2, T3, T4, T5) @this, T6 other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, other);
        public static (T1, T2, T3, T4, T5, T6, T7) Combine<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5, T6) @this, T7 other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, @this.Item6, other);
        public static (T1, T2, T3) Combine<T1, T2, T3>(this T1 @this, (T2, T3) other) =>
            (@this, other.Item1, other.Item2);
        public static (T1, T2, T3, T4) Combine<T1, T2, T3, T4>(this T1 @this, (T2, T3, T4) other) =>
            (@this, other.Item1, other.Item2, other.Item3);
        public static (T1, T2, T3, T4, T5) Combine<T1, T2, T3, T4, T5>(this T1 @this, (T2, T3, T4, T5) other) =>
            (@this, other.Item1, other.Item2, other.Item3, other.Item4);
        public static (T1, T2, T3, T4, T5, T6) Combine<T1, T2, T3, T4, T5, T6>(this T1 @this, (T2, T3, T4, T5, T6) other) =>
            (@this, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5);
        public static (T1, T2, T3, T4, T5, T6, T7) Combine<T1, T2, T3, T4, T5, T6, T7>(this T1 @this, (T2, T3, T4, T5, T6, T7) other) =>
            (@this, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5, other.Item6);
        public static (T1, T2, T3, T4) Combine<T1, T2, T3, T4>(this (T1, T2) @this, (T3, T4) other) =>
            (@this.Item1, @this.Item2, other.Item1, other.Item2);
        public static (T1, T2, T3, T4, T5) Combine<T1, T2, T3, T4, T5>(this (T1, T2) @this, (T3, T4, T5) other) =>
            (@this.Item1, @this.Item2, other.Item1, other.Item2, other.Item3);
        public static (T1, T2, T3, T4, T5, T6) Combine<T1, T2, T3, T4, T5, T6>(this (T1, T2) @this, (T3, T4, T5, T6) other) =>
            (@this.Item1, @this.Item2, other.Item1, other.Item2, other.Item3, other.Item4);
        public static (T1, T2, T3, T4, T5, T6, T7) Combine<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2) @this, (T3, T4, T5, T6, T7) other) =>
            (@this.Item1, @this.Item2, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5);
        public static (T1, T2, T3, T4, T5, T6, T7, T8) Combine<T1, T2, T3, T4, T5, T6, T7, T8>(this (T1, T2) @this, (T3, T4, T5, T6, T7, T8) other) =>
            (@this.Item1, @this.Item2, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5, other.Item6);
        public static (T1, T2, T3, T4, T5) Combine<T1, T2, T3, T4, T5>(this (T1, T2, T3) @this, (T4, T5) other) =>
            (@this.Item1, @this.Item2, @this.Item3, other.Item1, other.Item2);
        public static (T1, T2, T3, T4, T5, T6) Combine<T1, T2, T3, T4, T5, T6>(this (T1, T2, T3) @this, (T4, T5, T6) other) =>
            (@this.Item1, @this.Item2, @this.Item3, other.Item1, other.Item2, other.Item3);
        public static (T1, T2, T3, T4, T5, T6, T7) Combine<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3) @this, (T4, T5, T6, T7) other) =>
            (@this.Item1, @this.Item2, @this.Item3, other.Item1, other.Item2, other.Item3, other.Item4);
        public static (T1, T2, T3, T4, T5, T6, T7, T8) Combine<T1, T2, T3, T4, T5, T6, T7, T8>(this (T1, T2, T3) @this, (T4, T5, T6, T7, T8) other) =>
            (@this.Item1, @this.Item2, @this.Item3, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this (T1, T2, T3) @this, (T4, T5, T6, T7, T8, T9) other) =>
            (@this.Item1, @this.Item2, @this.Item3, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5, other.Item6);
        public static (T1, T2, T3, T4, T5, T6) Combine<T1, T2, T3, T4, T5, T6>(this (T1, T2, T3, T4) @this, (T5, T6) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, other.Item1, other.Item2);
        public static (T1, T2, T3, T4, T5, T6, T7) Combine<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4) @this, (T5, T6, T7) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, other.Item1, other.Item2, other.Item3);
        public static (T1, T2, T3, T4, T5, T6, T7, T8) Combine<T1, T2, T3, T4, T5, T6, T7, T8>(this (T1, T2, T3, T4) @this, (T5, T6, T7, T8) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, other.Item1, other.Item2, other.Item3, other.Item4);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this (T1, T2, T3, T4) @this, (T5, T6, T7, T8, T9) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this (T1, T2, T3, T4) @this, (T5, T6, T7, T8, T9, T10) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5, other.Item6);
        public static (T1, T2, T3, T4, T5, T6, T7) Combine<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5) @this, (T6, T7) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, other.Item1, other.Item2);
        public static (T1, T2, T3, T4, T5, T6, T7, T8) Combine<T1, T2, T3, T4, T5, T6, T7, T8>(this (T1, T2, T3, T4, T5) @this, (T6, T7, T8) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, other.Item1, other.Item2, other.Item3);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this (T1, T2, T3, T4, T5) @this, (T6, T7, T8, T9) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, other.Item1, other.Item2, other.Item3, other.Item4);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this (T1, T2, T3, T4, T5) @this, (T6, T7, T8, T9, T10) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this (T1, T2, T3, T4, T5) @this, (T6, T7, T8, T9, T10, T11) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5, other.Item6);
        public static (T1, T2, T3, T4, T5, T6, T7, T8) Combine<T1, T2, T3, T4, T5, T6, T7, T8>(this (T1, T2, T3, T4, T5, T6) @this, (T7, T8) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, @this.Item6, other.Item1, other.Item2);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this (T1, T2, T3, T4, T5, T6) @this, (T7, T8, T9) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, @this.Item6, other.Item1, other.Item2, other.Item3);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this (T1, T2, T3, T4, T5, T6) @this, (T7, T8, T9, T10) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, @this.Item6, other.Item1, other.Item2, other.Item3, other.Item4);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this (T1, T2, T3, T4, T5, T6) @this, (T7, T8, T9, T10, T11) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, @this.Item6, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5);
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this (T1, T2, T3, T4, T5, T6) @this, (T7, T8, T9, T10, T11, T12) other) =>
            (@this.Item1, @this.Item2, @this.Item3, @this.Item4, @this.Item5, @this.Item6, other.Item1, other.Item2, other.Item3, other.Item4, other.Item5, other.Item6);
        
    }
}
