module FsDSA.Problems.Products

// Given an array of integers, return a new array such that each
// element at index i of the new array is the product of all the
// numbers in the original array except the one at i.
//
// For example, if our input was [1, 2, 3, 4, 5],
// the expected output would be [120, 60, 40, 30, 24].
// If our input was [3, 2, 1],
// the expected output would be [2, 3, 6].
//
// Follow-up: what if you can't use division?


let productsWithDivision (xs: int list) : int list =
    // Using division -
    let fullProduct = xs |> List.reduce (*)
    xs |> List.map (fun x -> fullProduct / x)


let productsQuadratic (xs: int list) : int list =
    // O(n^2) solution without division.
    // For each index, accumulate product by recursing through
    // full list.
    let n: int = xs.Length

    // recursive function that computes product till i = n,
    // and simply bypasses the case where i = excluding index
    // without multiplying the value at the index.
    let rec accumulateProduct excludingIndex i product =
        match i with
        | _ when i = n -> product // base case, return accumulated product
        | _ when i = excludingIndex -> accumulateProduct excludingIndex (i + 1) product // next index
        | _ -> accumulateProduct excludingIndex (i + 1) (product * xs[i])

    [ 0 .. n - 1 ] |> List.map (fun i -> accumulateProduct i 0 1) // excluding i, starting at 0, with product 1.


let products (xs: int list) : int list =
    // O(n) solution, using prefix and suffix products.
    // The idea is to compute two new lists (prefix and suffix)
    // that contain products of numbers till i and after i, respectively.
    // Once these lists are available, we iterate through the input
    // and simply multiple the prefix product with the suffix product.
    let n = xs.Length
    let indexes = [ 0 .. n - 1 ]

    let prefix: int list =
        let productsTill i =
            match i with
            | 0 -> xs[i] // at first value
            | _ -> xs |> List.take (i + 1) |> List.reduce (*)

        indexes |> List.map productsTill

    let suffix: int list =
        let productsAfter i =
            match i with
            | _ when i = n - 1 -> xs[n - 1] // at last value
            | _ -> xs |> List.skip i |> List.reduce (*) // skip 0 doesn't skip anything.

        indexes |> List.map productsAfter

    let productsExcluding i =
        match i with
        | 0 -> suffix[1]
        | _ when i = n - 1 -> prefix[i - 1] // second to last
        | _ -> prefix[i - 1] * suffix[i + 1] // at i, both prefix[i] and suffix[i] are inclusive of ith value.

    indexes |> List.map productsExcluding
