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

namespace LeetCode.Algorithms.CountIntegersAppearingInASingleBlock;

/// <inheritdoc />
public sealed class CountIntegersAppearingInASingleBlockHashSet : ICountIntegersAppearingInASingleBlock
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int CountSpecialIntegers(int[] nums)
    {
        var n = nums.Length;

        var result = 0;

        var numsHashSet = new HashSet<int>();
        var seenHashSet = new HashSet<int>();

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (i > 0 && num == nums[i - 1])
            {
                continue;
            }

            if (numsHashSet.Add(num))
            {
                result++;
            }
            else if (seenHashSet.Add(num))
            {
                result--;
            }
        }

        return result;
    }
}