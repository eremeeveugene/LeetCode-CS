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

namespace LeetCode.Algorithms.MaximumNestingDepthOfTheParentheses;

/// <inheritdoc />
public sealed class MaximumNestingDepthOfTheParenthesesIterative : IMaximumNestingDepthOfTheParentheses
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxDepth(string s)
    {
        var maxDepth = 0;

        var curDepth = 0;

        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                    {
                        curDepth++;

                        maxDepth = Math.Max(maxDepth, curDepth);

                        break;
                    }
                case ')':
                    curDepth--;

                    break;
            }
        }

        return maxDepth;
    }
}