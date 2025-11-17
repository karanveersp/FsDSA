module FsDSA.Problems.Arrays.MoveZeroes

/// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
/// Note that you must do this in-place without making a copy of the array.
/// Two pointer problem.
///
/// https://leetcode.com/problems/move-zeroes
///
/// EASY
///
/// In this algorithm we use a write index to assign non zero values in-order
/// from the left, and then assign 0s for all remaining indexes. No swapping, or shifting of values.
/// Simple linear iteration and assignment with O(1) space where we re-use the passed array.
/// O(n) runtime.
let moveZeroes (nums: int array) : unit =
    let mutable writeIndex = 0 // this index lets us write nonzero values in-order. Advances only when a nonzero value is read.

    // O(n). We iterate through each number and if nonzero, we write it at write index
    // and advance the write index.
    for num in nums do
        if num > 0 then
            nums[writeIndex] <- num
            writeIndex <- writeIndex + 1

    // Write 0s for all remaining indexes after writeIndex.
    for i in [ writeIndex .. nums.Length - 1 ] do
        nums[i] <- 0
