using System.Collections.Generic;
using System;

namespace test_arr.Extensions { 

public static class EnumerableExtensions
{
	public static void ForEach<TValue>(this IEnumerable<TValue> values, Action<TValue> action)
	{
		foreach (var value in values)
			action(value);
	}
}
}