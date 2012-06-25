namespace TestTest

    open Benchmark

    module console =
        [<EntryPoint>]
        let main argv = 
            printfn "%A" argv

            let result = Benchmark.getTimeDList {DataStructure = "";
                                         Size = 10;
                                     InitData = InitData.ArrayIntAsc;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            printfn "DList: %i\t%i" result.Ticks result.Result

            printfn " "

            let result2 = Benchmark.getTimeCoreList {DataStructure = "";
                                         Size = 10;
                                     InitData = InitData.ArrayIntAsc;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            printfn "CoreList %i\t%i" result2.Ticks result.Result

            printfn " "

            let result2 = Benchmark.getTimeLazyList {DataStructure = "";
                                         Size = 10;
                                     InitData = InitData.ArrayIntAsc;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            printfn "LazyList: %i\t%i" result2.Ticks result.Result

            printfn " "

            let result2 = Benchmark.getTimeLazyListIterate {DataStructure = "";
                                         Size = 10;
                                     InitData = InitData.ArrayIntAsc;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            printfn "LazyList iterate: %i\t%i" result2.Ticks result.Result

            printfn " "
            printfn "Ready."
            System.Console.ReadKey() |> ignore
            0