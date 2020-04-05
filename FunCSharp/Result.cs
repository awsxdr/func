namespace FunCSharp
{
    using System;

    public interface Result
    {
        public static Result Succeed() =>
            new SuccessClass();

        public static Result<TValue> Succeed<TValue>(TValue value) =>
            new SuccessClass<TValue>(value);

        public static Result Fail<TError>(TError error) where TError : ResultError =>
            new FailureClass<object, TError>(error);

        Result Then(Func<Result> resultFunc);
        Result<TValue> Then<TValue>(Func<Result<TValue>> resultFunc);
    }

    public interface Result<TValue> : Result
    {
        public new static Result<TValue> Fail<TError>(TError error) where TError : ResultError =>
            new FailureClass<TValue, TError>(error);

        Result Then(Func<TValue, Result> resultFunc);
        Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc);
    }

    public interface Success : Result
    { }

    public interface Success<TValue> : Result<TValue>, Success
    {
        TValue Value { get; }
    }

    public interface Failure : Result
    { 
    }

    public interface Failure<TError> : Failure where TError : ResultError
    {
        TError Error { get; }
    }

    internal class SuccessClass : Success
    {
        public Result Then(Func<Result> resultFunc) => resultFunc();
        public Result<TValue> Then<TValue>(Func<Result<TValue>> resultFunc) => resultFunc();
    }

    internal class SuccessClass<TValue> : Success<TValue>
    {
        public TValue Value { get; }

        public SuccessClass(TValue value) => Value = value;

        public Result Then(Func<TValue, Result> resultFunc) => resultFunc(Value);
        public Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc) => resultFunc(Value);
        public Result Then(Func<Result> resultFunc) => resultFunc();
        public Result<TValue1> Then<TValue1>(Func<Result<TValue1>> resultFunc) => resultFunc();
    }

    internal class FailureClass<TValue, TError> : Result<TValue>, Failure<TError> where TError : ResultError
    {
        public TError Error { get; }

        public FailureClass(TError error) => Error = error;

        public Result Then(Func<TValue, Result> resultFunc) => this;
        public Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc) => 
            new FailureClass<TResultValue, TError>(Error);
        public Result Then(Func<Result> resultFunc) => this;
        public Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc) =>
            new FailureClass<TResultValue, TError>(Error);
    }
}
