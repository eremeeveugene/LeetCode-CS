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

namespace LeetCode.Algorithms.SplitTheArray;

/// <inheritdoc />
public sealed class SplitTheArrayFrequencyArray : ISplitTheArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsPossibleToSplit(int[] nums)
    {
        Span<byte> numFrequencies = stackalloc byte[101];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            numFrequencies[num]++;
        }

        for (var i = 0; i < numFrequencies.Length; i++)
        {
            var numFrequency = numFrequencies[i];

            if (numFrequency <= 2)
            {
                continue;
            }

            return false;
        }

        return true;
    }
}