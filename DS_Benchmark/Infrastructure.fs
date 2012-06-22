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
                     Result : int;
          DataStructureType : System.Type;
                   DataType : System.Type;}

    type InitData =
        static member ArrayIntAsc = "arrayintasc"

    type Operator = 
        static member Fold = "fold"

    module utility =
        
        let getTime f data =

            let sw = new Stopwatch()
            sw.Start()
 
            let x = f data
            
            sw.Stop()

            {         Ticks = sw.ElapsedTicks;
               Milliseconds = sw.ElapsedMilliseconds;
                     Result = x;
          DataStructureType = x.GetType();
                   DataType = data.GetType();}