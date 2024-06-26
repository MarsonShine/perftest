// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using MainPerf.Benchmarks;

// Math.Round VS ToString("F2")
//BenchmarkRunner.Run<MathRoundVsToStringBenchMark>();

BenchmarkRunner.Run<LinqBenchmark>();
