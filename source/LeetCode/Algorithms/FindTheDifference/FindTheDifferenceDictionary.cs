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

namespace LeetCode.Algorithms.FindTheDifference;

/// <inheritdoc />
public class FindTheDifferenceDictionary : IFindTheDifference
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public char FindTheDifference(string s, string t)
    {
        var sDictionary = new Dictionary<char, int>();

        foreach (var sItem in s.Where(sItem => !sDictionary.TryAdd(sItem, 1)))
        {
            sDictionary[sItem]++;
        }

        foreach (var tItem in t)
        {
            if (sDictionary.TryGetValue(tItem, out var tItemValue) && tItemValue > 0)
            {
                sDictionary[tItem]--;
            }
            else
            {
                return tItem;
            }
        }

        return (char)0;
    }
}