module FsDSA.Problems.Arrays.ProductExceptSelf

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


let productExceptSelf (xs: int list) : int list =
    // O(n) solution, using prefix and suffix products.
    // The idea is to compute two new lists (prefix and suffix)
    // that contain products of numbers till i and after i, respectively.
    // Once these lists are available, we iterate through the input
    // and simply multiply the prefix product with the suffix product.
    let n = xs.Length
    let indexes = [ 0 .. n - 1 ]

    let productTill xs i = xs |> List.take i |> List.fold (*) 1

    let prefix: int list = indexes |> List.map (productTill xs)

    // suffix is same as prefix, but we're accumulating product from right -> left (reversed xs)
    // and have to reverse the result.
    // Ex. [1,2,3,4] -> [4,3,2,1] (List.rev xs)
    // Then accumulate productTill going from 0..n-1 to get [1,4,12,24]
    // Finally we reverse this to get [24,12,4,1] which is the accurate suffix product at each index of original xs.
    let suffix: int list = indexes |> List.map (productTill (List.rev xs)) |> List.rev

    let productsExcluding i =
        match i with
        | 0 -> suffix[0]
        | _ when i = n - 1 -> prefix[i] // last
        | _ -> prefix[i] * suffix[i] // at i, both prefix[i] and suffix[i] are inclusive of ith value.

    indexes |> List.map productsExcluding

let productExceptSelf_optimized (xs: int list) : int list =
    // O(n) solution with O(1) space complexity.
    // Using an Array result allows assignment to indexed values.
    // First build left products into result.
    // Then go right -> left, with a right product accumulator staring from 1 and
    // multiply with the existing i'th value into the array.
    // Mutate the right accumulator with the next value.
    let n = xs.Length
    let result = Array.create n 1
    let xsArray = List.toArray xs

    // Pass 1: Build left products into result
    for i in 1 .. n - 1 do
        result[i] <- result[i - 1] * xsArray[i - 1]

    // Pass 2: Multiply by right products on the fly
    let mutable right = 1

    for i in n - 1 .. -1 .. 0 do
        result[i] <- result[i] * right
        right <- right * xsArray[i]

    Array.toList result

let productExceptSelf_v2 (xs: int list) : int list =
    // O(n) solution with space complexity of O(n).
    let n = xs.Length

    // scan is like fold but returns all intermediate results
    let leftProds = xs |> List.scan (*) 1 |> List.take n // List.scan returns n+1 elements and the final value is a product of all elements, which we omit.

    let rightProds =
        List.rev xs
        |> List.scan (*) 1
        |> List.take n // omit final value
        |> List.rev // put in order

    List.map2 (*) leftProds rightProds
