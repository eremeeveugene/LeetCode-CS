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

namespace LeetCode.Algorithms.RangeSumQueryImmutable;

/// <inheritdoc />
internal class RangeSumQueryImmutableBruteForce(int[] nums) : IRangeSumQueryImmutable
{
    /// <summary>
    ///     Time complexity - O(right − left + 1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public int SumRange(int left, int right)
    {
        var sum = 0;

        for (var i = left; i <= right; i++)
        {
            sum += nums[i];
        }

        return sum;
    }
}