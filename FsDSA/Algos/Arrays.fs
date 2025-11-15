module FsDSA.Algos.Arrays

open System

let print2DArray (matrix: int[,]) =
    let height = matrix.GetLength(0)
    let width = matrix.GetLength(1)

    for i in 0 .. height - 1 do
        for j in 0 .. width - 1 do
            printf "%d " matrix.[i, j]

        printfn ""

/// Given an integer array nums, returns true if there exists a triple of indices (i, j, k)
/// such that i < j < k and nums[i] < nums[j] < nums[k]. If no such indices exist, returns false.
let increasingTripletExists (nums: int list) : bool =
    let rec check xs smallest mid =
        match xs with
        | [] -> false
        | num :: tail ->
            if num <= smallest then check tail num mid // update smallest value to num
            elif num <= mid then check tail smallest num // update mid value to num
            else true // found a value that is greater than both smallest and mid in sequence

    check nums Int32.MaxValue Int32.MaxValue
