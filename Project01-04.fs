module Project01_04

//
// nth L n
//
// Returns nth element of L
// 
// Examples: nth []   0       => raises an exception
//           nth [94] 2      => raises an exception
//           nth [94]  0      => 94
//           nth [94]  -1      => raises an exception 
//           nth [1; 45; 6] 1 => 45
//           nth [1; 45; 6] 5 => raises an exception
//           nth ['q'; 'w'; 'e'; 'r'; 't'; 'y'] 5 => 'y'
// You may not call List.nth, List.Item, .[], etc directly in your solution.
// 
//Helper Func
let rec _nth L n =
    match L with
    | [] -> raise(System.ArgumentException("Index cannot be greater than list size.")) //List is now empty meaning index was greater than size.
    | _ when n < 0 -> raise(System.ArgumentException("Index cannot be negative.")) //Given index negative, error.
    | head::theRest when n = 0 -> head //n has reached 0 so head is our item!
    | _::theRest -> _nth theRest (n-1)
//Main Func
let nth L n =
    match L with
    | [] -> raise (System.ArgumentException("List cannot be empty."))
    | _ -> _nth L n

//[<EntryPoint>]
let main argv =
    printfn "Testing Project 04: nth"

    let nth2 = nth [94] 0
    if nth2 = 94 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let nth3 = nth [1; 45; 6] 1
    if nth3 = 45 then
        printfn "Passed!"
    else
        printfn "Failed!"

    let nth7 = nth ['q'; 'w'; 'e'; 'r'; 't'; 'y'] 5
    if nth7 = 'y' then
        printfn "Passed!"
    else
        printfn "Failed!"
      
    printfn ""
    0 // return an integer exit code
    

