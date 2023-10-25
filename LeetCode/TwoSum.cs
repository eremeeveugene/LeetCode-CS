﻿namespace LeetCode;

/// <summary>
///     Two Sum
///     Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to
///     target.
///     You may assume that each input would have exactly one solution, and you may not use the same element twice.
///     You can return the answer in any order.
///     Example 1:
///     Input: nums = [2,7,11,15], target = 9
///     Output: [0,1]
///     Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
///     Example 2:
///     Input: nums = [3,2,4], target = 6
///     Output: [1,2]
///     Example 3:
///     Input: nums = [3,3], target = 6
///     Output: [0,1]
///     Constraints:
///     2 less than or equal nums.length less than or equal 10^4
///     -10^9 less than or equal nums[i] less than or equal 10^9
///     -10^9 less than or equal target less than or equal 10^9
///     Only one valid answer exists
/// </summary>
public static class TwoSum
{
    /// <summary>
    ///     Time complexity - O (n^2)
    ///     Space complexity - O (n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] GetResult(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        for (var j = i + 1; j < nums.Length; j++)
            if (nums[i] + nums[j] == target)
                return new[] { i, j };

        return Array.Empty<int>();
    }

    /// <summary>
    ///     Time complexity - O (n)
    ///     Space complexity - O (n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] GetResultDictionary(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
            if (dictionary.TryGetValue(target - nums[i], out var value))
                return new[] { value, i };
            else
                dictionary.TryAdd(nums[i], i);

        return Array.Empty<int>();
    }
}