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
public class ConstructKPalindromeStringsFrequencyDictionary : IConstructKPalindromeStrings
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
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

        var frequencyDictionary = new Dictionary<char, int>();

        foreach (var c in s.Where(c => !frequencyDictionary.TryAdd(c, 1)))
        {
            frequencyDictionary[c]++;
        }

        return frequencyDictionary.Count(frequency => frequency.Value % 2 == 1) <= k;
    }
}