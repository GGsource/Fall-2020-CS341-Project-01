module Project01_14

//
// range3 start stop step
//
// Returns the a list of integers over the range from start as the lower limit (inclusive) to stop as the upper limit (non-inclusive),
// incrementing by the amount specified in step
// // Examples:
//          range3 0 0 1 => []
//          range3 0 2 1 => [0; 1]
//          range3 1 5 2 => [1; 3]
//          range3 5 -2 -3 => [5; 2; -1]
//

let range3 start stop step =
    []    //TO BE IMPLEMENTED
    

//[<EntryPoint>]
let main argv =
    printfn "Testing Project 14: range (3)"

    let d1 = range3 0 0 1
    if d1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let d2 = range3 0 2 1
    if d2 = [0; 1] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let d3 = range3 1 5 2
    if d3 = [1; 3] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let d4 = range3 5 -2 -3
    if d4 = [5; 2; -1] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    printfn ""
    0 // return an integer exit code

    //printfn "A"
    //let d5 = range3 -100 100 1
    //if d5 = [-100..99] then
    //    printfn "Passed!"
    //else
    //    printfn "Failed!"
    

