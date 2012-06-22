namespace TestTest

open Microsoft.VisualStudio.TestTools.UnitTesting
open FsUnit.MsTest
open Benchmark
open FSharpx.DataStructures

[<TestClass>]
type FSharpxDListTest() = 
    
    [<TestMethod>]
    member x.``FSharpxDList iterate`` () =
//        TestUtil.dsGetTimeTest Benchmark.getTimeDList InitData.ArrayIntAsc (TestObj.dListInt.GetType()) (TestObj.arrInt.GetType()) |> should be True
        Assert.AreEqual((TestUtil.dsGetTimeTest Benchmark.getTimeDList InitData.ArrayIntAsc (TestObj.dListInt.GetType()) (TestObj.arrInt.GetType())), true)

[<TestClass>]
type CoreListTest() = 
    
    [<TestMethod>]
    member x.``CoreList iterate`` () =
//        TestUtil.dsGetTimeTest Benchmark.getTimeCoreList InitData.ArrayIntAsc (TestObj.dListInt.GetType()) (TestObj.arrInt.GetType()) |> should be True
        Assert.AreEqual((TestUtil.dsGetTimeTest Benchmark.getTimeCoreList InitData.ArrayIntAsc (TestObj.dListInt.GetType()) (TestObj.arrInt.GetType())), true)

