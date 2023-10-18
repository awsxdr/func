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

        public static Result<(TThis, TAnd)> And<TThis, TAnd>(this Result<TThis> @this, Result<TAnd> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed((thisValue, andValue))));

        public static Result<(TThis1, TThis2, TAnd)> And<TThis1, TThis2, TAnd>(this Result<(TThis1, TThis2)> @this, Result<TAnd> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis, TAnd1, TAnd2)> And<TThis, TAnd1, TAnd2>(this Result<TThis> @this, Result<(TAnd1, TAnd2)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));

        public static Result<(TThis1, TThis2, TAnd1, TAnd2)> And<TThis1, TThis2, TAnd1, TAnd2>(this Result<(TThis1, TThis2)> @this, Result<(TAnd1, TAnd2)> and) =>
            @this.Then(thisValue => and.Then(andValue => Succeed(thisValue.Combine(andValue))));
    }
}