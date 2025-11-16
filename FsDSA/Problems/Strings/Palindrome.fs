module FsDSA.Problems.Strings.Palindrome

open System

let isPalindrome (s: string) : bool =
    let cleaned =
        s.ToCharArray()
        |> Array.filter Char.IsLetterOrDigit
        |> Array.map Char.ToLower
        |> String.Concat

    let reversed = cleaned.ToCharArray() |> Array.rev |> String
    cleaned = reversed
