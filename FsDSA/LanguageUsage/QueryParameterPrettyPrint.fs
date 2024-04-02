module FsDSA.LanguageUsage.QueryParameterPrettyPrint

open System

let printQueryParams (s: string): unit =
    s.Split('&')
    |> Array.iter (fun p ->
        let parts = p.Split('=')
        printfn "%s = %s" parts[0] parts[1])
    