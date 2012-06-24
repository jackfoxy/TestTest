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

            printfn "%i\t%i" result.Ticks result.Result

            printfn " "

            let result2 = Benchmark.getTimeCoreList {DataStructure = "";
                                         Size = 10;
                                     InitData = InitData.ArrayIntAsc;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            printfn "%i\t%i" result2.Ticks result.Result

            printfn "Ready."
            System.Console.ReadKey() |> ignore
            0