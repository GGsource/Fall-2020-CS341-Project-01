module Project01_12

//
// range stop
//
// Returns the range of integers starting from 0// and using the stop as the upper limit, non-inclusive
//
// Examples:
//          range 0 => []
//          range 1 => [0]
//          range 10 => [0; 1; 2; 3; 4; 5; 6; 7; 8; 9]
//

let rec range stop  =
    []     //   TO BE IMPLEMENTED


//[<EntryPoint>]
let main argv =
    printfn "Testing Project 12: range (1)"

    let d1 = range 0 
    if d1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let d2 = range 1 
    if d2 = [0] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let d3 = range 10
    if d3 = [0; 1; 2; 3; 4; 5; 6; 7; 8; 9] then
        printfn "Passed!"
    else
        printfn "Failed!"
       
    printfn ""
    0 // return an integer exit code
    
