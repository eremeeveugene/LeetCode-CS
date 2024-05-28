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

namespace LeetCode.Algorithms.GetEqualSubstringsWithinBudget;

/// <inheritdoc />
public class GetEqualSubstringsWithinBudgetSlidingWindow : IGetEqualSubstringsWithinBudget
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <param name="maxCost"></param>
    /// <returns></returns>
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