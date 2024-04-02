module FsDSA.Algos.Arrays

let print2DArray (matrix: int [,]) =
    let height = matrix.GetLength(0)
    let width = matrix.GetLength(1)

    for i in 0 .. height - 1 do
        for j in 0 .. width - 1 do
            printf "%d " matrix.[i, j]

        printfn ""
