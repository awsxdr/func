// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;


    public interface Success : Result
    {
    }

    public interface Success<TValue> : Result<TValue>, Success
    {
        TValue Value { get; }
    }

    internal class SuccessClass : Success
    {
        public Result Then(Func<Result> resultFunc) => resultFunc();
        public Task<Result> Then(Func<Task<Result>> resultFunc) => resultFunc();
        public Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc) => resultFunc();
        public Task<Result<TResultValue>> Then<TResultValue>(Func<Task<Result<TResultValue>>> resultFunc) => resultFunc();
    }

    internal class SuccessClass<TValue> : Success<TValue>
    {
        public TValue Value { get; }

        public SuccessClass(TValue value) => Value = value;

        public Task<Result> Then(Func<TValue, Task<Result>> resultFunc) => resultFunc(Value);
        public Result Then(Func<TValue, Result> resultFunc) => resultFunc(Value);
        public Task<Result<TResultValue>> Then<TResultValue>(Func<TValue, Task<Result<TResultValue>>> resultFunc) => resultFunc(Value);
        public Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc) => resultFunc(Value);
        public Result Then(Func<Result> resultFunc) => resultFunc();
        public Task<Result> Then(Func<Task<Result>> resultFunc) => resultFunc();
        public Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc) => resultFunc();
        public Task<Result<TResultValue>> Then<TResultValue>(Func<Task<Result<TResultValue>>> resultFunc) => resultFunc();

        public TValue ValueOr(Func<TValue> _) => Value;
        public Task<TValue> ValueOr(Func<Task<TValue>> _) => Value.ToTask();
    }

    public static class SuccessExtensionMethods
    {
#if !NETSTANDARD2_1
        public static Option<object> GetValue(this Success @this) =>
            IsValueSuccess(@this)
            ? @this.Map(GetValueGetter).Invoke(@this, new object[0]).Map(OptionHelper.Some)
            : OptionHelper.None<object>();
#else
        public static Option<object> GetValue(this Success @this) =>
            IsValueSuccess(@this)
            ? @this.Map(GetValueGetter).Invoke(@this, new object[0]).Map(Option.Some)
            : Option.None<object>();
#endif

        private static bool IsValueSuccess(Success success) =>
            success.GetType().IsGenericType &&
            typeof(SuccessClass<>).IsAssignableFrom(success.GetType().GetGenericTypeDefinition());

        private static MethodInfo GetValueGetter(Success success) =>
            typeof(SuccessClass<>).MakeGenericType(success.GetType().GetGenericArguments()).GetProperty("Value").GetGetMethod();
    }
}
#pragma warning restore IDE1006 // Naming Styles
