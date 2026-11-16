module FsDSA.Utilities.ListHelpers

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

/// Returns all positional permutations of the list; repeated values are not de-duplicated.
let rec allPermutations (xs: int list) : int list list =
    match xs with
    | [] -> [ [] ]
    | _ ->
        xs
        |> List.mapi (fun i x ->
            let rest = List.removeAt i xs

            rest
            |> allPermutations 
            // Prepend the current element `x` to each list
            |> List.map (fun rest -> x :: rest))
        |> List.concat
