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

namespace LeetCode.Algorithms.MinimumDeletionsToMakeArraySharp;

/// <inheritdoc />
public sealed class MinimumDeletionsToMakeArraySharpIterative : IMinimumDeletionsToMakeArraySharp
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinDeletions(int[] nums)
    {
        var n = nums.Length;

        var result = 0;

        var previousNum = nums[0];

        for (var i = 1; i < n; i++)
        {
            var num = nums[i];

            if (num == previousNum)
            {
                result++;
            }
            else
            {
                previousNum = num;
            }
        }

        return result;
    }
}