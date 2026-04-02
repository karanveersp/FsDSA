module FsDSA.Tests.NinetyNine.ListsTests

open FsDSA.NinetyNine.Lists
open Xunit
open FsUnit.Xunit

[<Fact>]
let ``99 - Tail of a list returns last element`` () =
    let xs = [ "a"; "b"; "c"; "d" ]
    last xs |> should equal (Some "d")

[<Fact>]
let ``99 - Tail of an empty list is None`` () = last [] |> should equal None


[<Fact>]
let ``99 - Last Two returns last and second last elements`` () =
    let xs = [ "a"; "b"; "c"; "d" ]
    lastTwo xs |> should equal (Some("c", "d"))

[<Fact>]
let ``99 - Last Two of single item list returns None`` () = lastTwo [ "a" ] |> should equal None


[<Fact>]
let ``99 - Nth element of a list`` () =
    at 2 [ "a"; "b"; "c"; "d"; "e" ] |> should equal (Some "c")
    at 2 ["a"] |> should equal None