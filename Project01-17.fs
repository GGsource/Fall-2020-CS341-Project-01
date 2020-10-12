module Project01_17

//
// pairUp L
//
// Produce a list of pairs from a list of values.
// 
// Examples: 
//          pairUp [1; 2; 3; 4] -> [(1,2);(3,4)]
//          pairUp [1; 2; 3] -> [(1,2)]
//          pairUp [1; 2; 3; 4; 5; 6] -> [(1,2);(3,4);(5,6)]
//          pairUp ["even"; "odd"; "EVEN"; "ODD"]-> [("even","odd");("EVEN","ODD")]
//          pairUp [("Cat", 10); ("Deer", 3)] -> [(("Cat", 10),("Deer", 3))] 
//          pairUp [3] -> []
//          pairUp [] -> []
//

let pairUp L =
    let rec _pairUp L pairList =
        match L with
        | [] -> (pairList|>List.rev)
        | itemOne::[] -> (pairList|>List.rev)
        | itemOne::itemTwo::theRest -> let newTuple = (itemOne, itemTwo)
                                       _pairUp theRest (newTuple::pairList)
    _pairUp L []

//[<EntryPoint>]
let main argv =
    printfn "Testing Project 17: pairUp"

    let result1 = pairUp [1; 2; 3; 4]
    if result1 = [(1,2);(3,4)] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result2 = pairUp [1; 2; 3]
    if result2 = [(1,2)] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result3 =  pairUp [1; 2; 3; 4; 5; 6]
    if result3 = [(1,2);(3,4);(5,6)] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let result4 =  pairUp ["even"; "odd"; "EVEN"; "ODD"]
    if result4 = [("even","odd");("EVEN","ODD")] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let result4 =  pairUp [("Cat", 10); ("Deer", 3)]
    if result4 = [(("Cat", 10),("Deer", 3))]  then
        printfn "Passed!"
    else    
        printfn "Failed!"

    let result5 =  pairUp [3]
    if result5 = []  then
        printfn "Passed!"
    else    
        printfn "Failed!"

    let result6 =  pairUp []
    if result6 = []  then
        printfn "Passed!"
    else    
        printfn "Failed!"

    printfn ""
    0 // return an integer exit code
    