namespace TestTest

    open System.Diagnostics
    open FSharpx.DataStructures

    type BenchArgs =
        { DataStructure : string;
                   Size : int;
               InitData : string;
                 Action : string;
              AddlParms : string[];}

    type GetTimeReturn =
        {             Ticks : int64;
               Milliseconds : int64;
                     Result : int}

    type InitData =
        static member ArrayIntAsc = "arrayintasc"

    type Operator = 
        static member Fold = "fold"