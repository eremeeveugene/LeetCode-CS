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

namespace LeetCode.Algorithms.MinimumArrayEnd;

/// <inheritdoc />
public sealed class MinimumArrayEndIterative : IMinimumArrayEnd
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    public long MinEnd(int n, int x)
    {
        long result = x;

        while (--n > 0)
        {
            result = (result + 1) | (uint)x;
        }

        return result;
    }
}