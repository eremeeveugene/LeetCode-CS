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

namespace LeetCode.Algorithms.GetEqualSubstringsWithinBudget;

/// <inheritdoc />
public sealed class GetEqualSubstringsWithinBudgetSlidingWindow : IGetEqualSubstringsWithinBudget
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int EqualSubstring(string s, string t, int maxCost)
    {
        var maxLength = 0;
        var cost = 0;
        var left = 0;
        var right = 0;

        while (right < s.Length)
        {
            cost += Math.Abs(s[right] - t[right]);

            while (cost > maxCost)
            {
                cost -= Math.Abs(s[left] - t[left]);

                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);

            right++;
        }

        return maxLength;
    }
}