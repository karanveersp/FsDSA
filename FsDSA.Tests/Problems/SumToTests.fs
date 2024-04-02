module FsDSA.Tests.Problems.SumToTests

open Xunit
open FsDSA.Problems.SumTo

[<Fact>]
let ``Has numbers adding to 17`` () =
    [ 10; 15; 3; 7 ] |> hasSumTo 17 |> Assert.True

[<Fact>]
let ``Doesn't have numbers adding to 3`` () =
    [ 0; 1; 1; 5 ] |> hasSumTo 3 |> Assert.False

[<Fact>]
let ``Has numbers adding to 1`` () =
    [ 0; 1; 3 ] |> hasSumTo 1 |> Assert.True

[<Fact>]
let ``Has numbers adding to 9`` () =
    [ 1; 2; 3; 4; 5 ] |> hasSumTo 9 |> Assert.True

[<Fact>]
let ``Doesn't have numbers adding to 15`` () =
    [ 5; 8; 12; 20 ] |> hasSumTo 15 |> Assert.False


[<Fact>]
let ``Has numbers adding to 0`` () =
    [ 0; 0; 0; 0 ] |> hasSumTo 0 |> Assert.True

[<Fact>]
let ``Has numbers adding to 1 with negatives`` () =
    [ -3; 4; 7; 11 ] |> hasSumTo 1 |> Assert.True

[<Fact>]
let ``Has numbers adding to 2`` () =
    [ 1; 1; 1; 2; 3; 5 ] |> hasSumTo 2 |> Assert.True
