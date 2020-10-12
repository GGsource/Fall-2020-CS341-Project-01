module Project01_19


let withinTolerance num target tolerance =
    (
     (num > (target-tolerance)) 
     && 
     (num < (target+tolerance))
    )

//Copied from Project01-18.fs
let inline distanceFromOrigin (x,y) =
    match (x,y) with
    | (_,_) ->  let xSquared = abs (x * x)
                let ySquared = abs (y * y)
                let sqrSum = xSquared + ySquared
                sqrt (float sqrSum) 

//
// lengthsFromOrigin L
//
// Transforms a list of tuples into a list of distances from origin.
// 
// Examples: 
//          lengthsFromOrigin [] -> []
//          lengthsFromOrigin [(0.0,0.0)] -> [0.0]
//          lengthsFromOrigin [(1.0,0.0);(4.0,3.0)] -> [1.0;5.0]
//          lengthsFromOrigin [(0.0,-1.0);(-12.3,-18.13);(-15.0,25.0)] ->  
//                            [0.0;21.90860333;29.15475947]
//

let lengthsFromOrigin L =
    let rec _lengthsFromOrigin L lenList =
        match L with
        | [] -> (lenList|>List.rev)
        | frontTuple::otherTups ->  let newLen = distanceFromOrigin frontTuple
                                    let newLenList = (newLen::lenList)
                                    _lengthsFromOrigin otherTups newLenList
    _lengthsFromOrigin L []

//[<EntryPoint>]
let main argv =
    printfn "Testing Project 19: distanceFromOrigin"

    let result1 = lengthsFromOrigin []
    if result1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result2 = lengthsFromOrigin [(0.0,0.0)]
    if result2 = [0.0] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result3 =  lengthsFromOrigin [(1.0,0.0);(4.0,3.0)]
    if result3 = [1.0;5.0] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let result4 =  lengthsFromOrigin [(0.0,-1.0);(-12.3,-18.13);(-15.0,25.0)]
    let v1::v2::v3::[] = result4
    let test4 = (v1 = 1.0) 
                && (withinTolerance v2 21.90860333 0.0000001)
                && (withinTolerance v3 29.15475947 0.0000001)
    if test4 then
        printfn "Passed!"
    else
        printfn "Failed!"


    printfn ""
    0 // return an integer exit code