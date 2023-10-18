#if NETSTANDARD2_1
using static Func.Result;
#else
using static Func.ResultHelper;
#endif


namespace Func
{
    public static class ResultChainingExtensionMethods
    {
        public static Result And(this Result @this, Result and) =>
            @this.Then(() => and);

        public static Result<TAnd> And<TAnd>(this Result @this, Result<TAnd> and) =>
            @this.Then(() => and);

        public static Result<TThis> And<TThis>(this Result<TThis> @this, Result and) =>
            @this.Then(value => and.Then(() => Succeed(value)));

        public static Result<(TThis1, TAnd1)> And<TThis1, TAnd1>(this Result<TThis1> @this, Result<TAnd1> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed((thisValue, andValue))));

        public static Result<(TThis1, TAnd1, TAnd2)> And<TThis1, TAnd1, TAnd2>(this Result<TThis1> @this, Result<(TAnd1, TAnd2)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TAnd1, TAnd2, TAnd3)> And<TThis1, TAnd1, TAnd2, TAnd3>(this Result<TThis1> @this, Result<(TAnd1, TAnd2, TAnd3)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TAnd1, TAnd2, TAnd3, TAnd4)> And<TThis1, TAnd1, TAnd2, TAnd3, TAnd4>(this Result<TThis1> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> And<TThis1, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5>(this Result<TThis1> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> And<TThis1, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6>(this Result<TThis1> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TAnd1)> And<TThis1, TThis2, TAnd1>(this Result<(TThis1, TThis2)> @this, Result<TAnd1> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TAnd1, TAnd2)> And<TThis1, TThis2, TAnd1, TAnd2>(this Result<(TThis1, TThis2)> @this, Result<(TAnd1, TAnd2)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TAnd1, TAnd2, TAnd3)> And<TThis1, TThis2, TAnd1, TAnd2, TAnd3>(this Result<(TThis1, TThis2)> @this, Result<(TAnd1, TAnd2, TAnd3)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TAnd1, TAnd2, TAnd3, TAnd4)> And<TThis1, TThis2, TAnd1, TAnd2, TAnd3, TAnd4>(this Result<(TThis1, TThis2)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> And<TThis1, TThis2, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5>(this Result<(TThis1, TThis2)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> And<TThis1, TThis2, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6>(this Result<(TThis1, TThis2)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TAnd1)> And<TThis1, TThis2, TThis3, TAnd1>(this Result<(TThis1, TThis2, TThis3)> @this, Result<TAnd1> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TAnd1, TAnd2)> And<TThis1, TThis2, TThis3, TAnd1, TAnd2>(this Result<(TThis1, TThis2, TThis3)> @this, Result<(TAnd1, TAnd2)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TAnd1, TAnd2, TAnd3)> And<TThis1, TThis2, TThis3, TAnd1, TAnd2, TAnd3>(this Result<(TThis1, TThis2, TThis3)> @this, Result<(TAnd1, TAnd2, TAnd3)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TAnd1, TAnd2, TAnd3, TAnd4)> And<TThis1, TThis2, TThis3, TAnd1, TAnd2, TAnd3, TAnd4>(this Result<(TThis1, TThis2, TThis3)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> And<TThis1, TThis2, TThis3, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5>(this Result<(TThis1, TThis2, TThis3)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> And<TThis1, TThis2, TThis3, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6>(this Result<(TThis1, TThis2, TThis3)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TAnd1)> And<TThis1, TThis2, TThis3, TThis4, TAnd1>(this Result<(TThis1, TThis2, TThis3, TThis4)> @this, Result<TAnd1> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2)> And<TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2>(this Result<(TThis1, TThis2, TThis3, TThis4)> @this, Result<(TAnd1, TAnd2)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2, TAnd3)> And<TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2, TAnd3>(this Result<(TThis1, TThis2, TThis3, TThis4)> @this, Result<(TAnd1, TAnd2, TAnd3)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2, TAnd3, TAnd4)> And<TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2, TAnd3, TAnd4>(this Result<(TThis1, TThis2, TThis3, TThis4)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> And<TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5>(this Result<(TThis1, TThis2, TThis3, TThis4)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> And<TThis1, TThis2, TThis3, TThis4, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6>(this Result<(TThis1, TThis2, TThis3, TThis4)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5)> @this, Result<TAnd1> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5)> @this, Result<(TAnd1, TAnd2)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2, TAnd3)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2, TAnd3>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5)> @this, Result<(TAnd1, TAnd2, TAnd3)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2, TAnd3, TAnd4)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2, TAnd3, TAnd4>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6)> @this, Result<TAnd1> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6)> @this, Result<(TAnd1, TAnd2)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2, TAnd3)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2, TAnd3>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6)> @this, Result<(TAnd1, TAnd2, TAnd3)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2, TAnd3, TAnd4)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2, TAnd3, TAnd4>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> And<TThis1, TThis2, TThis3, TThis4, TThis5, TThis6, TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6>(this Result<(TThis1, TThis2, TThis3, TThis4, TThis5, TThis6)> @this, Result<(TAnd1, TAnd2, TAnd3, TAnd4, TAnd5, TAnd6)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

    }
}
