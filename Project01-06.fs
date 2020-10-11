module Project01_06

//
// iter F L
//
// Applies function F to the elements of L
// 
// Examples: iter (fun x -> printfn "%A squared is %A" x (x*x) ) [1; 2] => 1 squared is 1
//                                                                         2 squared is 4
//           iter (fun x -> printf "%c" x) ['t'; 'r'; 'u'; 'e']     => true
//           iter (fun x -> printfn "Iterating...") []              => 
// 
// You may not call List.iter directly in your solution.
// 

let iter F L =
    ()      //   TO BE IMPLEMENTED


//[<EntryPoint>]
let main argv =
    printfn "Testing Project 06: iter"

    iter (fun x -> printf "%c" x) ['t'; 'r'; 'u'; 'e']
    printfn ""
    printfn "Pass if the above outputs true"
    printfn ""
    0 // return an integer exit code
    

