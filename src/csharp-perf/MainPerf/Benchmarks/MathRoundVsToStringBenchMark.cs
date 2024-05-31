using BenchmarkDotNet.Attributes;

namespace MainPerf.Benchmarks
{
	/*
| Method        | Mean       | Error     | StdDev    |
|-------------- |-----------:|----------:|----------:|
| Round         |   2.149 ns | 0.0223 ns | 0.0209 ns |
| RoundToString | 108.237 ns | 0.4245 ns | 0.3971 ns |
| ToString      | 106.620 ns | 0.6630 ns | 0.6202 ns |
	 */
	//[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80,baseline:true)]
	public class MathRoundVsToStringBenchMark
	{
		private const double PI = 3.1415926535897932384626433832795; //double
		[Benchmark]
		public void Round()
		{
			Math.Round(PI, 2);
		}
		[Benchmark]
		public void RoundToString()
		{
			Math.Round(PI, 2).ToString();
		}
		[Benchmark]
		public new void ToString()
		{
			PI.ToString("F2");
		}

	}
}
