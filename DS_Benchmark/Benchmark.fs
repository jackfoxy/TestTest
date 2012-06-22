namespace TestTest

    open FSharpx.DataStructures  
    open System.Diagnostics

    type InitDataCol() =
        static member arrayIntAsc count = [|1..count|] 

    module Benchmark =

        let getTimeDList (inputArgs:BenchArgs) =
            FSharpxDList.getTime inputArgs (InitDataCol.arrayIntAsc inputArgs.Size)

        let getTimeCoreList (inputArgs:BenchArgs) =
            CoreList.getTime inputArgs (InitDataCol.arrayIntAsc inputArgs.Size)

        
