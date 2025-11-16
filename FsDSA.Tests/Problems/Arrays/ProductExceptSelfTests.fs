module FsDSA.Tests.Problems.Arrays.ProductExceptSelfTests

open FsDSA.Problems.Arrays.ProductExceptSelf
open Xunit

[<Fact>]
let ``[3,2,1] returns [2,3,6]`` () =
    let res = [ 3; 2; 1 ] |> productExceptSelf
    Assert.Equal<int list>([ 2; 3; 6 ], res)

[<Fact>]
let ``[1, 2, 3, 4, 5] returns [120, 60, 40, 30, 24]`` () =
    let res = [ 1; 2; 3; 4; 5 ] |> productExceptSelf
    Assert.Equal<int list>([ 120; 60; 40; 30; 24 ], res)
