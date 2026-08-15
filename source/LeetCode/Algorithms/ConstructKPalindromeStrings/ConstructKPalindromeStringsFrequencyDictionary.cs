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

using System.Runtime.InteropServices;

namespace LeetCode.Algorithms.ConstructKPalindromeStrings;

/// <inheritdoc />
public sealed class ConstructKPalindromeStringsFrequencyDictionary : IConstructKPalindromeStrings
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool CanConstruct(string s, int k)
    {
        if (s.Length < k)
        {
            return false;
        }

        var charToCountDictionary = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            ref var count = ref CollectionsMarshal.GetValueRefOrAddDefault(charToCountDictionary, c, out _);

            count++;
        }

        var oddCount = 0;

        foreach (var count in charToCountDictionary.Values)
        {
            oddCount += count % 2;
        }

        return oddCount <= k;
    }
}