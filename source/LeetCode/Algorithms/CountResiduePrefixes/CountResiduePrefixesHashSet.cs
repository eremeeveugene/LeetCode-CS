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

namespace LeetCode.Algorithms.CountResiduePrefixes;

/// <inheritdoc />
public sealed class CountResiduePrefixesHashSet : ICountResiduePrefixes
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int ResiduePrefixes(string s)
    {
        var result = 0;

        var hashSet = new HashSet<char>();

        for (var i = 0; i < s.Length; i++)
        {
            hashSet.Add(s[i]);

            if (hashSet.Count == (i + 1) % 3)
            {
                result++;
            }
        }

        return result;
    }
}