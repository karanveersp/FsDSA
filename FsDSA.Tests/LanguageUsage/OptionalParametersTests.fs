module FsDSA.Tests.LanguageUsage.OptionalParametersTests

open FsDSA.LanguageUsage.OptionalParameters
open Xunit


[<Fact>]
let ``Greeter doesn't yell by default`` () =
    let greeter = Greeter.Personalized "Chris"
    let greeting = greeter.greet()
    Assert.Equal("Hello Chris!", greeting)


[<Fact>]
let ``Greeter yells when true is passed`` () =
    let greeter = Greeter.Generic
    let greeting = greeter.greet(true)
    Assert.Equal("HELLO STRANGER!", greeting)
