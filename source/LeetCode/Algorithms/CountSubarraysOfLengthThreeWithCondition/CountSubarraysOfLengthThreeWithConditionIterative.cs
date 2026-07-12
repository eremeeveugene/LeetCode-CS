// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.CountSubarraysOfLengthThreeWithCondition;

/// <inheritdoc />
public sealed class CountSubarraysOfLengthThreeWithConditionIterative : ICountSubarraysOfLengthThreeWithCondition
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountSubarrays(int[] nums)
    {
        var count = 0;

        for (var i = 0; i + 2 < nums.Length; i++)
        {
            if ((nums[i] + nums[i + 2]) * 2 == nums[i + 1])
            {
                count++;
            }
        }

        return count;
    }
}