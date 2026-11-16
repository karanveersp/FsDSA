module FsDSA.Tests.DailyWarmups.WarmupTests

open FsDSA.DailyWarmups.RunLenghtEncoding

open Xunit

module RunLengthEncodingTests =
    [<Fact>]
    let ``encode compresses a string into a list of character and count pairs representing consecutive runs`` () =
        let input = "aaabbc"
        let expected = [('a', 3); ('b', 2); ('c', 1)]
        let actual = encode input
        Assert.Equal<(char * int) list>(expected, actual)
    
    [<Fact>]
    let ``decode reconstructs the original string from a list of character and count pairs`` () =
        let input = [('a', 3); ('b', 2); ('c', 1)]
        let expected = "aaabbc"
        let actual = decode input
        Assert.Equal(expected, actual)
