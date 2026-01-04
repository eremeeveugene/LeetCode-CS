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

namespace LeetCode.Algorithms.MaximumScoreAfterSplittingString;

/// <inheritdoc />
public class MaximumScoreAfterSplittingStringIterative : IMaximumScoreAfterSplittingString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MaxScore(string s)
    {
        var zeros = 0;

        if (s[0] == '0')
        {
            zeros++;
        }

        var ones = 0;

        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                ones++;
            }
        }

        var maxScore = zeros + ones;

        for (var i = 1; i < s.Length; i++)
        {
            maxScore = Math.Max(maxScore, zeros + ones);

            if (s[i] == '0')
            {
                zeros++;
            }
            else
            {
                ones--;
            }
        }

        return maxScore;
    }
}