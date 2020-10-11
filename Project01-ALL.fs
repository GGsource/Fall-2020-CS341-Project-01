#light

module Project01

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



//------------------------------------------------------------


// The first function to write, length (which you have already written in Homework 6), returns the length of the list passed in as a
// parameter and should be written in the Project01-01.fs file.
//
// length L
//
// Returns length of

//
// Examples: length []  => 0
//           length [1] => 1
//           length [1; 3; 98] => 3

//           length [1; 2; 19; 67] => 4
//           length ['a'; 'b'; 'c'; 'd'; 'e'] => 5
//           length ["List"; "of"; "strings"] => 3
//

let rec length L =
    0     //   TO BE IMPLEMENTED

//------------------------------------------------------------

// The function max returns the value of the maximum element (as determined by the > operator), and should be written in the
// Project01-02.fs file.

//
// max L
//
// Returns maximum element of L
//
// Examples: max []          => raises an
// exception (Unhandled Exception:
// System.ArgumentException: The input sequence was empty.)
//           max [-2; 4]     => 4
//           max [34]        => 34
//           max [10; 10; 9] => 10
//           max ['a'; 'e'; 'c'] => e
//

let max L =
    List.head L     //   TO BE IMPLEMENTED

//-------------------------------------------------------------

// The function min returns the value of the minimum element (as determined by the < operator), and should be written in the
// Project01-03.fs file.

//
// min L
//
// Returns minimum element of L
//
// Examples: min [] => raises an exception (Unhandled Exception:
// System.ArgumentException: The input sequence was empty.)
//           min [-2; 4]     => -2
//           min [34]        => 34
//           min [10; 9; 9; 101] => 9
//           min ['d', 'r', 'b'] => b
//

let min L =
    List.head L      //   TO BE IMPLEMENTED

//-------------------------------------------------------------

// The function nth returns the value of the element at index n of the list and should be written in the Project01-04.fs file.

//
// nth L n
//
// Returns nth element of L
//
// Examples: nth []   0       => raises an exception
//           nth [94] 2    => raises an exception
//           nth [94]  0      => 94
//           nth [94] -1     => raises an exception
//           nth [1; 45; 6] 1 => 45
//           nth [1; 45; 6] 5 => raises an exception
//           nth ['q'; 'w'; 'e'; 'r'; 't'; 'y'] 5 =>'y'
// You may not call List.nth, List.Item, .[], etc directly in // your solution.

let rec nth L n =
    List.head L      //   TO BE IMPLEMENTED

//-------------------------------------------------------------

// The function map returns a new list created from the elements of the list passed in (L), after they have been transformed
// by the application of function F.  This function does not modify the original list, creating a brand new list one element
// at a time.  The map function should be written in the Project01-05.fs file.

//
// map F L
//
// Maps function F to L - Returns list produced by mapping function F over L
//
// Examples: map (fun x-> x + 1) []                  => []
//           map (fun x-> x + 1) [23]                => [24]
//           map (fun x-> x    - 1) [23; 43]            => [22; 42]
//           map (fun x-> x    - 1) [23; 43]            => [22; 42]
//           map (fun i-> (char i)) [99; 97; 115; 116] => ['c';'a';'s';'t']
//           map (fun c-> (char ((int c)+1))) ['a';'b';'c']  => ['b';'c';'d']
//

let map F L =
    []     //   TO BE IMPLEMENTED


//-------------------------------------------------------------

// The function iter behaves like map, but instead of building a new list from the elements of L, applies F and then throws
// away the result.  This is generally used only for functions which have side-effects, such as printing functions which do
// not change memory, but have the side effect of outputting to the screen.  The iter function should be written in the
// Project01-06.fs file.

// iter F L
//  // Applies function F to the elements of L
//
// Examples: iter (fun x -> printfn "%A squared is %A" x ( x*x  ) ) [1; 2] => 1 squared is 1
//                                                                            2 squared is 4
//           iter (fun x -> printf "%c" x) ['t'; 'r'; 'u'; 'e']      => true
//           iter (fun x -> printfn "Iterating...") []              =>
//

