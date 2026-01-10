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

namespace LeetCode.Algorithms.FindThePrefixCommonArrayOfTwoArrays;

/// <inheritdoc />
public sealed class FindThePrefixCommonArrayOfTwoArraysHashSet : IFindThePrefixCommonArrayOfTwoArrays
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int[] FindThePrefixCommonArray(int[] a, int[] b)
    {
        var result = new int[a.Length];
        var seenHashSet = new HashSet<int>();
        var count = 0;

        for (var i = 0; i < a.Length; i++)
        {
            if (!seenHashSet.Add(a[i]))
            {
                count++;
            }

            if (!seenHashSet.Add(b[i]))
            {
                count++;
            }

            result[i] = count;
        }

        return result;
    }
}