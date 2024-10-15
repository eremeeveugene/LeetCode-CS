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

namespace LeetCode.Algorithms.SeparateBlackAndWhiteBalls;

/// <inheritdoc />
public class SeparateBlackAndWhiteBallsTwoPointers : ISeparateBlackAndWhiteBalls
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public long MinimumSteps(string s)
    {
        long minimumSteps = 0;

        var left = 0;

        for (var right = 0; right < s.Length; right++)
        {
            if (s[right] == '1')
            {
                continue;
            }

            minimumSteps += right - left;

            left++;
        }

        return minimumSteps;
    }
}