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

        public override bool Equals(object obj) =>
            (
                obj is Union<T1, T2> other
                && (
                    Value is Some<T1> thisValue1 && other.Value is Some<T1> otherValue1 && thisValue1.Equals(otherValue1)
                    || Value is Some<T2> thisValue2 && other.Value is Some<T2> otherValue2 && thisValue2.Equals(otherValue2)
                )
            ) || (
                obj is Union otherUnion
                && (
                    Value is Some<T1> thisUnionValue1 && otherUnion.Is<T1>(out var otherUnionValue1) && thisUnionValue1.Equals(otherUnionValue1)
                    || Value is Some<T2> thisUnionValue2 && otherUnion.Is<T2>(out var otherUnionValue2) && thisUnionValue2.Equals(otherUnionValue2)
                )
            );

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
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

        public override bool Equals(object obj) =>
            (
                obj is Union<T1, T2, T3> other
                && (
                    Value is Some<T1> thisValue1 && other.Value is Some<T1> otherValue1 && thisValue1.Equals(otherValue1)
                    || Value is Some<T2> thisValue2 && other.Value is Some<T2> otherValue2 && thisValue2.Equals(otherValue2)
                    || Value is Some<T3> thisValue3 && other.Value is Some<T3> otherValue3 && thisValue3.Equals(otherValue3)
                )
            ) || (
                obj is Union otherUnion
                && (
                    Value is Some<T1> thisUnionValue1 && otherUnion.Is<T1>(out var otherUnionValue1) && thisUnionValue1.Equals(otherUnionValue1)
                    || Value is Some<T2> thisUnionValue2 && otherUnion.Is<T2>(out var otherUnionValue2) && thisUnionValue2.Equals(otherUnionValue2)
                    || Value is Some<T3> thisUnionValue3 && otherUnion.Is<T3>(out var otherUnionValue3) && thisUnionValue3.Equals(otherUnionValue3)
                )
            );

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
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

        public override bool Equals(object obj) =>
            (
                obj is Union<T1, T2, T3, T4> other
                && (
                    Value is Some<T1> thisValue1 && other.Value is Some<T1> otherValue1 && thisValue1.Equals(otherValue1)
                    || Value is Some<T2> thisValue2 && other.Value is Some<T2> otherValue2 && thisValue2.Equals(otherValue2)
                    || Value is Some<T3> thisValue3 && other.Value is Some<T3> otherValue3 && thisValue3.Equals(otherValue3)
                    || Value is Some<T4> thisValue4 && other.Value is Some<T4> otherValue4 && thisValue4.Equals(otherValue4)
                )
            ) || (
                obj is Union otherUnion
                && (
                    Value is Some<T1> thisUnionValue1 && otherUnion.Is<T1>(out var otherUnionValue1) && thisUnionValue1.Equals(otherUnionValue1)
                    || Value is Some<T2> thisUnionValue2 && otherUnion.Is<T2>(out var otherUnionValue2) && thisUnionValue2.Equals(otherUnionValue2)
                    || Value is Some<T3> thisUnionValue3 && otherUnion.Is<T3>(out var otherUnionValue3) && thisUnionValue3.Equals(otherUnionValue3)
                    || Value is Some<T4> thisUnionValue4 && otherUnion.Is<T4>(out var otherUnionValue4) && thisUnionValue4.Equals(otherUnionValue4)
                )
            );

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
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

        public override bool Equals(object obj) =>
            (
                obj is Union<T1, T2, T3, T4, T5> other
                && (
                    Value is Some<T1> thisValue1 && other.Value is Some<T1> otherValue1 && thisValue1.Equals(otherValue1)
                    || Value is Some<T2> thisValue2 && other.Value is Some<T2> otherValue2 && thisValue2.Equals(otherValue2)
                    || Value is Some<T3> thisValue3 && other.Value is Some<T3> otherValue3 && thisValue3.Equals(otherValue3)
                    || Value is Some<T4> thisValue4 && other.Value is Some<T4> otherValue4 && thisValue4.Equals(otherValue4)
                    || Value is Some<T5> thisValue5 && other.Value is Some<T5> otherValue5 && thisValue5.Equals(otherValue5)
                )
            ) || (
                obj is Union otherUnion
                && (
                    Value is Some<T1> thisUnionValue1 && otherUnion.Is<T1>(out var otherUnionValue1) && thisUnionValue1.Equals(otherUnionValue1)
                    || Value is Some<T2> thisUnionValue2 && otherUnion.Is<T2>(out var otherUnionValue2) && thisUnionValue2.Equals(otherUnionValue2)
                    || Value is Some<T3> thisUnionValue3 && otherUnion.Is<T3>(out var otherUnionValue3) && thisUnionValue3.Equals(otherUnionValue3)
                    || Value is Some<T4> thisUnionValue4 && otherUnion.Is<T4>(out var otherUnionValue4) && thisUnionValue4.Equals(otherUnionValue4)
                    || Value is Some<T5> thisUnionValue5 && otherUnion.Is<T5>(out var otherUnionValue5) && thisUnionValue5.Equals(otherUnionValue5)
                )
            );

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
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

        public override bool Equals(object obj) =>
            (
                obj is Union<T1, T2, T3, T4, T5, T6> other
                && (
                    Value is Some<T1> thisValue1 && other.Value is Some<T1> otherValue1 && thisValue1.Equals(otherValue1)
                    || Value is Some<T2> thisValue2 && other.Value is Some<T2> otherValue2 && thisValue2.Equals(otherValue2)
                    || Value is Some<T3> thisValue3 && other.Value is Some<T3> otherValue3 && thisValue3.Equals(otherValue3)
                    || Value is Some<T4> thisValue4 && other.Value is Some<T4> otherValue4 && thisValue4.Equals(otherValue4)
                    || Value is Some<T5> thisValue5 && other.Value is Some<T5> otherValue5 && thisValue5.Equals(otherValue5)
                    || Value is Some<T6> thisValue6 && other.Value is Some<T6> otherValue6 && thisValue6.Equals(otherValue6)
                )
            ) || (
                obj is Union otherUnion
                && (
                    Value is Some<T1> thisUnionValue1 && otherUnion.Is<T1>(out var otherUnionValue1) && thisUnionValue1.Equals(otherUnionValue1)
                    || Value is Some<T2> thisUnionValue2 && otherUnion.Is<T2>(out var otherUnionValue2) && thisUnionValue2.Equals(otherUnionValue2)
                    || Value is Some<T3> thisUnionValue3 && otherUnion.Is<T3>(out var otherUnionValue3) && thisUnionValue3.Equals(otherUnionValue3)
                    || Value is Some<T4> thisUnionValue4 && otherUnion.Is<T4>(out var otherUnionValue4) && thisUnionValue4.Equals(otherUnionValue4)
                    || Value is Some<T5> thisUnionValue5 && otherUnion.Is<T5>(out var otherUnionValue5) && thisUnionValue5.Equals(otherUnionValue5)
                    || Value is Some<T6> thisUnionValue6 && otherUnion.Is<T6>(out var otherUnionValue6) && thisUnionValue6.Equals(otherUnionValue6)
                )
            );

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
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

        public override bool Equals(object obj) =>
            (
                obj is Union<T1, T2, T3, T4, T5, T6, T7> other
                && (
                    Value is Some<T1> thisValue1 && other.Value is Some<T1> otherValue1 && thisValue1.Equals(otherValue1)
                    || Value is Some<T2> thisValue2 && other.Value is Some<T2> otherValue2 && thisValue2.Equals(otherValue2)
                    || Value is Some<T3> thisValue3 && other.Value is Some<T3> otherValue3 && thisValue3.Equals(otherValue3)
                    || Value is Some<T4> thisValue4 && other.Value is Some<T4> otherValue4 && thisValue4.Equals(otherValue4)
                    || Value is Some<T5> thisValue5 && other.Value is Some<T5> otherValue5 && thisValue5.Equals(otherValue5)
                    || Value is Some<T6> thisValue6 && other.Value is Some<T6> otherValue6 && thisValue6.Equals(otherValue6)
                    || Value is Some<T7> thisValue7 && other.Value is Some<T7> otherValue7 && thisValue7.Equals(otherValue7)
                )
            ) || (
                obj is Union otherUnion
                && (
                    Value is Some<T1> thisUnionValue1 && otherUnion.Is<T1>(out var otherUnionValue1) && thisUnionValue1.Equals(otherUnionValue1)
                    || Value is Some<T2> thisUnionValue2 && otherUnion.Is<T2>(out var otherUnionValue2) && thisUnionValue2.Equals(otherUnionValue2)
                    || Value is Some<T3> thisUnionValue3 && otherUnion.Is<T3>(out var otherUnionValue3) && thisUnionValue3.Equals(otherUnionValue3)
                    || Value is Some<T4> thisUnionValue4 && otherUnion.Is<T4>(out var otherUnionValue4) && thisUnionValue4.Equals(otherUnionValue4)
                    || Value is Some<T5> thisUnionValue5 && otherUnion.Is<T5>(out var otherUnionValue5) && thisUnionValue5.Equals(otherUnionValue5)
                    || Value is Some<T6> thisUnionValue6 && otherUnion.Is<T6>(out var otherUnionValue6) && thisUnionValue6.Equals(otherUnionValue6)
                    || Value is Some<T7> thisUnionValue7 && otherUnion.Is<T7>(out var otherUnionValue7) && thisUnionValue7.Equals(otherUnionValue7)
                )
            );

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
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

        public override bool Equals(object obj) =>
            (
                obj is Union<T1, T2, T3, T4, T5, T6, T7, T8> other
                && (
                    Value is Some<T1> thisValue1 && other.Value is Some<T1> otherValue1 && thisValue1.Equals(otherValue1)
                    || Value is Some<T2> thisValue2 && other.Value is Some<T2> otherValue2 && thisValue2.Equals(otherValue2)
                    || Value is Some<T3> thisValue3 && other.Value is Some<T3> otherValue3 && thisValue3.Equals(otherValue3)
                    || Value is Some<T4> thisValue4 && other.Value is Some<T4> otherValue4 && thisValue4.Equals(otherValue4)
                    || Value is Some<T5> thisValue5 && other.Value is Some<T5> otherValue5 && thisValue5.Equals(otherValue5)
                    || Value is Some<T6> thisValue6 && other.Value is Some<T6> otherValue6 && thisValue6.Equals(otherValue6)
                    || Value is Some<T7> thisValue7 && other.Value is Some<T7> otherValue7 && thisValue7.Equals(otherValue7)
                    || Value is Some<T8> thisValue8 && other.Value is Some<T8> otherValue8 && thisValue8.Equals(otherValue8)
                )
            ) || (
                obj is Union otherUnion
                && (
                    Value is Some<T1> thisUnionValue1 && otherUnion.Is<T1>(out var otherUnionValue1) && thisUnionValue1.Equals(otherUnionValue1)
                    || Value is Some<T2> thisUnionValue2 && otherUnion.Is<T2>(out var otherUnionValue2) && thisUnionValue2.Equals(otherUnionValue2)
                    || Value is Some<T3> thisUnionValue3 && otherUnion.Is<T3>(out var otherUnionValue3) && thisUnionValue3.Equals(otherUnionValue3)
                    || Value is Some<T4> thisUnionValue4 && otherUnion.Is<T4>(out var otherUnionValue4) && thisUnionValue4.Equals(otherUnionValue4)
                    || Value is Some<T5> thisUnionValue5 && otherUnion.Is<T5>(out var otherUnionValue5) && thisUnionValue5.Equals(otherUnionValue5)
                    || Value is Some<T6> thisUnionValue6 && otherUnion.Is<T6>(out var otherUnionValue6) && thisUnionValue6.Equals(otherUnionValue6)
                    || Value is Some<T7> thisUnionValue7 && otherUnion.Is<T7>(out var otherUnionValue7) && thisUnionValue7.Equals(otherUnionValue7)
                    || Value is Some<T8> thisUnionValue8 && otherUnion.Is<T8>(out var otherUnionValue8) && thisUnionValue8.Equals(otherUnionValue8)
                )
            );

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
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

        public override bool Equals(object obj) =>
            (
                obj is Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> other
                && (
                    Value is Some<T1> thisValue1 && other.Value is Some<T1> otherValue1 && thisValue1.Equals(otherValue1)
                    || Value is Some<T2> thisValue2 && other.Value is Some<T2> otherValue2 && thisValue2.Equals(otherValue2)
                    || Value is Some<T3> thisValue3 && other.Value is Some<T3> otherValue3 && thisValue3.Equals(otherValue3)
                    || Value is Some<T4> thisValue4 && other.Value is Some<T4> otherValue4 && thisValue4.Equals(otherValue4)
                    || Value is Some<T5> thisValue5 && other.Value is Some<T5> otherValue5 && thisValue5.Equals(otherValue5)
                    || Value is Some<T6> thisValue6 && other.Value is Some<T6> otherValue6 && thisValue6.Equals(otherValue6)
                    || Value is Some<T7> thisValue7 && other.Value is Some<T7> otherValue7 && thisValue7.Equals(otherValue7)
                    || Value is Some<T8> thisValue8 && other.Value is Some<T8> otherValue8 && thisValue8.Equals(otherValue8)
                    || Value is Some<T9> thisValue9 && other.Value is Some<T9> otherValue9 && thisValue9.Equals(otherValue9)
                )
            ) || (
                obj is Union otherUnion
                && (
                    Value is Some<T1> thisUnionValue1 && otherUnion.Is<T1>(out var otherUnionValue1) && thisUnionValue1.Equals(otherUnionValue1)
                    || Value is Some<T2> thisUnionValue2 && otherUnion.Is<T2>(out var otherUnionValue2) && thisUnionValue2.Equals(otherUnionValue2)
                    || Value is Some<T3> thisUnionValue3 && otherUnion.Is<T3>(out var otherUnionValue3) && thisUnionValue3.Equals(otherUnionValue3)
                    || Value is Some<T4> thisUnionValue4 && otherUnion.Is<T4>(out var otherUnionValue4) && thisUnionValue4.Equals(otherUnionValue4)
                    || Value is Some<T5> thisUnionValue5 && otherUnion.Is<T5>(out var otherUnionValue5) && thisUnionValue5.Equals(otherUnionValue5)
                    || Value is Some<T6> thisUnionValue6 && otherUnion.Is<T6>(out var otherUnionValue6) && thisUnionValue6.Equals(otherUnionValue6)
                    || Value is Some<T7> thisUnionValue7 && otherUnion.Is<T7>(out var otherUnionValue7) && thisUnionValue7.Equals(otherUnionValue7)
                    || Value is Some<T8> thisUnionValue8 && otherUnion.Is<T8>(out var otherUnionValue8) && thisUnionValue8.Equals(otherUnionValue8)
                    || Value is Some<T9> thisUnionValue9 && otherUnion.Is<T9>(out var otherUnionValue9) && thisUnionValue9.Equals(otherUnionValue9)
                )
            );

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
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

        public override bool Equals(object obj) =>
            (
                obj is Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other
                && (
                    Value is Some<T1> thisValue1 && other.Value is Some<T1> otherValue1 && thisValue1.Equals(otherValue1)
                    || Value is Some<T2> thisValue2 && other.Value is Some<T2> otherValue2 && thisValue2.Equals(otherValue2)
                    || Value is Some<T3> thisValue3 && other.Value is Some<T3> otherValue3 && thisValue3.Equals(otherValue3)
                    || Value is Some<T4> thisValue4 && other.Value is Some<T4> otherValue4 && thisValue4.Equals(otherValue4)
                    || Value is Some<T5> thisValue5 && other.Value is Some<T5> otherValue5 && thisValue5.Equals(otherValue5)
                    || Value is Some<T6> thisValue6 && other.Value is Some<T6> otherValue6 && thisValue6.Equals(otherValue6)
                    || Value is Some<T7> thisValue7 && other.Value is Some<T7> otherValue7 && thisValue7.Equals(otherValue7)
                    || Value is Some<T8> thisValue8 && other.Value is Some<T8> otherValue8 && thisValue8.Equals(otherValue8)
                    || Value is Some<T9> thisValue9 && other.Value is Some<T9> otherValue9 && thisValue9.Equals(otherValue9)
                    || Value is Some<T10> thisValue10 && other.Value is Some<T10> otherValue10 && thisValue10.Equals(otherValue10)
                )
            ) || (
                obj is Union otherUnion
                && (
                    Value is Some<T1> thisUnionValue1 && otherUnion.Is<T1>(out var otherUnionValue1) && thisUnionValue1.Equals(otherUnionValue1)
                    || Value is Some<T2> thisUnionValue2 && otherUnion.Is<T2>(out var otherUnionValue2) && thisUnionValue2.Equals(otherUnionValue2)
                    || Value is Some<T3> thisUnionValue3 && otherUnion.Is<T3>(out var otherUnionValue3) && thisUnionValue3.Equals(otherUnionValue3)
                    || Value is Some<T4> thisUnionValue4 && otherUnion.Is<T4>(out var otherUnionValue4) && thisUnionValue4.Equals(otherUnionValue4)
                    || Value is Some<T5> thisUnionValue5 && otherUnion.Is<T5>(out var otherUnionValue5) && thisUnionValue5.Equals(otherUnionValue5)
                    || Value is Some<T6> thisUnionValue6 && otherUnion.Is<T6>(out var otherUnionValue6) && thisUnionValue6.Equals(otherUnionValue6)
                    || Value is Some<T7> thisUnionValue7 && otherUnion.Is<T7>(out var otherUnionValue7) && thisUnionValue7.Equals(otherUnionValue7)
                    || Value is Some<T8> thisUnionValue8 && otherUnion.Is<T8>(out var otherUnionValue8) && thisUnionValue8.Equals(otherUnionValue8)
                    || Value is Some<T9> thisUnionValue9 && otherUnion.Is<T9>(out var otherUnionValue9) && thisUnionValue9.Equals(otherUnionValue9)
                    || Value is Some<T10> thisUnionValue10 && otherUnion.Is<T10>(out var otherUnionValue10) && thisUnionValue10.Equals(otherUnionValue10)
                )
            );

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
    }
}

