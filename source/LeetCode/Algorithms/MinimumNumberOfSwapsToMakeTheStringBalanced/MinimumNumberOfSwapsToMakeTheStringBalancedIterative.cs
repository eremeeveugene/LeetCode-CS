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

namespace LeetCode.Algorithms.MinimumNumberOfSwapsToMakeTheStringBalanced;

/// <inheritdoc />
public sealed class MinimumNumberOfSwapsToMakeTheStringBalancedIterative : IMinimumNumberOfSwapsToMakeTheStringBalanced
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinSwaps(string s)
    {
        var count = 0;

        foreach (var c in s)
        {
            if (c == '[')
            {
                count++;
            }
            else
            {
                if (count > 0)
                {
                    count--;
                }
            }
        }

        return (count + 1) / 2;
    }
}