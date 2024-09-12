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

namespace LeetCode.Algorithms.CountTheNumberOfConsistentStrings;

/// <inheritdoc />
public class CountTheNumberOfConsistentStringsHashSet : ICountTheNumberOfConsistentStrings
{
    /// <summary>
    ///     Time complexity - O(n * m + k), where k is the length of allowed string, n is the number of words, m is the length
    ///     of words
    ///     Space complexity - O(k), where k is the length of allowed string
    /// </summary>
    /// <param name="allowed"></param>
    /// <param name="words"></param>
    /// <returns></returns>
    public int CountConsistentStrings(string allowed, string[] words)
    {
        var count = words.Length;

        var allowedHashSet = new HashSet<char>(allowed);

        foreach (var word in words)
        {
            if (word.Any(wordChar => !allowedHashSet.Contains(wordChar)))
            {
                count--;
            }
        }

        return count;
    }
}