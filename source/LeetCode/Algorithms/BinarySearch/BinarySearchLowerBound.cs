﻿namespace LeetCode.Algorithms.BinarySearch;

/// <inheritdoc />
public class BinarySearchLowerBound : IBinarySearch
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length;

        while (left < right)
        {
            var mid = left + ((right - left) / 2);

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        if (left < nums.Length && nums[left] == target)
        {
            return left;
        }

        return -1;
    }
}