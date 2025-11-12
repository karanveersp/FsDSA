from typing import List


def gcdOfStrings(str1: str, str2: str) -> str:
    "1071"
    substr = ""
    min_len = min(len(str1), len(str2))
    largest_substr = ""

    if len(str1) < len(str2):
        if str1 not in str2:
            return ""
    else:
        if str2 not in str1:
            return ""

    if str1.replace(str2, "") == "":
        return str2
    for i in range(min_len):
        substr += str1[i]
        if str1.replace(substr, "") == "" and str2.replace(substr, "") == "":
            # replacing all occurrances of substr returns an empty string
            # we have a repeating subsequence.
            if len(substr) > len(largest_substr):
                largest_substr = substr

    return largest_substr


def kidsWithCandies(candies: List[int], extraCandies: int) -> List[bool]:
    "1431. candies[i] tells how many candies the ith kid has, and extraCandies."

    max_candies_val = max(candies)

    max_kids = []
    for i in range(len(candies)):
        if candies[i] == max_candies_val:
            max_kids.append(i)

    result = [False for _ in range(len(candies))]
    for i in range(len(candies)):
        kids_total = candies[i] + extraCandies
        if i in max_kids:
            result[i] = True
        elif kids_total >= max_candies_val:
            result[i] = True

    return result


def canPlaceFlowers(flowerbed: List[int], n: int) -> bool:
    if flowerbed == [0]:
        return True

    planted = 0
    for i in range(len(flowerbed)):
        current_is_empty = flowerbed[i] == 0
        if not current_is_empty:
            continue
        prev_is_empty = i - 1 >= 0 and flowerbed[i - 1] == 0
        next_is_empty = i + 1 < len(flowerbed) and flowerbed[i + 1] == 0
        if i == 0:
            # at the start
            can_plant = next_is_empty
        elif i == len(flowerbed) - 1:
            # at final index
            can_plant = prev_is_empty
        else:
            can_plant = prev_is_empty and next_is_empty
        if can_plant:
            planted += 1
            flowerbed[i] = 1

    return planted >= n


def reverseVowels(s: str) -> str:
    vowel_set = {"a", "e", "i", "o", "u"}

    def is_vowel(c: str):
        return str.lower(c) in vowel_set

    i = 0
    j = len(s) - 1

    arr = [c for c in s]

    while i < j:
        # increment i till we find a vowel
        # decrement j till we find a vowel
        # swap!
        # increment i, decrement j
        # loop
        while i < len(arr) and not is_vowel(arr[i]):
            i += 1
        while j >= 0 and not is_vowel(arr[j]):
            j -= 1
        if i > j:
            break
        arr[i], arr[j] = arr[j], arr[i]
        i += 1
        j -= 1
    return "".join(arr)
