namespace TestTest

open Microsoft.VisualStudio.TestTools.UnitTesting
open FsUnit.MsTest
open Benchmark
open FSharpx.DataStructures

[<TestClass>]
type FSharpxDListTest() = 
    
    let dsGetTimeTest f initData = 
            let result = f {DataStructure = "";
                                         Size = 10;
                                     InitData = initData;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            ((result.Ticks > 0L) && (result.Result > 0))

    [<TestMethod>]
    member x.``FSharpxDList iterate`` () =
//        dsGetTimeTest Benchmark.getTimeDList InitData.ArrayIntAsc |> should be True
//        Assert.AreEqual((dsGetTimeTest Benchmark.getTimeDList InitData.ArrayIntAsc), true)

//            let b = dsGetTimeTest Benchmark.getTimeDList InitData.ArrayIntAsc

            let result = Benchmark.getTimeDList {DataStructure = "";
                                         Size = 10;
                                     InitData = InitData.ArrayIntAsc;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            let b = ((result.Ticks > 0L) && (result.Result > 0))

            Assert.AreEqual(b, true)

[<TestClass>]
type CoreListTest() = 
    
    let dsGetTimeTest f initData = 
            let result = f {DataStructure = "";
                                         Size = 10;
                                     InitData = initData;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            ((result.Ticks > 0L) && (result.Result > 0))

    [<TestMethod>]
    member x.``CoreList iterate`` () =
//        dsGetTimeTest Benchmark.getTimeCoreList InitData.ArrayIntAsc |> should be True
        Assert.AreEqual((dsGetTimeTest Benchmark.getTimeCoreList InitData.ArrayIntAsc), true)

[<TestClass>]
type LazyListListTest() = 
    
    let dsGetTimeTest f initData = 
            let result = f {DataStructure = "";
                                         Size = 10;
                                     InitData = initData;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            ((result.Ticks > 0L) && (result.Result > 0))

    [<TestMethod>]
    member x.``LazyList init`` () =
//        dsGetTimeTest Benchmark.getTimeLazyList InitData.ArrayIntAsc |> should be True
        Assert.AreEqual((dsGetTimeTest Benchmark.getTimeLazyList InitData.ArrayIntAsc), true)

    [<TestMethod>]
    member x.``LazyList iterate`` () =
//        dsGetTimeTest Benchmark.getTimeLazyListIterate InitData.ArrayIntAsc |> should be True
        Assert.AreEqual((dsGetTimeTest Benchmark.getTimeLazyListIterate InitData.ArrayIntAsc), true)

