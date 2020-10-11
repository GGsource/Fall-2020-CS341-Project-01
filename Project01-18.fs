module Project01_18

let withinTolerance num target tolerance =
    (
     (num > (target-tolerance)) 
     && 
     (num < (target+tolerance))
    )

//
// distanceFromOrigin T
//
// Finds the distance of tuple T from the origin.
// 
// Examples: 
//          distanceFromOrigin (3,4) -> 5.0
//          distanceFromOrigin (0.0,0.0) -> 0.0
//          distanceFromOrigin (1.0,0.0) -> 1.0
//          distanceFromOrigin (0.0,-1.0) -> 1.0
//          distanceFromOrigin (-15.0,25.0) -> 29.15475947
//
//This function can work with both ints and floats due to being inlined
//https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/inline-functions
//

let inline distanceFromOrigin (x,y) =
    0.0     //   TO BE IMPLEMENTED

//[<EntryPoint>]
let main argv =
    printfn "Testing Project 18: distanceFromOrigin"

    let result1 = distanceFromOrigin (3,4)
    if result1 = 5.0 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result2 = distanceFromOrigin (0.0,0.0)
    if result2 = 0.0 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result3 =  distanceFromOrigin (1.0,0.0)
    if result3 = 1.0 then
        printfn "Passed!"
    else
        printfn "Failed!"

    let result4 =  distanceFromOrigin (0.0,-1.0)
    if result4 = 1.0 then
        printfn "Passed!"
    else
        printfn "Failed!"

    let result5 =  distanceFromOrigin (-15.0,25.0)
    if withinTolerance result5 29.15475947 0.0000001 then
        printfn "Passed!"
    else    
        printfn "Failed!"


    printfn ""
    0 // return an integer exit code
    