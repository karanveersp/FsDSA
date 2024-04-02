module FsDSA.Algos.Lists

let sum (list: int list) =
    /// A tail-recursive list sum function.
    /// The function reuses the current stack frame for each recursive call,
    /// avoiding the creation of new stack frames. This design ensures
    /// that even for large lists, the function won't cause a stack overflow.
    /// The recursive call has to be the last operation in a recursive function
    /// to take advantage of tail recursion.
    let rec loop list acc =
        match list with
        | [] -> acc
        | head :: tail -> loop tail (acc + head)

    loop list 0
    // or just
    // List.fold (fun acc item -> acc + item) 0 list

let print2DList (matrix: int list list) =
    for row in matrix do
        for value in row do
            printf "%d " value

        printfn ""

[<TailCall>]
let rec allPermutations (xs: int list) : int list list =
    match xs with
    | [] -> [ [] ]
    | _ ->
        let mutable permutations: int list list = [ [] ]

        for i in 0 .. xs.Length do
            let rest = xs[.. i - 1] @ xs[i + 1 ..]

            for p in allPermutations rest do
                permutations <- List.append permutations [ [ xs[i] ] @ p ]

        permutations
