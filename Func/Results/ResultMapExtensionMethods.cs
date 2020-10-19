namespace Func
{
	using System;
	using System.Threading.Tasks;
#if NETSTANDARD2_1
	using static Func.Result;
#else
	using static Func.ResultHelper;
#endif

	public static class ResultMapExtensionMethods
	{
		public static Task<Result<TResult>> ThenMap<TValue1, TResult>(this Task<Result<TValue1>> valueTask, Func<TValue1, Task<TResult>> func) =>
			valueTask.ContinueWith(result => result.Result.Then(value1 => func(value1).Map(Succeed<TResult>))).Unwrap();

		public static Task<Result<TResult>> ThenMap<TValue1, TResult>(this Task<Result<TValue1>> valueTask, Func<TValue1, TResult> func) =>
			valueTask.ContinueWith(result => result.Result.Then(value1 => func(value1).Map(Succeed)));

		public static Task<Result<TResult>> ThenMap<TValue1, TResult>(this Result<TValue1> result, Func<TValue1, Task<TResult>> func) =>
			result.Then(value1 => func(value1).Map(Succeed<TResult>));

		public static Result<TResult> ThenMap<TValue1, TResult>(this Result<TValue1> result, Func<TValue1, TResult> func) =>
			result.Then(value1 => func(value1).Map(Succeed));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TResult>(this Task<Result<TValue2>> valueTask, Func<TValue1, TValue2, Task<TResult>> func, TValue1 value1) =>
			valueTask.ContinueWith(result => result.Result.Then(value2 => func(value1, value2).Map(Succeed<TResult>))).Unwrap();

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TResult>(this Task<Result<TValue2>> valueTask, Func<TValue1, TValue2, TResult> func, TValue1 value1) =>
			valueTask.ContinueWith(result => result.Result.Then(value2 => func(value1, value2).Map(Succeed)));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TResult>(this Result<TValue2> result, Func<TValue1, TValue2, Task<TResult>> func, TValue1 value1) =>
			result.Then(value2 => func(value1, value2).Map(Succeed<TResult>));

		public static Result<TResult> ThenMap<TValue1, TValue2, TResult>(this Result<TValue2> result, Func<TValue1, TValue2, TResult> func, TValue1 value1) =>
			result.Then(value2 => func(value1, value2).Map(Succeed));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TResult>(this Task<Result<TValue3>> valueTask, Func<TValue1, TValue2, TValue3, Task<TResult>> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(result => result.Result.Then(value3 => func(value1, value2, value3).Map(Succeed<TResult>))).Unwrap();

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TResult>(this Task<Result<TValue3>> valueTask, Func<TValue1, TValue2, TValue3, TResult> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(result => result.Result.Then(value3 => func(value1, value2, value3).Map(Succeed)));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TResult>(this Result<TValue3> result, Func<TValue1, TValue2, TValue3, Task<TResult>> func, TValue1 value1, TValue2 value2) =>
			result.Then(value3 => func(value1, value2, value3).Map(Succeed<TResult>));

		public static Result<TResult> ThenMap<TValue1, TValue2, TValue3, TResult>(this Result<TValue3> result, Func<TValue1, TValue2, TValue3, TResult> func, TValue1 value1, TValue2 value2) =>
			result.Then(value3 => func(value1, value2, value3).Map(Succeed));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TValue4, TResult>(this Task<Result<TValue4>> valueTask, Func<TValue1, TValue2, TValue3, TValue4, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(result => result.Result.Then(value4 => func(value1, value2, value3, value4).Map(Succeed<TResult>))).Unwrap();

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TValue4, TResult>(this Task<Result<TValue4>> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(result => result.Result.Then(value4 => func(value1, value2, value3, value4).Map(Succeed)));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TValue4, TResult>(this Result<TValue4> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			result.Then(value4 => func(value1, value2, value3, value4).Map(Succeed<TResult>));

		public static Result<TResult> ThenMap<TValue1, TValue2, TValue3, TValue4, TResult>(this Result<TValue4> result, Func<TValue1, TValue2, TValue3, TValue4, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			result.Then(value4 => func(value1, value2, value3, value4).Map(Succeed));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this Task<Result<TValue5>> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(result => result.Result.Then(value5 => func(value1, value2, value3, value4, value5).Map(Succeed<TResult>))).Unwrap();

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this Task<Result<TValue5>> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(result => result.Result.Then(value5 => func(value1, value2, value3, value4, value5).Map(Succeed)));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this Result<TValue5> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			result.Then(value5 => func(value1, value2, value3, value4, value5).Map(Succeed<TResult>));

		public static Result<TResult> ThenMap<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this Result<TValue5> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			result.Then(value5 => func(value1, value2, value3, value4, value5).Map(Succeed));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this Task<Result<TValue6>> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(result => result.Result.Then(value6 => func(value1, value2, value3, value4, value5, value6).Map(Succeed<TResult>))).Unwrap();

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this Task<Result<TValue6>> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(result => result.Result.Then(value6 => func(value1, value2, value3, value4, value5, value6).Map(Succeed)));

		public static Task<Result<TResult>> ThenMap<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this Result<TValue6> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			result.Then(value6 => func(value1, value2, value3, value4, value5, value6).Map(Succeed<TResult>));

		public static Result<TResult> ThenMap<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this Result<TValue6> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			result.Then(value6 => func(value1, value2, value3, value4, value5, value6).Map(Succeed));

	}
}

