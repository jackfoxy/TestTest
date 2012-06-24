namespace TestTest

    open FSharpx.DataStructures  
    open System.Diagnostics

    type InitDataCol() =
        static member arrayIntAsc count = [|1..count|] 

    module Benchmark =

        let getTimeDList (inputArgs:BenchArgs) =
            
            let dl = DList.ofSeq (InitDataCol.arrayIntAsc inputArgs.Size)

            let sw = new Stopwatch()
            sw.Start()
 
            let x = DList.fold (fun i b -> i + 1) 0 dl
            
            sw.Stop()

            {         Ticks = sw.ElapsedTicks;
               Milliseconds = sw.ElapsedMilliseconds;
                     Result = x;}

        let getTimeCoreList (inputArgs:BenchArgs) =
           
            let l = List.ofSeq(InitDataCol.arrayIntAsc inputArgs.Size)

            let sw = new Stopwatch()
            sw.Start()
 
            let x = List.fold (fun i b -> i + 1) 0 l
            
            sw.Stop()

            {         Ticks = sw.ElapsedTicks;
               Milliseconds = sw.ElapsedMilliseconds;
                     Result = x;}

        
