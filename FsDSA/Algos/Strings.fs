module FsDSA.Algos.Strings

open System

let isPalindrome (s: string) : bool =
    let cleaned =
        s.ToCharArray()
        |> Array.filter Char.IsLetterOrDigit
        |> Array.map Char.ToLower
        |> String.Concat

    let reversed = cleaned.ToCharArray() |> Array.rev |> String
    cleaned = reversed


// Merge Strings Alternately
// Given two strings `word1` and `word2` merge the strings by adding letters in alternating order,
// starting with `word1`. Append remaining letters onto the end of the merged string. Return merged string.
let mergeAlternately (a: string) (b: string) : string =
    let rec merger (word1: string) (word2: string) (result: string) (left: bool) : string =
        match word1, word2 with
        | "", "" -> result
        | "", word2 -> result + word2
        | word1, "" -> result + word1
        | word1, word2 ->
            if left then
                let newRes = result + string (word1[0])
                merger (word1.Substring 1) (word2.Substring 0) newRes false
            else
                let newRes = result + string (word2[0])
                merger (word1.Substring 0) (word2.Substring 1) newRes true

    merger a b "" true
