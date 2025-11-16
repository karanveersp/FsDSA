module FsDSA.Problems.Strings.GcdOfStrings


/// This solution is brute force.
/// O(min(m,n) * m+n)
let gcd_orig (str1: string) (str2: string) : string =
    let smaller = if str1.Length <= str2.Length then str1 else str2

    // O(m+n) since each replace call iterates each string
    let dividesEvenly (substr: string) =
        str1.Replace(substr, "") = "" && str2.Replace(substr, "") = ""

    // O(min(m,n) * (m+n))
    // Min of m,n because we start with the shorter of the strings and reduce chars
    // right to left.
    let rec findGcd (substr: string) : string =
        if substr = "" then ""
        else if dividesEvenly substr then substr
        else findGcd substr[0 .. substr.Length - 2] // reduce substring size by one

    findGcd smaller

/// For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).
/// Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
/// https://leetcode.com/problems/greatest-common-divisor-of-strings/description/
/// EASY - but the mathematical insight is MEDIUM.
///
/// Key insights:
/// 1. If a common divisor exists, then str1 + str2 must equal str2 + str1.
/// 2. Since the GCD is the longest prefix that divides evenly into both str1 and str2, it would
/// be the GCD of the lengths of each string. So use Euclid's algorithm to get the GCD of the lengths
/// and the answer is the substring of that length.
///
/// O(m+n + log(m*n)) but since the log grows very slowly, it's basically
/// O(m+n) or linear time which is VERY fast!
let gcd str1 str2 =
    if str1 + str2 <> str2 + str1 then
        ""
    else
        // O(log(m*n))
        let rec findGcd a b = if b = 0 then a else findGcd b (a % b)
        let gcdLength = findGcd (String.length str1) (String.length str2)
        str1[0 .. gcdLength - 1]
