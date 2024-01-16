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

namespace LeetCode.Algorithms.ReverseString2;

/// <summary>
///     https://leetcode.com/problems/reverse-string-ii/
/// </summary>
public static class ReverseString2WithCharArray
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public static string ReverseStr(string s, int k)
    {
        var charArray = s.ToCharArray();

        for (var start = 0; start < charArray.Length; start += 2 * k)
        {
            var i = start;
            var j = Math.Min(start + k - 1, charArray.Length - 1);

            while (i < j)
            {
                (charArray[i], charArray[j]) = (charArray[j], charArray[i]);

                i++;
                j--;
            }
        }

        return new string(charArray);
    }
}