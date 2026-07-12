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

namespace LeetCode.Algorithms.BagOfTokens;

/// <inheritdoc />
public sealed class BagOfTokensTwoPointers : IBagOfTokens
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int BagOfTokensScore(int[] tokens, int power)
    {
        var score = 0;

        Array.Sort(tokens);

        var left = 0;
        var right = tokens.Length - 1;

        while (left <= right)
        {
            if (power >= tokens[left])
            {
                power -= tokens[left];
                score++;
                left++;
            }
            else if (score >= 1 && left < right)
            {
                power += tokens[right];
                score--;
                right--;
            }
            else
            {
                break;
            }
        }

        return score;
    }
}