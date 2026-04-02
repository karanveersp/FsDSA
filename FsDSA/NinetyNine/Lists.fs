module FsDSA.NinetyNine.Lists


let rec last xs =
    match xs with
    | [] -> None
    | [ x ] -> Some x
    | _ :: tail -> last tail

let rec lastTwo xs =
    match xs with
    | []
    | [ _ ] -> None
    | [ x; y ] -> Some(x, y)
    | _ :: tail -> lastTwo tail


let rec at n xs =
    match n, xs with
    | _, [] -> None
    | 0, head :: _ -> Some head
    | _, _ :: tail -> at (n - 1) tail
