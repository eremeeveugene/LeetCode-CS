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

namespace LeetCode.Algorithms.PartitionLabels;

/// <inheritdoc />
public sealed class PartitionLabelsTwoPointers : IPartitionLabels
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> PartitionLabels(string s)
    {
        var lastIndex = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            lastIndex[s[i] - 'a'] = i;
        }

        var result = new List<int>();

        var start = 0;
        var end = 0;

        for (var i = 0; i < s.Length; i++)
        {
            end = Math.Max(end, lastIndex[s[i] - 'a']);

            if (i != end)
            {
                continue;
            }

            result.Add(end - start + 1);

            start = i + 1;
        }

        return result;
    }
}