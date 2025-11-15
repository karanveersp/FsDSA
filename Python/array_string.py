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


def reverseWords(s: str) -> str:
    words = [w.strip() for w in s.split(" ") if w.strip() != ""]
    i = 0
    j = len(words) - 1
    while i < j and i < len(s) - 1 and j >= 0:
        words[i], words[j] = words[j], words[i]
        i += 1
        j -= 1
    return " ".join(words)


def productExceptSelf_orig(nums: List[int]) -> List[int]:
    "O(n) worst case runtime, with O(n) space."
    left_prod = [1 for _ in range(len(nums))]
    for i in range(len(nums)):
        # assign products from the left
        if i == 0:
            continue
        elif i == 1:
            left_prod[1] = nums[0] * 1
        else:
            left_prod[i] = nums[i - 1] * left_prod[i - 1]

    right_prod = [1 for _ in range(len(nums))]
    for i in range(len(nums)):
        # assign products from the right
        j = len(nums) - 1 - i
        if i == 0:
            continue
        elif i == 1:
            right_prod[j] = nums[j + 1] * 1
        else:
            right_prod[j] = nums[j + 1] * right_prod[j + 1]

    return [left_prod[i] * right_prod[i] for i in range(len(nums))]


def productExceptSelf(nums: List[int]) -> List[int]:
    """O(n) with O(1) space not counting result array. Two-Pass Scan.
    Compute prefix results going left -> right.
    Compute suffix results going right -> left.
    Combine them to get answers for each position. In functional programming this operation is called a `scan` like `scanl`/`scanr` in Haskell.
    This pattern is a fundamental technique in competitive programming and is often one of the
    first optimizations taught for transforming O(n²) brute force solutions into O(n) solutions!
    """
    n = len(nums)

    res = [1] * n

    # build left products directly into result
    for i in range(1, n):
        res[i] = res[i - 1] * nums[i - 1]

    # multiply by right products on the fly
    right_product = 1
    for i in range(n - 1, -1, -1):  # [last index to 0]
        res[i] *= right_product  # res[i] is already left products (i-1)
        right_product *= nums[i]  # accumulate right product
    return res


def increasingTriplet(nums: List[int]) -> bool:
    """
    Given an int array, return True if there exists a triple of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k].
    If no such indices exist, return False.

    The solution is Greedy "Potential" Tracking where you're only tracking the best potential for forming a triplet
    as you scan.
    """

    fst = snd = float("inf")
    for num in nums:
        if num <= fst:
            fst = num
        elif num <= snd:
            snd = num
        else:
            return True
    return False


def compressString(chars: List[str]) -> int:
    """
    Given a list of chars such as ["a", "a", "b", "c"],
    compress the consecutive repreating character groups with a number of repetitions followed by the char.
    Ex. ["2", "a", "b", "c"]
    Use only constant space O(1), and modify the original array.
    Return the new length of the array. Characters in the array beyond the returned length can be ignored.
    """
    # lets use i to track our current character group, and use j to count the number of repeting characters.
    i = 0
    j = 0
    res = 0

    n = len(chars)
    x = 0
    while x < n:
        char_group = chars[x]
        j = x + 1
        count = 1
        while j < n and chars[j] == char_group:
            count += 1
            j += 1
        chars[i] = char_group
        if count > 1:  # we have repetitions
            digits = [c for c in str(count)]
            for digit in digits:
                i += 1
                chars[i] = digit
                res += 1  # each digit adds to result
            x = j  # j is at next char group or end of the list
        else:
            x += 1
        res += 1
        i += 1
    return res
