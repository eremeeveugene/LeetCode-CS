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

namespace LeetCode.Algorithms.MaximumNestingDepthOfTheParentheses;

/// <inheritdoc />
public class MaximumNestingDepthOfTheParenthesesIterative : IMaximumNestingDepthOfTheParentheses
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
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