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

namespace LeetCode.Algorithms.DefuseTheBomb;

/// <inheritdoc />
public class DefuseTheBombSlidingWindow : IDefuseTheBomb
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="code"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int[] Decrypt(int[] code, int k)
    {
        var result = new int[code.Length];

        if (k == 0)
        {
            return result;
        }

        var sum = 0;
        var start = k > 0 ? 1 : code.Length + k;
        var end = k > 0 ? k : code.Length - 1;

        for (var i = start; i <= end; i++)
        {
            sum += code[i % code.Length];
        }

        for (var i = 0; i < code.Length; i++)
        {
            result[i] = sum;

            sum -= code[start % code.Length];

            start++;
            end++;

            sum += code[end % code.Length];
        }

        return result;
    }
}