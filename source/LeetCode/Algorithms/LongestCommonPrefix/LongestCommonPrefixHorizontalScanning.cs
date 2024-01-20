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

namespace LeetCode.Algorithms.LongestCommonPrefix;

/// <inheritdoc />
public class LongestCommonPrefixHorizontalScanning : ILongestCommonPrefix
{
    /// <summary>
    ///     Time complexity - O(S), where S is the sum of all characters in all strings
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public string LongestCommonPrefix(string[] strs)
    {
        var firstString = strs[0];

        if (string.IsNullOrEmpty(firstString))
        {
            return string.Empty;
        }

        var minLength = strs.Min(str => str.Length);
        var prefixLength = 0;

        for (var i = 0; i < minLength; i++)
        {
            if (strs.All(str => str[i] == firstString[i]))
            {
                prefixLength++;
            }
            else
            {
                break;
            }
        }

        return firstString[..prefixLength];
    }
}