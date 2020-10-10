namespace Func
{
	using System;
	using System.Threading.Tasks;
	
	public static class TeeExtensionMethods
	{
		public static Task<TValue1> Tee<TValue1>(this Task<TValue1> valueTask, Func<TValue1, Task> func) =>
			valueTask.ContinueWith(async value1 =>
			{
				await func(value1.Result);
				return value1.Result;
			}).Unwrap();

		public static Task<TValue1> Tee<TValue1>(this Task<TValue1> valueTask, Action<TValue1> func) =>
			valueTask.ContinueWith(value1 =>
			{
				func(value1.Result);
				return value1.Result;
			});

		public static async Task<TValue1> Tee<TValue1>(this TValue1 value1, Func<TValue1, Task> func)
		{
			await func(value1);
			return value1;
		}

		public static TValue1 Tee<TValue1>(this TValue1 value1, Action<TValue1> func)
		{
			func(value1);
			return value1;
		}

		public static Task<TValue1> Tee<TValue1, TIgnored>(this Task<TValue1> valueTask, Func<TValue1, Task<TIgnored>> func) =>
			valueTask.ContinueWith(async value1 =>
			{
				await func(value1.Result);
				return value1.Result;
			}).Unwrap();

		public static Task<TValue1> Tee<TValue1, TIgnored>(this Task<TValue1> valueTask, Func<TValue1, TIgnored> func) =>
			valueTask.ContinueWith(value1 =>
			{
				func(value1.Result);
				return value1.Result;
			});

		public static async Task<TValue1> Tee<TValue1, TIgnored>(this TValue1 value1, Func<TValue1, Task<TIgnored>> func)
		{
			await func(value1);
			return value1;
		}

		public static TValue1 Tee<TValue1, TIgnored>(this TValue1 value1, Func<TValue1, TIgnored> func)
		{
			func(value1);
			return value1;
		}

		public static Task<TValue2> Tee<TValue1, TValue2>(this Task<TValue2> valueTask, Func<TValue1, TValue2, Task> func, TValue1 value1) =>
			valueTask.ContinueWith(async value2 =>
			{
				await func(value1, value2.Result);
				return value2.Result;
			}).Unwrap();

		public static Task<TValue2> Tee<TValue1, TValue2>(this Task<TValue2> valueTask, Action<TValue1, TValue2> func, TValue1 value1) =>
			valueTask.ContinueWith(value2 =>
			{
				func(value1, value2.Result);
				return value2.Result;
			});

		public static async Task<TValue2> Tee<TValue1, TValue2>(this TValue2 value2, Func<TValue1, TValue2, Task> func, TValue1 value1)
		{
			await func(value1, value2);
			return value2;
		}

		public static TValue2 Tee<TValue1, TValue2>(this TValue2 value2, Action<TValue1, TValue2> func, TValue1 value1)
		{
			func(value1, value2);
			return value2;
		}

		public static Task<TValue2> Tee<TValue1, TValue2, TIgnored>(this Task<TValue2> valueTask, Func<TValue1, TValue2, Task<TIgnored>> func, TValue1 value1) =>
			valueTask.ContinueWith(async value2 =>
			{
				await func(value1, value2.Result);
				return value2.Result;
			}).Unwrap();

		public static Task<TValue2> Tee<TValue1, TValue2, TIgnored>(this Task<TValue2> valueTask, Func<TValue1, TValue2, TIgnored> func, TValue1 value1) =>
			valueTask.ContinueWith(value2 =>
			{
				func(value1, value2.Result);
				return value2.Result;
			});

		public static async Task<TValue2> Tee<TValue1, TValue2, TIgnored>(this TValue2 value2, Func<TValue1, TValue2, Task<TIgnored>> func, TValue1 value1)
		{
			await func(value1, value2);
			return value2;
		}

		public static TValue2 Tee<TValue1, TValue2, TIgnored>(this TValue2 value2, Func<TValue1, TValue2, TIgnored> func, TValue1 value1)
		{
			func(value1, value2);
			return value2;
		}

		public static Task<TValue3> Tee<TValue1, TValue2, TValue3>(this Task<TValue3> valueTask, Func<TValue1, TValue2, TValue3, Task> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(async value3 =>
			{
				await func(value1, value2, value3.Result);
				return value3.Result;
			}).Unwrap();

		public static Task<TValue3> Tee<TValue1, TValue2, TValue3>(this Task<TValue3> valueTask, Action<TValue1, TValue2, TValue3> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(value3 =>
			{
				func(value1, value2, value3.Result);
				return value3.Result;
			});

		public static async Task<TValue3> Tee<TValue1, TValue2, TValue3>(this TValue3 value3, Func<TValue1, TValue2, TValue3, Task> func, TValue1 value1, TValue2 value2)
		{
			await func(value1, value2, value3);
			return value3;
		}

		public static TValue3 Tee<TValue1, TValue2, TValue3>(this TValue3 value3, Action<TValue1, TValue2, TValue3> func, TValue1 value1, TValue2 value2)
		{
			func(value1, value2, value3);
			return value3;
		}

		public static Task<TValue3> Tee<TValue1, TValue2, TValue3, TIgnored>(this Task<TValue3> valueTask, Func<TValue1, TValue2, TValue3, Task<TIgnored>> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(async value3 =>
			{
				await func(value1, value2, value3.Result);
				return value3.Result;
			}).Unwrap();

		public static Task<TValue3> Tee<TValue1, TValue2, TValue3, TIgnored>(this Task<TValue3> valueTask, Func<TValue1, TValue2, TValue3, TIgnored> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(value3 =>
			{
				func(value1, value2, value3.Result);
				return value3.Result;
			});

		public static async Task<TValue3> Tee<TValue1, TValue2, TValue3, TIgnored>(this TValue3 value3, Func<TValue1, TValue2, TValue3, Task<TIgnored>> func, TValue1 value1, TValue2 value2)
		{
			await func(value1, value2, value3);
			return value3;
		}

		public static TValue3 Tee<TValue1, TValue2, TValue3, TIgnored>(this TValue3 value3, Func<TValue1, TValue2, TValue3, TIgnored> func, TValue1 value1, TValue2 value2)
		{
			func(value1, value2, value3);
			return value3;
		}

		public static Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, Task> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(async value4 =>
			{
				await func(value1, value2, value3, value4.Result);
				return value4.Result;
			}).Unwrap();

		public static Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4>(this Task<TValue4> valueTask, Action<TValue1, TValue2, TValue3, TValue4> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(value4 =>
			{
				func(value1, value2, value3, value4.Result);
				return value4.Result;
			});

		public static async Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4>(this TValue4 value4, Func<TValue1, TValue2, TValue3, TValue4, Task> func, TValue1 value1, TValue2 value2, TValue3 value3)
		{
			await func(value1, value2, value3, value4);
			return value4;
		}

		public static TValue4 Tee<TValue1, TValue2, TValue3, TValue4>(this TValue4 value4, Action<TValue1, TValue2, TValue3, TValue4> func, TValue1 value1, TValue2 value2, TValue3 value3)
		{
			func(value1, value2, value3, value4);
			return value4;
		}

		public static Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4, TIgnored>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(async value4 =>
			{
				await func(value1, value2, value3, value4.Result);
				return value4.Result;
			}).Unwrap();

		public static Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4, TIgnored>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(value4 =>
			{
				func(value1, value2, value3, value4.Result);
				return value4.Result;
			});

		public static async Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4, TIgnored>(this TValue4 value4, Func<TValue1, TValue2, TValue3, TValue4, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3)
		{
			await func(value1, value2, value3, value4);
			return value4;
		}

		public static TValue4 Tee<TValue1, TValue2, TValue3, TValue4, TIgnored>(this TValue4 value4, Func<TValue1, TValue2, TValue3, TValue4, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3)
		{
			func(value1, value2, value3, value4);
			return value4;
		}

		public static Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(async value5 =>
			{
				await func(value1, value2, value3, value4, value5.Result);
				return value5.Result;
			}).Unwrap();

		public static Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<TValue5> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(value5 =>
			{
				func(value1, value2, value3, value4, value5.Result);
				return value5.Result;
			});

		public static async Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5>(this TValue5 value5, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4)
		{
			await func(value1, value2, value3, value4, value5);
			return value5;
		}

		public static TValue5 Tee<TValue1, TValue2, TValue3, TValue4, TValue5>(this TValue5 value5, Action<TValue1, TValue2, TValue3, TValue4, TValue5> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4)
		{
			func(value1, value2, value3, value4, value5);
			return value5;
		}

		public static Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(async value5 =>
			{
				await func(value1, value2, value3, value4, value5.Result);
				return value5.Result;
			}).Unwrap();

		public static Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(value5 =>
			{
				func(value1, value2, value3, value4, value5.Result);
				return value5.Result;
			});

		public static async Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored>(this TValue5 value5, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4)
		{
			await func(value1, value2, value3, value4, value5);
			return value5;
		}

		public static TValue5 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored>(this TValue5 value5, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4)
		{
			func(value1, value2, value3, value4, value5);
			return value5;
		}

		public static Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(async value6 =>
			{
				await func(value1, value2, value3, value4, value5, value6.Result);
				return value6.Result;
			}).Unwrap();

		public static Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<TValue6> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(value6 =>
			{
				func(value1, value2, value3, value4, value5, value6.Result);
				return value6.Result;
			});

		public static async Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this TValue6 value6, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5)
		{
			await func(value1, value2, value3, value4, value5, value6);
			return value6;
		}

		public static TValue6 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this TValue6 value6, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5)
		{
			func(value1, value2, value3, value4, value5, value6);
			return value6;
		}

		public static Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(async value6 =>
			{
				await func(value1, value2, value3, value4, value5, value6.Result);
				return value6.Result;
			}).Unwrap();

		public static Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(value6 =>
			{
				func(value1, value2, value3, value4, value5, value6.Result);
				return value6.Result;
			});

		public static async Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored>(this TValue6 value6, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5)
		{
			await func(value1, value2, value3, value4, value5, value6);
			return value6;
		}

		public static TValue6 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored>(this TValue6 value6, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5)
		{
			func(value1, value2, value3, value4, value5, value6);
			return value6;
		}

	}
}

