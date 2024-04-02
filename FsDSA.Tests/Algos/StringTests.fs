module FsDSA.Tests.Algos.StringTests

open FsDSA.Algos.Strings
open Xunit

[<Fact>]
let ``Palindrome Works`` () =

    let result = isPalindrome ("Race Car")
    Assert.True(result)