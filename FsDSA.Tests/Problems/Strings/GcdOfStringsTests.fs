module FsDSA.Tests.Problems.Strings.GcdOfStringsTests

open FsDSA.Problems.Strings.GcdOfStrings
open Xunit

[<Fact>]
let ``GCD of strings with same pattern repeated`` () =
    let res = gcd "ABCABC" "ABC"
    Assert.Equal("ABC", res)

[<Fact>]
let ``GCD of strings shorter gcd than inputs`` () =
    let res = gcd "ABABAB" "ABAB"
    Assert.Equal("AB", res)

[<Fact>]
let ``GCD of strings with no common divisor`` () =
    let res = gcd "LEET" "CODE"
    Assert.Equal("", res)


[<Fact>]
let ``GCD of strings with longer pattern`` () =
    let res = gcd "ABABABAB" "ABAB"
    Assert.Equal("ABAB", res)
