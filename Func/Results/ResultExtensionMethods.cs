namespace Func
{
    using System;
    using System.Threading.Tasks;

    public static class ResultExtensionMethods
    {
        public static Result OnSuccess(this Result @this, Action func)
        {
            if(@this is Success) func();
            return @this;
        }

        public static async Task<Result> OnSuccess(this Result @this, Func<Task> func)
        {
            if(@this is Success) await func();
            return @this;
        }

        public static Result OnError(this Result @this, Action func)
        {
            if (@this is Failure) func();
            return @this;
        }

        public static async Task<Result> OnError(this Result @this, Func<Task> func)
        {
            if (@this is Failure) await func();
            return @this;
        }

        public static Result OnError<TError>(this Result @this, Action<TError> func) where TError : ResultError
        {
            if (@this is Failure<TError> f) func(f.Error);
            return @this;
        }

        public static async Task<Result> OnError<TError>(this Result @this, Func<TError, Task> func) where TError : ResultError
        {
            if (@this is Failure<TError> f) await func(f.Error);
            return @this;
        }
    }
}
