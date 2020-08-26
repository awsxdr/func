






namespace Func
{
	using System;
	using System.Threading.Tasks;

	public static class MapExtensionMethods
	{

		public static Task<TResult> Map<TValue1, TResult>(this Task<TValue1> valueTask, Func<TValue1, Task<TResult>> func) =>
			valueTask.ContinueWith(value1 => func(value1.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TResult>(this Task<TValue1> valueTask, Func<TValue1, TResult> func) =>
			valueTask.ContinueWith(value1 => func(value1.Result));

		public static TResult Map<TValue1, TResult>(this TValue1 value1, Func<TValue1, TResult> func) =>
			func(value1);



		public static Task<TResult> Map<TValue1, TValue2, TResult>(this Task<TValue2> valueTask, Func<TValue1, TValue2, Task<TResult>> func, TValue1 value1) =>
			valueTask.ContinueWith(value2 => func(value1, value2.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TResult>(this Task<TValue2> valueTask, Func<TValue1, TValue2, TResult> func, TValue1 value1) =>
			valueTask.ContinueWith(value2 => func(value1, value2.Result));

		public static TResult Map<TValue1, TValue2, TResult>(this TValue2 value2, Func<TValue1, TValue2, TResult> func, TValue1 value1) =>
			func(value1, value2);



		public static Task<TResult> Map<TValue1, TValue2, TValue3, TResult>(this Task<TValue3> valueTask, Func<TValue1, TValue2, TValue3, Task<TResult>> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(value3 => func(value1, value2, value3.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TResult>(this Task<TValue3> valueTask, Func<TValue1, TValue2, TValue3, TResult> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(value3 => func(value1, value2, value3.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TResult>(this TValue3 value3, Func<TValue1, TValue2, TValue3, TResult> func, TValue1 value1, TValue2 value2) =>
			func(value1, value2, value3);


		public static Func<TValue2, TValue3, TResult> Map<TValue1, TValue2, TValue3, TResult>(this TValue1 value1, Func<TValue1, TValue2, TValue3, TResult> func) =>
			(value2, value3) => func(value1, value2, value3);



		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TResult>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(value4 => func(value1, value2, value3, value4.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TResult>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(value4 => func(value1, value2, value3, value4.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TResult>(this TValue4 value4, Func<TValue1, TValue2, TValue3, TValue4, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			func(value1, value2, value3, value4);


		public static Func<TValue2, TValue3, TValue4, TResult> Map<TValue1, TValue2, TValue3, TValue4, TResult>(this TValue1 value1, Func<TValue1, TValue2, TValue3, TValue4, TResult> func) =>
			(value2, value3, value4) => func(value1, value2, value3, value4);


		public static Func<TValue3, TValue4, TResult> Map<TValue1, TValue2, TValue3, TValue4, TResult>(this TValue2 value2, Func<TValue1, TValue2, TValue3, TValue4, TResult> func, TValue1 value1) =>
			(value3, value4) => func(value1, value2, value3, value4);



		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(value5 => func(value1, value2, value3, value4, value5.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(value5 => func(value1, value2, value3, value4, value5.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this TValue5 value5, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			func(value1, value2, value3, value4, value5);


		public static Func<TValue2, TValue3, TValue4, TValue5, TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this TValue1 value1, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func) =>
			(value2, value3, value4, value5) => func(value1, value2, value3, value4, value5);


		public static Func<TValue3, TValue4, TValue5, TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this TValue2 value2, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func, TValue1 value1) =>
			(value3, value4, value5) => func(value1, value2, value3, value4, value5);


		public static Func<TValue4, TValue5, TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this TValue3 value3, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func, TValue1 value1, TValue2 value2) =>
			(value4, value5) => func(value1, value2, value3, value4, value5);



		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(value6 => func(value1, value2, value3, value4, value5, value6.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(value6 => func(value1, value2, value3, value4, value5, value6.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this TValue6 value6, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			func(value1, value2, value3, value4, value5, value6);


		public static Func<TValue2, TValue3, TValue4, TValue5, TValue6, TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this TValue1 value1, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func) =>
			(value2, value3, value4, value5, value6) => func(value1, value2, value3, value4, value5, value6);


		public static Func<TValue3, TValue4, TValue5, TValue6, TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this TValue2 value2, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func, TValue1 value1) =>
			(value3, value4, value5, value6) => func(value1, value2, value3, value4, value5, value6);


		public static Func<TValue4, TValue5, TValue6, TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this TValue3 value3, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func, TValue1 value1, TValue2 value2) =>
			(value4, value5, value6) => func(value1, value2, value3, value4, value5, value6);


		public static Func<TValue5, TValue6, TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this TValue4 value4, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			(value5, value6) => func(value1, value2, value3, value4, value5, value6);



	}
}

