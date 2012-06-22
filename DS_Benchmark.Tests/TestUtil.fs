namespace TestTest

    open FSharpx.DataStructures

    type TestObj =
        static member arrInt = Array.create 2 0

        static member listInt = List.ofArray TestObj.arrInt

        static member seqInt = {0..1}

        static member setInt = Set TestObj.seqInt

        static member dListInt = DList.ofSeq TestObj.seqInt


    module TestUtil =
    
        let dsGetTimeTest f initData typeDs typeData = 
            let result = f {DataStructure = "";
                                         Size = 10;
                                     InitData = initData;
                                       Action = "";
                                    AddlParms = Array.create 5 "";}

            ((result.Ticks > 0L) && (result.Result > 0))


