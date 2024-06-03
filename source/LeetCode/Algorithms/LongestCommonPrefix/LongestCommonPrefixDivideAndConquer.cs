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
public class LongestCommonPrefixDivideAndConquer : ILongestCommonPrefix
{
    /// <summary>
    ///     Time complexity - O(S), where S is the sum of all characters in all strings
    ///     Space complexity - O(S), where S is the sum of all characters in all strings
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public string LongestCommonPrefix(string[] strs)
    {
        switch (strs.Length)
        {
            case > 2:
                {
                    var partLength = strs.Length / 2;
                    var leftPart = strs.Take(partLength).ToArray();
                    var rightPart = strs.Skip(partLength).Take(strs.Length - partLength).ToArray();

                    return GetLongestPrefix(LongestCommonPrefix(leftPart), LongestCommonPrefix(rightPart));
                }
            case 2:
                {
                    return GetLongestPrefix(strs[0], strs[1]);
                }
            case 1:
                return strs[0];
        }

        return string.Empty;
    }

    private static string GetLongestPrefix(string str1, string str2)
    {
        var minLength = Math.Min(str1.Length, str2.Length);
        var prefixLength = 0;

        for (var i = 0; i < minLength; i++)
        {
            if (str1[i] == str2[i])
            {
                prefixLength++;
            }
            else
            {
                break;
            }
        }

        return str1[..prefixLength];
    }
}