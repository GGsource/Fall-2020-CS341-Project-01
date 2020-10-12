module Project01_11

//
// unzip L
//
// Unzip a list of pairs to a pair of lists
//
// Returns tuple of lists
// 
// Examples: 
//          unzip [] => ([], [])
//          unzip [(1, 3); (2, 56); (40, 6)] => ([1; 2; 40], [3; 56; 6])
//          unzip [(1, 'a'); (2, 'b'); (3, 'c')] => ([1; 2; 3], ['a'; 'b'; 'c'])
//
// You may not call List.unzip directly in your solution.
//
// 

let unzip L =
    let rec _unzip L listOne listTwo =
        match L with
        | [] -> (listOne|>List.rev, listTwo|>List.rev)
        | firstTuple::otherTuples -> let (left,right) = firstTuple
                                     let newLeft = (left::listOne)
                                     let newRight = (right::listTwo) 
                                     _unzip otherTuples newLeft newRight
    _unzip L [] []


//[<EntryPoint>]
let main argv =
    printfn "Testing Project 11: unzip"

    let u11,u12 = unzip []
    if (u11 = []) && (u12 = []) then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let u21,u22 = unzip [(1, 3); (2, 56); (40, 6)]
    if (u21 = [1; 2; 40]) && (u22 = [3; 56; 6]) then
        printfn "Passed!"
    else
        printfn "Failed!"

    let u31,u32 = unzip [(1, 'a'); (2, 'b'); (3, 'c')]
    if (u31 = [1; 2; 3]) && (u32 = ['a'; 'b'; 'c']) then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    printfn "%A, %A" u31 u32
    printfn ""
    0 // return an integer exit code
    

