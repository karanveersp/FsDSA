module FsDSA.Tests.Problems.Strings.MergeAlternatelyTests

open FsDSA.Problems.Strings.MergeAlternately
open Xunit

[<Fact>]
let ``Merge Strings Alternately`` () =
    let result = merge "abc" "pqr"
    Assert.Equal("apbqcr", result)
