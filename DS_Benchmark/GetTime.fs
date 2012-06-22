namespace TestTest

    open FSharpx.DataStructures
    
    module FSharpxDList =
        
        let getTime (inputArgs:BenchArgs) (data:#('a seq)) =

            let dlFold = DList.fold (fun i b -> i + 1) 0
            
            let dl = DList.ofSeq data
            utility.getTime dlFold dl 

    module CoreList =
        
        let getTime (inputArgs:BenchArgs) (data:#('a seq)) =

            let lFold = List.fold (fun i b -> i + 1) 0
            
            let l = List.ofSeq data
            utility.getTime lFold l

             
  