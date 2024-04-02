namespace FsDSA.LanguageUsage.OptionalParameters

// A type can have member methods with optional parameters using
// the ? operator.
type Greeter =
    | Personalized of string
    | Generic
    with
        member this.greet (?yell: bool) =
            let yellEnabled = yell |> Option.defaultValue false
            let greeting =
                match this with
                | Personalized name ->
                    $"Hello {name}!"
                | Generic ->
                    "Hello Stranger!"
            if yellEnabled then
                greeting.ToUpper()
            else
                greeting
                    