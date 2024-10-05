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

namespace LeetCode.Algorithms.PermutationInString;

/// <inheritdoc />
public class PermutationInStringSlidingWindowDictionary : IPermutationInString
{
    /// <summary>
    ///     Time complexity - O(n + m), where n is the length of s1 and m is the length of s2
    ///     Space complexity - O(k), where k is the number of unique characters in the input
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public bool CheckInclusion(string s1, string s2)
    {
        if (s2.Length < s1.Length)
        {
            return false;
        }

        var s1Dictionary = new Dictionary<char, int>();
        var s2Dictionary = new Dictionary<char, int>();

        for (var i = 0; i < s1.Length; i++)
        {
            if (!s1Dictionary.TryAdd(s1[i], 1))
            {
                s1Dictionary[s1[i]]++;
            }

            if (!s2Dictionary.TryAdd(s2[i], 1))
            {
                s2Dictionary[s2[i]]++;
            }
        }

        for (var i = 0; i < s2.Length - s1.Length; i++)
        {
            if (AreDictionariesEqual(s1Dictionary, s2Dictionary))
            {
                return true;
            }

            if (!s2Dictionary.TryAdd(s2[i + s1.Length], 1))
            {
                s2Dictionary[s2[i + s1.Length]]++;
            }

            s2Dictionary[s2[i]]--;
        }

        return AreDictionariesEqual(s1Dictionary, s2Dictionary);
    }

    private static bool AreDictionariesEqual(Dictionary<char, int> dictionary1, Dictionary<char, int> dictionary2)
    {
        foreach (var dictionary1Item in dictionary1)
        {
            if (!dictionary2.TryGetValue(dictionary1Item.Key, out var dictionary2ItemValue) ||
                dictionary2ItemValue != dictionary1Item.Value)
            {
                return false;
            }
        }

        return true;
    }
}