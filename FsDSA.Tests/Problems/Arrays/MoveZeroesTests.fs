module FsDSA.Tests.Problems.Arrays.MoveZeroesTests


open FsDSA.Problems.Arrays.MoveZeroes
open Xunit

[<Fact>]
let ``Move zeroes to the end and preserves order ex1`` () =
    let input = [| 0; 1; 0; 3; 12 |]
    moveZeroes input |> ignore
    Assert.Equal<int array>([| 1; 3; 12; 0; 0 |], input)

[<Fact>]
let ``Move zeroes with single element array`` () =
    let input = [| 0 |]
    moveZeroes input |> ignore
    Assert.Equal<int array>([| 0 |], input)
