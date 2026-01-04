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

namespace LeetCode.Algorithms.CheckIfStringIsPrefixOfArray;

/// <inheritdoc />
public class CheckIfStringIsPrefixOfArrayTwoPointers : ICheckIfStringIsPrefixOfArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="words"></param>
    /// <returns></returns>
    public bool IsPrefixString(string s, string[] words)
    {
        var sIndex = 0;

        foreach (var word in words)
        {
            foreach (var letter in word)
            {
                if (sIndex == s.Length)
                {
                    return false;
                }

                if (s[sIndex] != letter)
                {
                    return false;
                }

                sIndex++;
            }

            if (sIndex == s.Length)
            {
                return true;
            }
        }

        return sIndex == s.Length;
    }
}