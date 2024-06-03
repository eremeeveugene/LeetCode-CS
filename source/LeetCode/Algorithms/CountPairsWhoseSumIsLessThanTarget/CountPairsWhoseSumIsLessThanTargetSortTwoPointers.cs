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

namespace LeetCode.Algorithms.CountPairsWhoseSumIsLessThanTarget;

/// <inheritdoc />
public class CountPairsWhoseSumIsLessThanTargetSortTwoPointers : ICountPairsWhoseSumIsLessThanTarget
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int CountPairs(IList<int> nums, int target)
    {
        var count = 0;

        var orderedNums = nums.Order().ToArray();

        var left = 0;
        var right = orderedNums.Length - 1;

        while (left < right)
        {
            if (orderedNums[left] + orderedNums[right] < target)
            {
                count += right - left;

                left++;
            }
            else
            {
                right--;
            }
        }

        return count;
    }
}