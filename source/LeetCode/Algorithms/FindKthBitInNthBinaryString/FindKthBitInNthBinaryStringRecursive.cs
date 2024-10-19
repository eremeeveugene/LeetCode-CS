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

namespace LeetCode.Algorithms.FindKthBitInNthBinaryString;

/// <inheritdoc />
public class FindKthBitInNthBinaryStringRecursive : IFindKthBitInNthBinaryString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public char FindKthBit(int n, int k)
    {
        if (n == 1)
        {
            return '0';
        }

        var length = (1 << n) - 1;
        var mid = (length / 2) + 1;

        if (k == mid)
        {
            return '1';
        }

        if (k < mid)
        {
            return FindKthBit(n - 1, k);
        }

        var mirroredIndex = length - k + 1;
        var mirroredBit = FindKthBit(n - 1, mirroredIndex);

        return mirroredBit == '0' ? '1' : '0';
    }
}