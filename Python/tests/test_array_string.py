import sys
import os

sys.path.append(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

from array_string import (
    gcdOfStrings,
    kidsWithCandies,
    canPlaceFlowers,
    reverseVowels,
    reverseWords,
    productExceptSelf,
    increasingTriplet,
    compressString,
)


def test_gcd_of_strings_same_pattern_repeated():
    res = gcdOfStrings("ABCABC", "ABC")
    assert res == "ABC"


def test_gcd_of_strings_shorter_gcd_than_inputs():
    res = gcdOfStrings("ABABAB", "ABAB")
    assert res == "AB"


def test_gcd_of_strings_no_common_divisor():
    res = gcdOfStrings("LEET", "CODE")
    assert res == ""


def test_gcd_of_strings_longer_gcd_pattern():
    res = gcdOfStrings("ABABABAB", "ABAB")
    assert res == "ABAB"


def test_kids_with_candies_ex1():
    res = kidsWithCandies([2, 3, 5, 1, 3], 3)
    assert res == [True, True, True, False, True]


def test_kids_with_candies_ex2():
    res = kidsWithCandies([4, 2, 1, 1, 2], 1)
    assert res == [True, False, False, False, False]


def test_kids_with_candies_ex3():
    res = kidsWithCandies([12, 1, 12], 10)
    assert res == [True, False, True]


def test_can_place_flowers_ex1():
    res = canPlaceFlowers([1, 0, 0, 0, 1], 1)
    assert res


def test_can_place_flowers_ex2():
    res = canPlaceFlowers([1, 0, 0, 0, 1], 2)
    assert not res


def test_can_place_flowers_single_bed():
    res = canPlaceFlowers([0], 1)
    assert res


def test_reverse_vowels_ex1():
    res = reverseVowels("IceCreAm")
    assert res == "AceCreIm"


def test_reverse_vowels_ex2():
    res = reverseVowels("leetcode")
    assert res == "leotcede"


def test_reverse_words_ex1():
    res = reverseWords("the sky is blue")
    assert res == "blue is sky the"


def test_reverse_words_ex2():
    res = reverseWords("  hello world  ")
    assert res == "world hello"


def test_reverse_words_ex3():
    res = reverseWords("a good   example")
    assert res == "example good a"


def test_product_except_self_ex1():
    res = productExceptSelf([1, 2, 3, 4])
    assert res == [24, 12, 8, 6]


def test_product_except_self_ex2():
    res = productExceptSelf([-1, 1, 0, -3, 3])
    assert res == [0, 0, 9, 0, 0]


def test_increasing_triplet_subsequence_ex1():
    res = increasingTriplet([1, 2, 3, 4, 5])
    assert res


def test_increasing_triplet_subsequence_ex2():
    res = increasingTriplet([5, 4, 3, 2, 1])
    assert not res


def test_increasing_triplet_subsequence_ex3():
    res = increasingTriplet([2, 1, 5, 0, 4, 6])
    assert res


def test_increasing_triplet_subsequence_ex4():
    res = increasingTriplet([20, 100, 10, 12, 5, 13])
    assert res


def test_increasing_triplet_subsequence_ex5():
    res = increasingTriplet([1, 5, 0, 4, 1, 3])
    assert res


def test_increasing_triplet_subsequence_ex6():
    res = increasingTriplet([1, 1, -2, 6])
    assert not res


def test_string_compression_ex1():
    res = compressString(["a", "a", "b", "b", "c", "c", "c"])
    assert res == 6


def test_string_compression_ex2():
    res = compressString(["a"])
    assert res == 1


def test_string_compression_ex3():
    arr = ["a", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b"]
    res = compressString(arr)
    assert arr[:res] == ["a", "b", "1", "2"]
    assert res == 4


def test_string_compression_ex4():
    arr = ["a", "a", "a", "b", "b", "a", "a"]
    res = compressString(arr)
    assert arr[:res] == ["a", "3", "b", "2", "a", "2"]
    assert res == 6


def test_string_compression_ex5():
    arr = ["a", "a", "a", "a", "a", "b"]
    res = compressString(arr)
    assert arr[:res] == ["a", "5", "b"]
    assert res == 3
