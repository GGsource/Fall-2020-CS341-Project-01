module Project01_16

//
// filter F L
//
// Applies the function F to the elements of list L and returns a list containing only the elements from L satisfying the condition
//
// Examples:
//          filter (fun param -> false) [1; 2; 3] -> []
//          filter (fun param -> true) [1; 2; 3] -> [1; 2; 3]
//          filter (fun x -> x % 2 = 0) [1; 2; 3; 4; 5; 6] -> [2; 4; 6]
//          filter (fun x -> x % 5 = 0) [1; 5; 3; 15; 25] -> [5; 15; 25]
//          filter (fun (s,x) -> s.Length <= 4) [("Cat", 10); ("Deer", 3); ("Giraffe", 13)] 
//                                              -> [("Cat", 10); ("Deer", 3)]
//
// You may not use List.filter directly in your solution.
//

let filter F L =
    let rec _filter F L trueList =
        match L with
        | [] -> (trueList|>List.rev)
        | frontItem::theRest when (F frontItem) = true -> _filter F theRest (frontItem::trueList)
        | frontItem::theRest -> _filter F theRest trueList
    _filter F L []


//[<EntryPoint>]
let main argv =
    printfn "Testing Project 16: filter"

    let fil1 = filter (fun x -> false) [1;2;3]
    if fil1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let fil2 = filter (fun x -> true) [1;2;3]
    if fil2 = [1;2;3] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let fil3 =  filter (fun x -> x % 2 = 0) [1; 2; 3; 4; 5; 6]
    if fil3 = [2;4;6] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let fil4 =  filter (fun x -> x % 5 = 0) [1; 5; 3; 15; 25]
    if fil4 = [5;15;25] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let data = [("cat",10); ("deer",3); ("giraffe",13)]
    let fil4 =  filter (fun ((s:string),x) -> s.Length <= 4) data
    if fil4 = [("cat", 10);("deer", 3)] then
        printfn "Passed!"
    else    
        printfn "Failed!"

    printfn ""
    0 // return an integer exit code
    
