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

namespace LeetCode.Algorithms.LongestCommonPrefix;

/// <inheritdoc />
public sealed class LongestCommonPrefixHorizontalScanning : ILongestCommonPrefix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(S), where S is the sum of all characters in all strings
    ///     Space complexity - O(1)
    /// </remarks>
    public string LongestCommonPrefix(string[] strs)
    {
        var firstString = strs[0];

        if (string.IsNullOrEmpty(firstString))
        {
            return string.Empty;
        }

        var minLength = int.MaxValue;

        for (var i = 0; i < strs.Length; i++)
        {
            var str = strs[i];

            minLength = Math.Min(minLength, str.Length);
        }

        var prefixLength = 0;

        for (var i = 0; i < minLength; i++)
        {
            var allMatch = true;

            for (var j = 0; j < strs.Length; j++)
            {
                var str = strs[j];

                if (str[i] != firstString[i])
                {
                    allMatch = false;

                    break;
                }
            }

            if (allMatch)
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