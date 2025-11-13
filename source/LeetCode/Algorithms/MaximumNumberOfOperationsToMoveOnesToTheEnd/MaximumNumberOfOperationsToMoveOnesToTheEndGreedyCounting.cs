// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MaximumNumberOfOperationsToMoveOnesToTheEnd;

/// <inheritdoc />
public class MaximumNumberOfOperationsToMoveOnesToTheEndGreedyCounting : IMaximumNumberOfOperationsToMoveOnesToTheEnd
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MaxOperations(string s)
    {
        var count = 0;

        var ones = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                while (i + 1 < s.Length && s[i + 1] == '0')
                {
                    i++;
                }

                count += ones;
            }
            else
            {
                ones++;
            }
        }

        return count;
    }
}