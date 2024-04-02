module FsDSA.Problems.Arrays.RemoveDuplicates
// Given an int array sorted in increasing order, remove duplicates 'in-place' such that each unique element appears only once.
// The sorted order must not be affected.
// Return the number of unique elements in the input array.
let removeDuplicates (nums: int array) : int =
    // [1; 2; 2; 3; 5; 5; 7]
    // Expected
    // [1; 2; 3; 5; 7; ...]
    // so duplicates need to be pushed to the end of the list.
    // [1; 2; 3; 5; 7; 5; 2]
    
    let swapCascadeTillEnd (start: int) (stop: int) : unit =
        for i in start .. (stop-1) do
            let temp = nums[i]
            nums[i] <- nums[i+1]
            nums[i+1] <- temp

    let mutable numSet = Set.empty
    let mutable x, y = 0, nums.Length-1

    while x <= y do
        if numSet.Contains nums[x] then
            swapCascadeTillEnd x y
            y <- y - 1
        else
            numSet <- numSet.Add nums[x]
            x <- x + 1

    numSet.Count