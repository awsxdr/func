namespace FunCSharp
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

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TResult>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(value4 => func(value1, value2, value3, value4.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TResult>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(value4 => func(value1, value2, value3, value4.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TResult>(this TValue4 value4, Func<TValue1, TValue2, TValue3, TValue4, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			func(value1, value2, value3, value4);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(value5 => func(value1, value2, value3, value4, value5.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(value5 => func(value1, value2, value3, value4, value5.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(this TValue5 value5, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			func(value1, value2, value3, value4, value5);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(value6 => func(value1, value2, value3, value4, value5, value6.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(value6 => func(value1, value2, value3, value4, value5, value6.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(this TValue6 value6, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			func(value1, value2, value3, value4, value5, value6);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TResult>(this Task<TValue7> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			valueTask.ContinueWith(value7 => func(value1, value2, value3, value4, value5, value6, value7.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TResult>(this Task<TValue7> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			valueTask.ContinueWith(value7 => func(value1, value2, value3, value4, value5, value6, value7.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TResult>(this TValue7 value7, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			func(value1, value2, value3, value4, value5, value6, value7);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TResult>(this Task<TValue8> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7) =>
			valueTask.ContinueWith(value8 => func(value1, value2, value3, value4, value5, value6, value7, value8.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TResult>(this Task<TValue8> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7) =>
			valueTask.ContinueWith(value8 => func(value1, value2, value3, value4, value5, value6, value7, value8.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TResult>(this TValue8 value8, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7) =>
			func(value1, value2, value3, value4, value5, value6, value7, value8);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TResult>(this Task<TValue9> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8) =>
			valueTask.ContinueWith(value9 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TResult>(this Task<TValue9> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8) =>
			valueTask.ContinueWith(value9 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TResult>(this TValue9 value9, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8) =>
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TResult>(this Task<TValue10> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9) =>
			valueTask.ContinueWith(value10 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TResult>(this Task<TValue10> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9) =>
			valueTask.ContinueWith(value10 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TResult>(this TValue10 value10, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9) =>
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TResult>(this Task<TValue11> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10) =>
			valueTask.ContinueWith(value11 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TResult>(this Task<TValue11> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10) =>
			valueTask.ContinueWith(value11 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TResult>(this TValue11 value11, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10) =>
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TResult>(this Task<TValue12> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11) =>
			valueTask.ContinueWith(value12 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TResult>(this Task<TValue12> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11) =>
			valueTask.ContinueWith(value12 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TResult>(this TValue12 value12, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11) =>
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TResult>(this Task<TValue13> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12) =>
			valueTask.ContinueWith(value13 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TResult>(this Task<TValue13> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12) =>
			valueTask.ContinueWith(value13 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TResult>(this TValue13 value13, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12) =>
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TResult>(this Task<TValue14> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13) =>
			valueTask.ContinueWith(value14 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TResult>(this Task<TValue14> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13) =>
			valueTask.ContinueWith(value14 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TResult>(this TValue14 value14, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13) =>
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TResult>(this Task<TValue15> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, Task<TResult>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14) =>
			valueTask.ContinueWith(value15 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15.Result)).Unwrap();

		public static Task<TResult> Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TResult>(this Task<TValue15> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14) =>
			valueTask.ContinueWith(value15 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15.Result));

		public static TResult Map<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TResult>(this TValue15 value15, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TResult> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14) =>
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

	}
}

