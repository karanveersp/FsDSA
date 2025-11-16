module FsDSA.Tests.Problems.Arrays.RemoveDuplicatesTests
open Xunit

open FsDSA.Problems.Arrays.RemoveDuplicates

[<Fact>]
let ``[1,1,2] returns 2 with expected order`` () =
    let nums = [|1;1;2|]
    let expected = [|1;2|]
    let k = removeDuplicates nums

    Assert.Equal(expected.Length, k)
    for i in 0 .. k-1 do
       Assert.True(nums[i] = expected[i])

[<Fact>]
let ``Larger array returns 5 with expected order`` () =
    let nums = [|0;0;1;1;1;2;2;3;3;4|]
    let expected = [|0;1;2;3;4|]
    let k = removeDuplicates nums

    Assert.Equal(expected.Length, k)
    for i in 0 .. k-1 do
        Assert.True(nums[i] = expected[i])
