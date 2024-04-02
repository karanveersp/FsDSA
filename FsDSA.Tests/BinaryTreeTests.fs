module FsDSA.Tests.BinaryTreeTests

open Xunit
open FsDSA.BinaryTree
open FsDSA


[<Fact>]
let ``Preorder Binary Tree Traversal Works`` () =
    let btree = Node(1, Node(2, Empty, Empty), Node(3, Empty, Empty))
    let result: int list = preorder btree

    Assert.Equal<int list>([ 1; 2; 3 ], result)

[<Fact>]
let ``Inorder Binary Tree Traversal Works`` () =
    let btree = Node(1, Node(2, Empty, Empty), Node(3, Empty, Empty))
    let result = inorder btree
    Assert.Equal<int list>([ 2; 1; 3 ], result)


[<Fact>]
let ``Postorder Binary Tree Traversal Works`` () =
    let btree = Node(1, Node(2, Empty, Empty), Node(3, Empty, Empty))
    let result = postorder btree
    Assert.Equal<int list>([ 2; 3; 1 ], result)

[<Fact>]
let ``Binary Tree Height Works`` () =
    let btree = Node(1, Node(2, Empty, Empty), Node(3, Empty, Node(4, Empty, Empty)))
    let result = height btree
    Assert.Equal(3, result)



// [<Fact>]
// let ``Permutations Works`` () =
//     let expected =
//         [ [ 1; 2; 3 ]
//           [ 1; 3; 2 ]
//           [ 2; 1; 3 ]
//           [ 2; 3; 1 ]
//           [ 3; 1; 2 ]
//           [ 3; 2; 1 ] ]

//     let result = allPermutations ([ 1; 2; 3 ])

//     Assert.Equal<int list list>(expected, result)
