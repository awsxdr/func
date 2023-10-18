namespace Func
{
    using System.Threading.Tasks;
    using System;
#if NETSTANDARD2_1
    using static Option;
    using static Result;
#else
    using static OptionHelper;
    using static ResultHelper;
#endif

    public static class ResultElseExtensionMethods
    {
        public static Result Else(this Result @this, Func<ResultError, Result> @else) =>
            @this is Failure f
            ? @else(f.GetError())
            : @this;

        public static Result<TResult> Else<TResult>(this Result<TResult> @this, Func<ResultError, Result<TResult>> @else) =>
            @this is Failure f
            ? @else(f.GetError())
            : @this;

        public static Result<Option<TThis>> Else<TThis>(this Result<TThis> @this, Func<ResultError, Result> @else) =>
            @this is Failure f
            ? @else(f.GetError()).Then(() => Succeed(None<TThis>()))
            : @this.ThenMap(x => Some(x));

        public static Result<Option<TElse>> Else<TElse>(this Result @this, Func<ResultError, Result<TElse>> @else) =>
            @this is Failure f
            ? @else(f.GetError()).ThenMap(x => Some(x))
            : @this.Then(() => Succeed(None<TElse>()));

        public static Result<Union<TThis, TElse>> Else<TThis, TElse>(this Result<TThis> @this, Func<ResultError, Result<TElse>> @else) =>
            @this is Failure f
            ? @else(f.GetError()).ThenMap(x => (Union<TThis, TElse>)x)
            : @this.ThenMap(x => (Union<TThis, TElse>)x);

        public static Task<Result> Else(this Result @this, Func<ResultError, Task<Result>> @else) =>
            @this is Failure f
            ? @else(f.GetError())
            : @this.ToTask();

        public static async Task<Result> Else(this Task<Result> @this, Func<ResultError, Result> @else) =>
            await @this is Failure f
            ? @else(f.GetError())
            : @this.Result;

        public static async Task<Result> Else(this Task<Result> @this, Func<ResultError, Task<Result>> @else) =>
            await @this is Failure f
            ? await @else(f.GetError())
            : @this.Result;

        public static Task<Result<TResult>> Else<TResult>(this Result<TResult> @this, Func<ResultError, Task<Result<TResult>>> @else) =>
            @this is Failure f
            ? @else(f.GetError())
            : @this.ToTask();

        public static async Task<Result<TResult>> Else<TResult>(this Task<Result<TResult>> @this, Func<ResultError, Result<TResult>> @else) =>
            await @this is Failure f
            ? @else(f.GetError())
            : @this.Result;

        public static async Task<Result<TResult>> Else<TResult>(this Task<Result<TResult>> @this, Func<ResultError, Task<Result<TResult>>> @else) =>
            await @this is Failure f
            ? await @else(f.GetError())
            : @this.Result;

        public static Task<Result<Option<TThis>>> Else<TThis>(this Result<TThis> @this, Func<ResultError, Task<Result>> @else) =>
            @this is Failure f
            ? @else(f.GetError()).Then(() => Succeed(None<TThis>()))
            : @this.ThenMap(x => Some(x)).ToTask();

        public static async Task<Result<Option<TThis>>> Else<TThis>(this Task<Result<TThis>> @this, Func<ResultError, Result> @else) =>
            await @this is Failure f
            ? @else(f.GetError()).Then(() => Succeed(None<TThis>()))
            : await @this.ThenMap(x => Some(x));

        public static async Task<Result<Option<TThis>>> Else<TThis>(this Task<Result<TThis>> @this, Func<ResultError, Task<Result>> @else) =>
            await @this is Failure f
            ? await @else(f.GetError()).Then(() => Succeed(None<TThis>()))
            : await @this.ThenMap(x => Some(x));

        public static Task<Result<Option<TElse>>> Else<TElse>(this Result @this, Func<ResultError, Task<Result<TElse>>> @else) =>
            @this is Failure f
            ? @else(f.GetError()).ThenMap(x => Some(x))
            : @this.Then(() => Succeed(None<TElse>())).ToTask();

        public static async Task<Result<Option<TElse>>> Else<TElse>(this Task<Result> @this, Func<ResultError, Result<TElse>> @else) =>
            await @this is Failure f
            ? @else(f.GetError()).ThenMap(x => Some(x))
            : await @this.Then(() => Succeed(None<TElse>()));

        public static async Task<Result<Option<TElse>>> Else<TElse>(this Task<Result> @this, Func<ResultError, Task<Result<TElse>>> @else) =>
            await @this is Failure f
            ? await @else(f.GetError()).ThenMap(x => Some(x))
            : await @this.Then(()=> Succeed(None<TElse>()));

        public static Task<Result<Union<TThis, TElse>>> Else<TThis, TElse>(this Result<TThis> @this, Func<ResultError, Task<Result<TElse>>> @else) =>
            @this is Failure f
            ? @else(f.GetError()).ThenMap(x => (Union<TThis, TElse>)x)
            : @this.ThenMap(x => (Union<TThis, TElse>)x).ToTask();

        public static async Task<Result<Union<TThis, TElse>>> Else<TThis, TElse>(this Task<Result<TThis>> @this, Func<ResultError, Result<TElse>> @else) =>
            await @this is Failure f
            ? @else(f.GetError()).ThenMap(x => (Union<TThis, TElse>)x)
            : await @this.ThenMap(x => (Union<TThis, TElse>)x);

        public static async Task<Result<Union<TThis, TElse>>> Else<TThis, TElse>(this Task<Result<TThis>> @this, Func<ResultError, Task<Result<TElse>>> @else) =>
            await @this is Failure f
            ? await @else(f.GetError()).ThenMap(x => (Union<TThis, TElse>)x)
            : await @this.ThenMap(x => (Union<TThis, TElse>)x);
    }
}