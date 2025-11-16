module FsDSA.Problems.Arrays.IncreasingTriplet

open System

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
