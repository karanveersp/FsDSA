module FsDSA.Tests.Problems.Strings.PalindromeTests

open FsDSA.Problems.Strings.Palindrome
open Xunit

[<Fact>]
let ``Palindrome Works`` () =

    let result = isPalindrome ("Race Car")
    Assert.True(result)
