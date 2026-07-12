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

namespace LeetCode.Algorithms.FindTheStudentThatWillReplaceTheChalk;

/// <inheritdoc />
public sealed class FindTheStudentThatWillReplaceTheChalkPrefixSum : IFindTheStudentThatWillReplaceTheChalk
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int ChalkReplacer(int[] chalk, int k)
    {
        var sum = 0;

        foreach (var value in chalk)
        {
            sum += value;

            if (sum > k)
            {
                break;
            }
        }

        var remainder = k % sum;

        var i = 0;

        while (remainder - chalk[i] >= 0)
        {
            remainder -= chalk[i];

            i++;
        }

        return i;
    }
}