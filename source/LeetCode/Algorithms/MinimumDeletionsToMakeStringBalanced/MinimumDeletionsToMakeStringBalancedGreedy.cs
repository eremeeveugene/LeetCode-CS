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

namespace LeetCode.Algorithms.MinimumDeletionsToMakeStringBalanced;

/// <inheritdoc />
public sealed class MinimumDeletionsToMakeStringBalancedGreedy : IMinimumDeletionsToMakeStringBalanced
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MinimumDeletions(string s)
    {
        var result = 0;

        var count = 0;

        foreach (var c in s)
        {
            if (c == 'a')
            {
                result = Math.Min(result + 1, count);
            }
            else
            {
                count++;
            }
        }

        return result;
    }
}