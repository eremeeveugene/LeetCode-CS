// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindTargetIndicesAfterSortingArray;

/// <inheritdoc />
public class FindTargetIndicesAfterSortingArrayBinarySearch : IFindTargetIndicesAfterSortingArray
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(k)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums);

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var mid = left + ((right - left) / 2);

            if (nums[mid] >= target)
            {
                right = mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
        }

        if (nums[left] != target)
        {
            return new List<int>();
        }

        var result = new List<int>();

        while (left < nums.Length && nums[left] == target)
        {
            result.Add(left);

            left++;
        }

        return result;
    }
}