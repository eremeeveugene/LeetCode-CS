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

namespace LeetCode.Algorithms.MinimumLimitOfBallsInBag;

/// <inheritdoc />
public class MinimumLimitOfBallsInBagBinarySearch : IMinimumLimitOfBallsInBag
{
    /// <summary>
    ///     Time complexity - O(n log m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="maxOperations"></param>
    /// <returns></returns>
    public int MinimumSize(int[] nums, int maxOperations)
    {
        var left = 1;
        var right = nums.Max();

        var result = right;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);

            if (nums.Where(num => num > mid).Sum(num => (num - 1) / mid) <= maxOperations)
            {
                result = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }
}