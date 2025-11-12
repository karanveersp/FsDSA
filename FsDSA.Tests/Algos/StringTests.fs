module FsDSA.Tests.Algos.StringTests

open FsDSA.Algos.Strings
open Xunit

[<Fact>]
let ``Palindrome Works`` () =

    let result = isPalindrome ("Race Car")
    Assert.True(result)

[<Fact>]
let ``Merge Strings Alternately`` () =
    let result = mergeAlternately "abc" "pqr"
    Assert.Equal("apbqcr", result)
