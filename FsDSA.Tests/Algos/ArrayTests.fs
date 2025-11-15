module FsDSA.Tests.Algos.ArrayTests

open FsDSA.Algos.Arrays
open Xunit

[<Fact>]
let ``Increasing Triplet Exists Ex1`` () =
    let result = increasingTripletExists [ 1; 2; 3; 4; 5 ]
    Assert.True result

[<Fact>]
let ``Increasing Triplet Exists Ex2`` () =
    let result = increasingTripletExists [ 5; 4; 3; 2; 1 ]
    Assert.False result

[<Fact>]
let ``Increasing Triplet Exists Ex3`` () =
    let result = increasingTripletExists [ 2; 1; 5; 0; 4; 6 ]
    Assert.True result

[<Fact>]
let ``Increasing Triplet Exists Ex4`` () =
    let result = increasingTripletExists [ 20; 100; 10; 12; 5; 13 ]
    Assert.True result

[<Fact>]
let ``Increasing Triplet Exists Ex5`` () =
    let result = increasingTripletExists [ 1; 5; 0; 4; 1; 3 ]
    Assert.True result

[<Fact>]
let ``Increasing Triplet Exists Ex6`` () =
    let result = increasingTripletExists [ 1; 1; -2; 6 ]
    Assert.False result