let iter F L =
    ()      //   TO BE IMPLEMENTED

//-------------------------------------------------------------

// The function reduce takes a binary function, and pairwise applies the function to the elements of the list.
// The first application of the function takes the first and second elements as parameters, each following application uses
// the result of the previous application as the first parameter, and the next element of the list as the second parameter.
// The reduce function should be written in the Project01-07.fs file.

//
// reduce F
//
// reduces L to a single value by applying function F
//
// Examples: reduce (fun x y -> x+y) []             => Unhandled Exception: System.ArgumentException: The input list was empty.
//           reduce (fun x y -> x*y) [23; 4]        => 92//           reduce (fun x y -> x+y) [23; 43; -60]  => 6
//           reduce (fun x y -> if x > y then x else y)
//                  ['c'; 'a'; 'n'; 'a'; 'd'; 'a']  => 'n'
//

let reduce F L =
    List.head L      //   TO BE IMPLEMENTED

//-------------------------------------------------------------

// The function fold applies a function f to each element of the collection by threading an accumulator argument through the
// computation.  What this means is that the first parameter of the function initially has the valuepassed in to the accumulator,
// and then the result of each application of the function between the accumulator and an element of the list becomes the
// new accumulator for the next step.  These “updates” to the accumulator are accomplished via new values to the parameter
// for each function invocation.The fold function should be written in the Project01-08.fs file.

//
// fold F accumulator L
//
// Applies a function f to each element of the collection, threading an accumulator argument through the computation.
//
// Returns a value
//
// Examples:
//          fold (fun x y -> x&&y) true [] => true
//          fold (fun x y -> x+(string y)) "Hello " ['W';'o';'r';'l';'d'] => "Hello World"
//          fold (fun x y -> x+y) -60 [23; 43; 6] => 12
//          fold (fun x y -> x*y) 1 [23; 5; 80] => 9200
//

let rec fold F start L =
    start    //   TO BE IMPLEMENTED

//-------------------------------------------------------------

// The function flatten takes a list of lists, and puts the elements all together into a single list.
// The flatten function should be written in the Project01-09.fs file.

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
//flatten [['o'; 'n']; [' ']; ['w'; 'i'; 'n'; 'g'; 's']] =>
//                  ['o'; 'n'; ' '; 'w'; 'i'; 'n'; 'g'; 's']
//

let flatten L =
    []     //   TO BE IMPLEMENTED


//-------------------------------------------------------------

// The function zip combines the elements of two listspairwise, resulting in a list of tuples, where the first tuple in the list
// contains the first element of L1 as the first element, and the first element of L2 as the second element The zip
// function should be written in theProject01-10.fs file.

//
// zip L1 L2
//
// Zip two lists
//
// Returns list of tuples
//
// Examples:
//          zip [] [] => []
//          zip [1] [1] => [(1, 1)]
//          zip [1; 2; 40] [3; 56; 6] => [(1, 3); (2, 56); (40, 6)]
//          zip [1; 2; 3] ['a'; 'b'; 'c'] => [(1, 'a'); (2, 'b'); (3, 'c')]
//

let zip L1 L2 =
    []     //   TO BE IMPLEMENTED


//-------------------------------------------------------------

// The function unzip takes a list of pairs (tuples of size 2) and splits them apart into two lists.
// Since two lists are returned by this function, the return value is a tuple containing two lists.
// The unzip function should be written in the Project01-11.fs file.

//
// unzip L
//
// Unzip a list of pairs to a pair of lists
//
// Returns tuple of lists
//
// Examples:
//          unzip [] => ([], [])
//          unzip [(1, 3); (2, 56); (40, 6)] => ([1; 2; 40], [3; 56; 6])
//          unzip [(1, 'a'); (2, 'b'); (3, 'c')] => ([1; 2; 3], ['a'; 'b'; 'c'])
//

let unzip L =
    ([],[])     //   TO BE IMPLEMENTED


