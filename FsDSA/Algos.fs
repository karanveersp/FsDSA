namespace FsDSA

module Algos =
    open System

    /// A tail-recursive list sum function.
    /// The function reuses the current stack frame for each recursive call,
    /// avoiding the creation of new stack frames. This design ensures
    /// that even for large lists, the function won't cause a stack overflow.
    /// The recursive call has to be the last operation in a recursive function
    /// to take advantage of tail recursion.
    let sumList list =
        let rec loop list acc =
            match list with
            | head :: tail -> loop tail (acc + head)
            | [] -> acc

        loop list 0


    let print2DArray (matrix: int [,]) =
        let height = matrix.GetLength(0)
        let width = matrix.GetLength(1)

        for i in 0 .. height - 1 do
            for j in 0 .. width - 1 do
                printf "%d " matrix.[i, j]

            printfn ""

    let print2DList (matrix: int list list) =
        for row in matrix do
            for value in row do
                printf "%d " value

            printfn ""

    let isPalindrome (s: string) : bool =
        let cleaned =
            s.ToCharArray()
            |> Array.filter Char.IsLetterOrDigit
            |> Array.map Char.ToLower
            |> String.Concat

        let reversed = cleaned.ToCharArray() |> Array.rev |> String
        cleaned = reversed

    let rec allPermutations (xs: int list) : int list list =
        match xs with
        | [] -> [ [] ]
        | _ ->
            let mutable permutations: int list list = [ [] ]

            for i in 0 .. xs.Length do
                let rest = xs[.. i - 1] @ xs[i + 1 ..]

                for p in allPermutations (rest) do
                    permutations <- List.append permutations [ [ xs.[i] ] @ p ]

            permutations
