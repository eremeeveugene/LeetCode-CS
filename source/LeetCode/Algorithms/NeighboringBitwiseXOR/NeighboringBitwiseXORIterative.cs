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

namespace LeetCode.Algorithms.NeighboringBitwiseXOR;

/// <inheritdoc />
public class NeighboringBitwiseXORIterative : INeighboringBitwiseXOR
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="derived"></param>
    /// <returns></returns>
    public bool DoesValidArrayExist(int[] derived)
    {
        var xorResult = 0;

        foreach (var num in derived)
        {
            xorResult ^= num;
        }

        return xorResult == 0;
    }
}