// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    using System;
    using System.Threading.Tasks;

    public static class ValueResultExtensionMethods
    {
        public static Result<TResultValue> OnSuccess<TResultValue>(this Result<TResultValue> @this, Action func)
        {
            if (@this is Success) func();
            return @this;
        }

        public static async Task<Result<TResultValue>> OnSuccess<TResultValue>(this Result<TResultValue> @this, Func<Task> func)
        {
            if (@this is Success) await func();
            return @this;
        }

        public static Result<TResultValue> OnSuccess<TResultValue>(this Result<TResultValue> @this, Action<TResultValue> func)
        {
            if(@this is Success<TResultValue> s) func(s.Value);
            return @this;
        }

        public static async Task<Result<TResultValue>> OnSuccess<TResultValue>(this Result<TResultValue> @this, Func<TResultValue, Task> func)
        {
            if(@this is Success<TResultValue> s) await func(s.Value);
            return @this;
        }

        public static Result<TResultValue> OnError<TResultValue>(this Result<TResultValue> @this, Action func)
        {
            if (@this is Failure) func();
            return @this;
        }

        public static async Task<Result<TResultValue>> OnError<TResultValue>(this Result<TResultValue> @this, Func<Task> func)
        {
            if (@this is Failure) await func();
            return @this;
        }

        public static Result<TResultValue> OnError<TError, TResultValue>(this Result<TResultValue> @this, Action<TError> func) 
            where TError : ResultError
        {
            if (@this is Failure<TError> f) func(f.Error);
            return @this;
        }

        public static async Task<Result<TResultValue>> OnError<TError, TResultValue>(this Result<TResultValue> @this, Func<TError, Task> func) 
            where TError : ResultError
        {
            if (@this is Failure<TError> f) await func(f.Error);
            return @this;
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles
