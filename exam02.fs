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

//Main Funcwith helper inside
let mapIF2 condition F L =
    let rec _mapIF2 condition F L =
        match L with
        | [] -> []
        | firstItem::theRest -> if (condition firstItem) then
                                    let newerList = (F firstItem)
                                    newerList::(_mapIF2 condition F theRest)
                                else
                                    firstItem::(_mapIF2 condition F theRest)
    _mapIF2 condition F L
    |> List.rev //Our list was created backwards so flip it!

let tupleSplit (x,_) =
    x


//[<EntryPoint>]
let main argv =
    printfn "Testing Project 05: map"

    let map1 = mapIF (fun x -> x > 5) (fun x -> x+1) [6; 7]
    if map1 = [7; 8] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let map2 = mapIF (fun x -> x>5) (fun x -> x+1) [6;7;8;1]
    if map2 = [7;8;9;1] then
        printfn "Passed non recursive!"
    else
        printfn "Failed non recursive!"

    let L = [1;2;3]
    //let third = List.tail List.tail List.head [1;2;3]
    let third =
        L
        |> List.tail
        |> List.tail
        |> List.head

    printfn "%A" third

    let first::rest1 = L
    let second::rest2 = rest1
    let third2::rest3 = rest2
    printfn "%A" third2

    let L2 = List.tail L
    let L3 = List.tail L2
    let third3 = List.head L3
    printfn "%A" third3

    let third4 =
        (List.tail (List.tail (List.tail L)))
    printfn "%A" third4

    let first::second::third5::_ = L
    printfn "%A" third5

    let x = tupleSplit ("animal", 5)
    printfn "%A" x 

    printfn ""
    0 // return an integer exit code
    

