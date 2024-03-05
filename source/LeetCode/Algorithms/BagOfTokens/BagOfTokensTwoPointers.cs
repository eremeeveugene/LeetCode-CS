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

namespace LeetCode.Algorithms.BagOfTokens;

/// <inheritdoc />
public class BagOfTokensTwoPointers : IBagOfTokens
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="tokens"></param>
    /// <param name="power"></param>
    /// <returns></returns>
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
            else if (score >= 1 && left != right)
            {
                power += tokens[right];
                score--;
                right--;
            }
            else
            {
                left++;
            }
        }

        return score;
    }
}