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

namespace LeetCode.Algorithms.FindNUniqueIntegersSumUpToZero;

/// <inheritdoc />
public class FindNUniqueIntegersSumUpToZeroIterative : IFindNUniqueIntegersSumUpToZero
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] SumZero(int n)
    {
        var result = new int[n];

        var resultIndex = 0;

        for (var i = 1; i <= n / 2; i++)
        {
            result[resultIndex++] = i;
            result[resultIndex++] = -i;
        }

        return result;
    }
}