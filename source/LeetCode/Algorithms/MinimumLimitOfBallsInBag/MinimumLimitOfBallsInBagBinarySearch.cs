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

        while (left < right)
        {
            var mid = left + ((right - left) / 2);
            var count = nums.Sum(num => (num - 1) / mid);

            if (count > maxOperations)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }
}