module Project01_09

//
// flatten L
//
// Flatten a list of lists to a single list
//
// Returns list 
// 
// Examples: 
//          flatten [[]] => []
//          flatten [[1]] => [1]
//          flatten [[1; 2]; [2; 3; 4]] => [1; 2; 2; 3; 4]
//			flatten [['o'; 'n']; [' ']; ['w'; 'i'; 'n'; 'g'; 's']] => ['o'; 'n'; ' '; 'w'; 'i'; 'n'; 'g'; 's']
// 
// You may not call List.concat or similar functions directly in your solution.
// 
// 

//Helper for items
// let rec _itemflatten L combinedList =
//     match L with
//     | [] -> combinedList
//     |first::theRest -> _itemflatten theRest (first::combinedList)
//Helper for lists
let rec _listFlatten L combinedList =
        match L with
        //Failed attempt here. Took several hours to find out the right answer was so simple...
        // | [] -> combinedList
        // | (firstItem::[])::otherLists -> _listFlatten otherLists (firstItem::combinedList)
        // | (firstItem::firstList)::otherLists -> _listFlatten (firstList::otherLists) (firstItem::combinedList)
        | [] -> combinedList
        | firstList::otherLists -> _listFlatten otherLists (combinedList@firstList)

//Main Func
let flatten L =
    _listFlatten L []

//[<EntryPoint>]
let main argv =
    printfn "Testing Project 09: flatten"

    let myFlatten = flatten [ [1;2]; [3;4]; [5;6] ]
    printfn "%A" myFlatten

    let f1 = flatten [[]]
    if f1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let f2 = flatten [[1]]
    if f2 = [1] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let f3 = flatten [[1; 2]; [2; 3; 4]]
    if f3 = [1; 2; 2; 3; 4] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let f3 = flatten [['o'; 'n']; [' ']; ['w'; 'i'; 'n'; 'g'; 's']]
    if f3 = ['o'; 'n'; ' '; 'w'; 'i'; 'n'; 'g'; 's'] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    printfn ""
    0 // return an integer exit code
    

