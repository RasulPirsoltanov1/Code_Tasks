```

BenchmarkDotNet v0.13.11, Windows 10 (10.0.19045.3693/22H2/2022Update)
Intel Core i7-10700 CPU 2.90GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
| Method            | Mean         | Error       | StdDev      |
|------------------ |-------------:|------------:|------------:|
| StringTest        | 694,627.3 μs | 6,578.33 μs | 6,153.38 μs |
| StringBuilderTest |     250.2 μs |     0.54 μs |     0.51 μs |
