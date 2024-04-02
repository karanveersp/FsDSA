module FsDSA.Problems.SumTo

// Given a list of numbers and a number k,
// return whether any two numbers from the list add up to k.
//
// For example, given [10, 15, 3, 7] and k of 17,
// return true since 10 + 7 is 17.
//
// Bonus: Can you do this in one pass?


let hasSumTo (k: int) (xs: int list) : bool =
    let rec helper xs (traversed: int Set) =
        match xs with
        | [] -> false
        | head :: tail ->
            let complement = k - head
            if traversed.Contains complement then
                true
            else
                traversed.Add head
                |> helper tail

    helper xs Set.empty
