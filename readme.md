##Problem description
VS 2012 RC
ConsoleApplication1 -- executes a fold on DList in FSharpx Datastructures and a fold on List in Fhsarp Core. Notice that both work.

DS_Benchmark.Tests -- executes MsTest on the same two folds. Notice the test on DList fails and the test on List succeeds. MsTest on DList fails with the following error:

Similar problem with PowerPack LazyList.ofList and LazyList when iterating through a rec loop. Demonstration examples added.

##Unit tests call function with Invoke

<del>decompiled (with dotPeek 1.0 Beta) unit test:

the difference is the unit test calls the function using Microsoft.FSharp.Core.FSharpFunc.Invoke

GetTimeReturn getTimeReturn = f.Invoke(new BenchArgs("", 10, initData, "", ArrayModule.Create<string>(5, "")));

      if (getTimeReturn.Ticks > 0L)
	  
        return getTimeReturn.Result > 0;
		
      else
	  
        return false;
		
decompiled console .exe:

GetTimeReturn timeDlist = Benchmark.getTimeDList(new BenchArgs("", 10, InitData.ArrayIntAsc, "", ArrayModule.Create<string>(5, "")));</del>

Did a further simplification to get the code in the unit test to match the code in the console app, eliminating the Invoke, but the problem remained. The issue must involve either Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute or TestClassAttribute.

##Error output

Test Name:	FSharpxDList iterate

Test FullName:	TestTest.FSharpxDListTest.FSharpxDList iterate

Test Source:	C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark.Tests\Tests.fs : line 23

Test Outcome:	Failed

Test Duration:	0:00:00.1114488

Result Message:

Test method TestTest.FSharpxDListTest.FSharpxDList iterate threw exception: 

System.MissingMethodException: Method not found: 

'!!0 FSharpx.DataStructures.DList.fold(Microsoft.FSharp.Core.FSharpFunc`2<!!0,Microsoft.FSharp.Core.FSharpFunc`2<!!1,!!0>>, !!0, FSharpx.DataStructures.DList`1<!!1>)'.

Result StackTrace:	

at TestTest.Benchmark.getTimeDList(BenchArgs inputArgs)

   at <StartupCode$DS_Benchmark-Tests>.$Tests.FSharpxDList iterate\@23.Invoke(BenchArgs inputArgs) in C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark.Tests\Tests.fs:line 23
   
   at TestTest.FSharpxDListTest.dsGetTimeTest(FSharpFunc`2 f, String initData) in C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark.Tests\Tests.fs:line 12
   
   at TestTest.FSharpxDListTest.FSharpxDList iterate() in C:\Users\Jack\Documents\GitHub\TestTestSolution\TestTest\DS_Benchmark.Tests\Tests.fs:line 23