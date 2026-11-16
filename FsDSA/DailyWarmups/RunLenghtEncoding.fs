module FsDSA.DailyWarmups.RunLenghtEncoding

open System

let encode (input: string) : (char * int) list =
    let mutable result = System.Collections.Generic.Dictionary<char, int>()
    for c in input do
        if result.ContainsKey(c) then
            result[c] <- result[c] + 1
        else
            result[c] <- 1
    result
    |> Seq.map (fun pair -> (pair.Key, pair.Value))
    |> Seq.toList

let decode (pairs: (char * int) list) : string =
    raise (System.NotImplementedException())


