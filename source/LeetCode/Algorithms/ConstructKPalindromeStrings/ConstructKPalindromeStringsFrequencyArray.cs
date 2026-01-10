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

namespace LeetCode.Algorithms.ConstructKPalindromeStrings;

/// <inheritdoc />
public sealed class ConstructKPalindromeStringsFrequencyArray : IConstructKPalindromeStrings
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool CanConstruct(string s, int k)
    {
        if (s.Length < k)
        {
            return false;
        }

        var frequencyArray = new int['z' - 'a' + 1];

        foreach (var c in s)
        {
            frequencyArray[c - 'a']++;
        }

        return frequencyArray.Count(frequency => frequency % 2 == 1) <= k;
    }
}