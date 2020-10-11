module Project01_20

open System

let withinTolerance num target tolerance =
    (
     (num > (target-tolerance)) 
     && 
     (num < (target+tolerance))
    )

let matchTuples a b =
    match a,b with
    | ((x1,y1),(x2,y2)),((ansX1,ansY1),(ansX2,ansY2)) -> 
        ((x1=ansX1) && (x2=ansX2) && (y1=ansY1) && (y2=ansY2))
         ||
        ((x1=ansX2) && (x2=ansX1) && (y1=ansY2) && (y2=ansY1))

//
// furthestPoints L
//
// Returns the pair of points with the greatest distance
// 
// Examples: 
//          furthestPoints [(1.0,0.0);(-5.0,0.0)] -> ((1.0,0.0),(-5.0,0.0))
//          furthestPoints [(1.0,0.0);(-5.0,0.0);(3.0,2.5)] -> 
//                         ((-5.0,0.0),(3.0,2.5))
//          furthestPoints [(2.0,0.0);(1.0,1.0);(-0.3,0.5);(0.2,-1.6)] -> 
//                         ((1.0,1.0),(0.2,-1.6))
//          furthestPoints [(2.0,1.5);(3.0,-1.0);(4.0,0.5);(3.0,1.0)] -> 
//                         ((2.0,1.5),(3.0,-1.0))
//

let furthestPoints L =
    match L with
    | [] -> raise (new ArgumentException("furthestPoints requires at least two points"))
    | _::[] -> raise (new ArgumentException("furthestPoints requires at least two points"))
    | _ -> ((0.0,0.0),(0.0,0.0))     //   TO BE IMPLEMENTED

//[<EntryPoint>]
let main argv =
    printfn "Testing Project 20: furthestPoints"
    
    let result1 = furthestPoints [(1.0,0.0);(-5.0,0.0)]
    if matchTuples result1 ((1.0,0.0),(-5.0,0.0)) then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result2 = furthestPoints [(1.0,0.0);(-5.0,0.0);(3.0,2.5)]
    if matchTuples result2 ((-5.0,0.0),(3.0,2.5)) then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result3 = furthestPoints [(2.0,0.0);(1.0,1.0);(-0.3,0.5);(0.2,-1.6)]
    if matchTuples result3 ((1.0,1.0),(0.2,-1.6)) then
        printfn "Passed!"
    else
        printfn "Failed!"

    let result4 = furthestPoints [(2.0,1.5);(3.0,-1.0);(4.0,0.5);(3.0,1.0)]
    if matchTuples result4 ((2.0,1.5),(3.0,-1.0)) then
        printfn "Passed!"
    else
        printfn "Failed!"

    printfn ""
    0 // return an integer exit code
