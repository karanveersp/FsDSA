namespace FsDSA

type BinaryTree<'a> =
    | Empty
    | Node of 'a * BinaryTree<'a> * BinaryTree<'a> // value, left, right

module BinaryTree =
    let rec preorder tree : 'a list =
        match tree with
        | Empty -> []
        | Node (value, left, right) -> [ value ] @ (preorder left) @ (preorder right)

    let rec inorder tree : 'a list =
        match tree with
        | Empty -> []
        | Node (value: 'a, left, right) -> (inorder left) @ [ value ] @ (inorder right)

    let rec postorder tree : 'a list =
        match tree with
        | Empty -> []
        | Node (value: 'a, left, right) -> (postorder left) @ (postorder right) @ [ value ]

    let rec height tree : int =
        match tree with
        | Empty -> 0
        | Node (_, left, right) -> 1 + max (height left) (height right)


    /// Check if binary tree is balanced.
    /// A binary tree is balanced if height of the two subtrees
    /// of every node never differs by more than 1.
    let isBalanced tree =
        let rec checkBalance tree =
            match tree with
            | Empty -> Some(0)
            | Node (_, left, right) ->
                match checkBalance left, checkBalance right with
                | Some lh, Some rh when abs (lh - rh) <= 1 -> Some(1 + max lh rh)
                | _ -> None

        checkBalance tree |> Option.isSome

    /// Check if a tree is a mirror of itself (symmetric).
    let isSymmetric tree =
        let rec isMirror t1 t2 =
            match t1, t2 with
            | Empty, Empty -> true
            | Node (v1, l1, _), Node (v2, l2, r2) -> v1 = v2 && isMirror l1 r2 && isMirror l2 r2
            | _ -> false

        isMirror tree tree
