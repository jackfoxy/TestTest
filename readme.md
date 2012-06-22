ConsoleApplication1 -- executes a fold on DList in FSharpx Datastructures and a fold on List in Fhsarp Core. Notice that both work.

DS_Benchmark.Tests -- executes MsTest on the same two folds. Notice the test on DList fails and the test on List succeeds. MsTest on DList fails with the following error:

Test Name:	FSharpxDList iterate

Test FullName:	TestTest.FSharpxDListTest.FSharpxDList iterate

Test Source:	C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark.Tests\Tests.fs : line 14

Test Outcome:	Failed

Test Duration:	0:00:00.1114488

Result Message:

Test method TestTest.FSharpxDListTest.FSharpxDList iterate threw exception: 

System.MissingMethodException: Method not found:

'!!0 FSharpx.DataStructures.DList.fold(Microsoft.FSharp.Core.FSharpFunc`2<!!0,Microsoft.FSharp.Core.FSharpFunc`2<!!1,!!0>>, !!0, FSharpx.DataStructures.DList`1<!!1>)'.

Result StackTrace:
	
at TestTest.FSharpxDList.dlFold\@9-1.Invoke(DList`1 l)

   at TestTest.utility.getTime[a](FSharpFunc`2 f, a data) in C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark\Infrastructure.fs:line 33

   at TestTest.FSharpxDList.getTime[a,a](BenchArgs inputArgs, a data) in C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark\GetTime.fs:line 12

   at TestTest.Benchmark.getTimeDList(BenchArgs inputArgs) in C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark\Benchmark.fs:line 12

   at <StartupCode$DS_Benchmark-Tests>.$Tests.FSharpxDList iterate\@14.Invoke(BenchArgs inputArgs) in C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark.Tests\Tests.fs:line 14

   at TestTest.TestUtil.dsGetTimeTest\[a,b](FSharpFunc`2 f, String initData, a typeDs, b typeData) in C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark.Tests\TestUtil.fs:line 20

   at TestTest.FSharpxDListTest.FSharpxDList iterate() in C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark.Tests\Tests.fs:line 14



