module exam02

//
// map F L
//
// Maps function F to L - Returns list produced by mapping function F over L
// 
// Examples: map (fun x -> x + 1) []                  => []
//           map (fun x -> x + 1) [23]                => [24]
//           map (fun x -> x - 1) [23; 43]            => [22; 42]
//           map (fun x -> x - 1) [23; 43]            => [22; 42]
//           map (fun i -> (char i)) [99; 97; 115; 116] => ['c';'a';'s';'t']
//           map (fun c -> (char ((int c)+1))) ['a';'b';'c']  => ['b';'c';'d']
// 
// You may not call List.map directly in your solution.
// 

//Main Funcwith helper inside
let mapIF condition F L =
    let rec _mapIF condition F L newList =
        match L with
        | [] -> newList
        | firstItem::theRest -> if (condition firstItem) then
                                    let newerList = (F firstItem)::newList
                                    _mapIF condition F theRest newerList
                                else
                                    let newerList = firstItem::newList
                                    _mapIF condition F theRest newerList
    _mapIF condition F L []
    |> List.rev //Our list was created backwards so flip it!


//[<EntryPoint>]
let main argv =
    printfn "Testing Project 05: map"

    let map1 = mapIF (fun x -> x > 5) (fun x -> x+1) [6; 7]
    if map1 = [7; 8] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    
    printfn ""
    0 // return an integer exit code
    

