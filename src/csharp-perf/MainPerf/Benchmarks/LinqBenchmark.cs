using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPerf.Benchmarks
{
	public class LinqBenchmark
	{
		[Benchmark]
		public void SumWithLinq()
		{
			var sum = Enumerable.Range(1, 1000000).Sum();
		}
		[Benchmark]
		public void Sum()
		{
			var numbers = Enumerable.Range(1, 1000000);
			var sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
			}
		}
	}
}