//-------------------------------------------------------------

// The function range creates a list of integers from 0 to the stop value.  The list should not include the stop value,
// but instead contain stopelements (0 to stop-1).  The range function with a single parametershould be written in
// the Project01-12.fs file.  Do not use List Comprehensions, build the list recursively.

//
// range stop
//
// Returns the range of integers starting from 0// and using the stop as the upper limit, non-inclusive
//
// Examples:
//          range 0 => []
//          range 1 => [0]
//          range 10 => [0; 1; 2; 3; 4; 5; 6; 7; 8; 9]
//

let rec range stop  =
    []     //   TO BE IMPLEMENTED


//-------------------------------------------------------------

// The function range2 creates a list of integers from startto stop.  The list should include start but not stop,
// having(stop-start) elements.Called with a 0 as the value of start, should behave the same as the single parameter version
// of range.The range2function with two parametersshould be written in the Project01-13.fs file. Do not use List
// Comprehensions, build the list recursively.

//
// range2 start stop
//
// Returns a list of integers over the range from start as the lower limit (inclusive) to stop as the upper limit (non-inclusive)
//
// Examples:
//          range2 0 0 => []
//          range2 0 1 => [0]
//          range2 1 5 => [1; 2; 3; 4]
//       range2 -2 3 => [-2; -1; 0; 1; 2]
//

let range2 start stop =
    []     //   TO BE IMPLEMENTED


//-------------------------------------------------------------

// The function range3 creates a list of integers from start to stop moving step values at a time.  The list should include
// start but not stop, having floor((stop-start)/step) elements.  Called with a 0 as the value of step, should behave the same
// as the two parameter version of range.  The range3 function with three parameters should be written in the Project01-14.fs
// file.  Do not use List Comprehensions, build the list recursively.

//
// range3 start stop step
//
// Returns the a list of integers over the range from start as the lower limit (inclusive) to stop as the upper limit (non-inclusive),
// incrementing by the amount specified in step
// // Examples:
//          range3 0 0 1 => []
//          range3 0 2 1 => [0; 1]
//          range3 1 5 2 => [1; 3]
//          range3 5 -2 -3 => [5; 2; -1]
//

let range3 start stop step =
    []    //TO BE IMPLEMENTED


//-------------------------------------------------------------

// The function slice returns a slice of the list using the limits provided and should be written in the Project01-15.fsfile.
// Instructions for the behavior of this function are included in the comments, and a copy of the file is included here.

//
// slice L start stop
//
// Returns a slice of the list with the specified starting and ending indices (start inclusive and end non-inclusive)
// This function creates a list containing the copied values from the input list between the starting and ending index
//
// Examples:
//          slice [1; 2; 3; 4; 5] 0 0 => []
//          slice [1; 2; 3; 4; 5] 0 1 => [1]
//          slice [1; 2; 3; 4; 5] 1 4 => [2; 3; 4]
//          slice [1; 2; 3; 4; 5] 0 5 => [1; 2; 3; 4; 5]
//          slice [1; 2; 3; 4; 5; 6; 7; 8; 9; 10] 6 2 => []
//

let slice L start stop =
    []     //   TO BE IMPLEMENTED


//-------------------------------------------------------------

// The function filter applies the predicate function F to
// the elements of list L and returns a list containing only the elements
// satisfying the predicate function.  
// The filter function should be written in the Project01-16.fs file.

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

let rec filter F L =
    []     //   TO BE IMPLEMENTED


//-------------------------------------------------------------

//
// pairUp L
//
// Produce a list of pairs from a list of values.
// 
// Examples: 
//          pairUp [1; 2; 3; 4] -> [(1,2);(3,4)]
//          pairUp [1; 2; 3] -> [(1,2)]
//          pairUp [1; 2; 3; 4; 5; 6] -> [(1,2);(3,4);(5,6)]
//          pairUp ["even"; "odd"; "EVEN"; "ODD"]-> [("even","odd");("EVEN","ODD")]
//          pairUp [("Cat", 10); ("Deer", 3)] -> [(("Cat", 10),("Deer", 3))] 
//          pairUp [3] -> []
//          pairUp [] -> []
//

