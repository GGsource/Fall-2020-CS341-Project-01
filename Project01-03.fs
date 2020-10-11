module Project01_03

//
// min L
//
// Returns minimum element of L
// 
// Examples: min []          => raises an exception (Unhandled Exception: System.ArgumentException: The input sequence was empty.)
//           min [-2; 4]     => -2
//           min [34]        => 34
//           min [10; 9; 9; 101] => 9 
//           min ['d', 'r', 'b'] => b
//
// You may not call List.min directly in your solution.
// 

//Helper Function!
let rec _min L minSoFar =
    match L with
    | [] -> minSoFar
    | currentItem::theRest when currentItem < minSoFar -> _min theRest currentItem
    | _::theRest -> _min theRest minSoFar
//Helper Function
let min L =
    match L with
    | [] -> raise (System.ArgumentException("List cannot be empty."))
    | head::restOfList -> _min restOfList head

//[<EntryPoint>]
let main argv =
    printfn "Testing Project 03: min"

    let min2 = min [-2; 4]
    if min2 = -2 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let min3 = min [34]
    if min3 = 34 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let min4 = min [10; 9; 9; 101]
    if min4 = 9 then
        printfn "Passed!"
    else
        printfn "Failed!"  

    let min5 = min ['d'; 'r'; 'b'] 
    if min5 = 'b' then
        printfn "Passed!"
    else
        printfn "Failed!" 
    
    printfn ""
    0 // return an integer exit code
    


