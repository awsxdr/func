namespace Func
{
#if NETSTANDARD2_1
    using static Option;
#else
    using static OptionHelper;
#endif

    public static class UnionExtensionMethods
    {
        public static bool Is<T>(this Union @this) => @this.Value is Some<T>;
        public static bool Is<T>(this Union @this, out T value)
        {
            if (@this.Value is Some<T> s)
            {
                value = s.Value;
                return true;
            }
            else
            {
                value = default(T);
                return false;
            }
        }
    }

    public interface Union
    {
        Option Value { get; }
    }


    public class Union<T1, T2> : Union
    {
        public Option Value { get; protected set; }

        protected Union() => Value = None();
        protected Union(T1 value) => Value = Some(value);
        protected Union(T2 value) => Value = Some(value);

        public static implicit operator Union<T1, T2>(T1 value) => new Union<T1, T2>(value);
        public static implicit operator Union<T1, T2>(T2 value) => new Union<T1, T2>(value);
    }

    public class Union<T1, T2, T3> : Union
    {
        public Option Value { get; protected set; }

        protected Union() => Value = None();
        protected Union(T1 value) => Value = Some(value);
        protected Union(T2 value) => Value = Some(value);
        protected Union(T3 value) => Value = Some(value);

        public static implicit operator Union<T1, T2, T3>(T1 value) => new Union<T1, T2, T3>(value);
        public static implicit operator Union<T1, T2, T3>(T2 value) => new Union<T1, T2, T3>(value);
        public static implicit operator Union<T1, T2, T3>(T3 value) => new Union<T1, T2, T3>(value);
    }

    public class Union<T1, T2, T3, T4> : Union
    {
        public Option Value { get; protected set; }

        protected Union() => Value = None();
        protected Union(T1 value) => Value = Some(value);
        protected Union(T2 value) => Value = Some(value);
        protected Union(T3 value) => Value = Some(value);
        protected Union(T4 value) => Value = Some(value);

        public static implicit operator Union<T1, T2, T3, T4>(T1 value) => new Union<T1, T2, T3, T4>(value);
        public static implicit operator Union<T1, T2, T3, T4>(T2 value) => new Union<T1, T2, T3, T4>(value);
        public static implicit operator Union<T1, T2, T3, T4>(T3 value) => new Union<T1, T2, T3, T4>(value);
        public static implicit operator Union<T1, T2, T3, T4>(T4 value) => new Union<T1, T2, T3, T4>(value);
    }

    public class Union<T1, T2, T3, T4, T5> : Union
    {
        public Option Value { get; protected set; }

        protected Union() => Value = None();
        protected Union(T1 value) => Value = Some(value);
        protected Union(T2 value) => Value = Some(value);
        protected Union(T3 value) => Value = Some(value);
        protected Union(T4 value) => Value = Some(value);
        protected Union(T5 value) => Value = Some(value);

        public static implicit operator Union<T1, T2, T3, T4, T5>(T1 value) => new Union<T1, T2, T3, T4, T5>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5>(T2 value) => new Union<T1, T2, T3, T4, T5>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5>(T3 value) => new Union<T1, T2, T3, T4, T5>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5>(T4 value) => new Union<T1, T2, T3, T4, T5>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5>(T5 value) => new Union<T1, T2, T3, T4, T5>(value);
    }

    public class Union<T1, T2, T3, T4, T5, T6> : Union
    {
        public Option Value { get; protected set; }

        protected Union() => Value = None();
        protected Union(T1 value) => Value = Some(value);
        protected Union(T2 value) => Value = Some(value);
        protected Union(T3 value) => Value = Some(value);
        protected Union(T4 value) => Value = Some(value);
        protected Union(T5 value) => Value = Some(value);
        protected Union(T6 value) => Value = Some(value);

        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T1 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T2 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T3 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T4 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T5 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T6 value) => new Union<T1, T2, T3, T4, T5, T6>(value);
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7> : Union
    {
        public Option Value { get; protected set; }

        protected Union() => Value = None();
        protected Union(T1 value) => Value = Some(value);
        protected Union(T2 value) => Value = Some(value);
        protected Union(T3 value) => Value = Some(value);
        protected Union(T4 value) => Value = Some(value);
        protected Union(T5 value) => Value = Some(value);
        protected Union(T6 value) => Value = Some(value);
        protected Union(T7 value) => Value = Some(value);

        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T1 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T2 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T3 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T4 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T5 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T6 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T7 value) => new Union<T1, T2, T3, T4, T5, T6, T7>(value);
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7, T8> : Union
    {
        public Option Value { get; protected set; }

        protected Union() => Value = None();
        protected Union(T1 value) => Value = Some(value);
        protected Union(T2 value) => Value = Some(value);
        protected Union(T3 value) => Value = Some(value);
        protected Union(T4 value) => Value = Some(value);
        protected Union(T5 value) => Value = Some(value);
        protected Union(T6 value) => Value = Some(value);
        protected Union(T7 value) => Value = Some(value);
        protected Union(T8 value) => Value = Some(value);

        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> : Union
    {
        public Option Value { get; protected set; }

        protected Union() => Value = None();
        protected Union(T1 value) => Value = Some(value);
        protected Union(T2 value) => Value = Some(value);
        protected Union(T3 value) => Value = Some(value);
        protected Union(T4 value) => Value = Some(value);
        protected Union(T5 value) => Value = Some(value);
        protected Union(T6 value) => Value = Some(value);
        protected Union(T7 value) => Value = Some(value);
        protected Union(T8 value) => Value = Some(value);
        protected Union(T9 value) => Value = Some(value);

        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : Union
    {
        public Option Value { get; protected set; }

        protected Union() => Value = None();
        protected Union(T1 value) => Value = Some(value);
        protected Union(T2 value) => Value = Some(value);
        protected Union(T3 value) => Value = Some(value);
        protected Union(T4 value) => Value = Some(value);
        protected Union(T5 value) => Value = Some(value);
        protected Union(T6 value) => Value = Some(value);
        protected Union(T7 value) => Value = Some(value);
        protected Union(T8 value) => Value = Some(value);
        protected Union(T9 value) => Value = Some(value);
        protected Union(T10 value) => Value = Some(value);

        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value) => new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
    }
}