let pairUp L =
    []     //   TO BE IMPLEMENTED


//-------------------------------------------------------------

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


//-------------------------------------------------------------


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
    []     //   TO BE IMPLEMENTED


//-------------------------------------------------------------


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


//-------------------------------------------------------------






////testing

//[<EntryPoint>]
let main argv =
    printfn "Testing Project 01: length"
    let len1 = length []
    if len1 = 0 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let len2 = length [1]
    if len2 = 1 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let len3 = length [1; 3; 98]
    if len3 = 3 then
        printfn "Passed!"
    else
        printfn "Failed!"

    let len4 = length ['a'; 'b'; 'c'; 'd'; 'e']
    if len4 = 5 then
        printfn "Passed!"
    else
        printfn "Failed!"

    let len5 = length ["List"; "of"; "strings"]
    if len5 = 3 then
        printfn "Passed!"
    else
        printfn "Failed!"

    printfn ""



    printfn "Testing Project 02: max"

    let max2 = max [-2; 4]
    if max2 = 4 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let max3 = max [34]
    if max3 = 34 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let max4 = max [10; 10; 9]
    if max4 = 10 then
        printfn "Passed!"
    else
        printfn "Failed!" 
        
    let max5 = max ['a'; 'e'; 'c']
    if max5 = 'e' then
        printfn "Passed!"
    else
        printfn "Failed!"
    
    printfn ""




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




    printfn "Testing Project 05: map"

    let map1 = map (fun x -> x + 1) []
    if map1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let map2 = map (fun x -> x + 1) [23]
    if map2 = [24] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let map3 = map (fun x -> x - 1) [23; 43]
    if map3 = [22; 42] then
        printfn "Passed!"
    else
        printfn "Failed!"     

    let input4 = [99; 97; 115; 116]
    let map4 = map (fun x -> (char x)) input4
    if map4 = ['c';'a';'s';'t'] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let input5 = ['a'; 'b'; 'c']
    let map5 = map (fun x -> (char ((int x)+1))) input5
    if map5 = ['b';'c';'d'] then
        printfn "Passed!"
    else
        printfn "Failed!"     
    
    printfn ""




    printfn "Testing Project 06: iter"

    ignore <| iter (fun x -> printf "%c" x) ['t'; 'r'; 'u'; 'e']
    printfn ""
    printfn "Pass if the above outputs true"
    printfn ""




    printfn "Testing Project 07: reduce"

    let red1 = reduce (fun x y -> x&&y) [false]
    if red1 = false then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let red2 = reduce (fun x y -> x*y) [23; 4]
    if red2 = 92 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let red3 = reduce (fun x y -> x+y) [23; 43; -60]
    if red3 = 6 then
        printfn "Passed!"
    else
        printfn "Failed!"

    let input4 = ['c'; 'a'; 'n'; 'a'; 'd'; 'a']
    let red4 = reduce (fun x y -> if x > y then x else y) input4
    if red4 = 'n' then
        printfn "Passed!"
    else
        printfn "Failed!"

    printfn ""




    printfn "Testing Project 08: fold"

    let f1 = fold (fun x y -> x&&y) true []
    if f1 = true then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let f2 = fold (fun x y -> x+(string y)) "Hello " ['W';'o';'r';'l';'d']
    if f2 = "Hello World" then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let f3 = fold (fun x y -> x+y) -60 [23; 43; 6]
    if f3 = 12 then
        printfn "Passed!"
    else
        printfn "Failed!"

    let f4 = fold (fun x y -> x*y) 1 [23; 5; 80]
    if f4 = 9200 then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    printfn ""





    printfn "Testing Project 09: flatten"

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




    printfn "Testing Project 10: zip"

    let z1 = zip [] []
    if z1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let z2 = zip [1] [1]
    if z2 = [(1,1)] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let z3 = zip [1; 2; 40] [3; 56; 6]
    if z3 = [(1, 3); (2, 56); (40, 6)] then
        printfn "Passed!"
    else
        printfn "Failed!"     

    let z4 = zip [1; 2; 3] ['a'; 'b'; 'c']
    if z4 = [(1, 'a'); (2, 'b'); (3, 'c')] then
        printfn "Passed!"
    else
        printfn "Failed!"     

    printfn ""




    printfn "Testing Project 11: unzip"

    let u11,u12 = unzip []
    if (u11 = []) && (u12 = []) then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let u21,u22 = unzip [(1, 3); (2, 56); (40, 6)]
    if (u21 = [1; 2; 40]) && (u22 = [3; 56; 6]) then
        printfn "Passed!"
    else
        printfn "Failed!"

    let u31,u32 = unzip [(1, 'a'); (2, 'b'); (3, 'c')]
    if (u31 = [1; 2; 3]) && (u32 = ['a'; 'b'; 'c']) then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    printfn ""




    printfn "Testing Project 12: range (1)"

    let d1 = range 0 
    if d1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let d2 = range 1 
    if d2 = [0] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let d3 = range 10
    if d3 = [0; 1; 2; 3; 4; 5; 6; 7; 8; 9] then
        printfn "Passed!"
    else
        printfn "Failed!"
       
    printfn ""




    printfn "Testing Project 13: range (2)"

    let d1 = range2 0 0
    if d1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let d2 = range2 0 1 
    if d2 = [0] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let d3 = range2 1 5
    if d3 = [1; 2; 3; 4] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let d4 = range2 -2 3
    if d4 = [-2; -1; 0; 1; 2] then
        printfn "Passed!"
    else
        printfn "Failed!"
                
    printfn ""




    printfn "Testing Project 14: range (3)"

    let d1 = range3 0 0 1
    if d1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let d2 = range3 0 2 1
    if d2 = [0; 1] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let d3 = range3 1 5 2
    if d3 = [1; 3] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let d4 = range3 5 -2 -3
    if d4 = [5; 2; -1] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    printfn ""




    printfn "Testing Project 15: slice"

    let t1 = slice [1; 2; 3; 4; 5] 0 0
    if t1 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let t2 = slice [1; 2; 3; 4; 5] 0 1
    if t2 = [1] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let t3 = slice [1; 2; 3; 4; 5] 1 4
    if t3 = [2; 3; 4] then
        printfn "Passed!"
    else
        printfn "Failed!"     
        
    let t4 = slice [1; 2; 3; 4; 5] 0 5
    if t4 = [1; 2; 3; 4; 5] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let t5 = slice [1; 2; 3; 4; 5; 6; 7; 8; 9; 10] 6 2
    if t5 = [] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    printfn ""




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




    printfn "Testing Project 17: pairUp"

    let result1 = pairUp [1; 2; 3; 4]
    if result1 = [(1,2);(3,4)] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result2 = pairUp [1; 2; 3]
    if result2 = [(1,2)] then
        printfn "Passed!"
    else
        printfn "Failed!"
        
    let result3 =  pairUp [1; 2; 3; 4; 5; 6]
    if result3 = [(1,2);(3,4);(5,6)] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let result4 =  pairUp ["even"; "odd"; "EVEN"; "ODD"]
    if result4 = [("even","odd");("EVEN","ODD")] then
        printfn "Passed!"
    else
        printfn "Failed!"

    let result4 =  pairUp [("Cat", 10); ("Deer", 3)]
    if result4 = [(("Cat", 10),("Deer", 3))]  then
        printfn "Passed!"
    else    
        printfn "Failed!"

    let result5 =  pairUp [3]
    if result5 = []  then
        printfn "Passed!"
    else    
        printfn "Failed!"

    let result6 =  pairUp []
    if result6 = []  then
        printfn "Passed!"
    else    
        printfn "Failed!"

    printfn ""
    
    
    
    
    
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









