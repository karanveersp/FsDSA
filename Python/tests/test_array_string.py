import sys
import os

sys.path.append(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

from array_string import gcdOfStrings, kidsWithCandies, canPlaceFlowers, reverseVowels


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
