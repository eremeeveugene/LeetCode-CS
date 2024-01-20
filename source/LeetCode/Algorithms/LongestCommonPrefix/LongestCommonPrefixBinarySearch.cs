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

public class LongestCommonPrefixBinarySearch
{
    /// <summary>
    ///     Time complexity - O(S log n), where S is the sum of all characters in all strings
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public string LongestCommonPrefix(string[] strs)
    {
        var minLength = strs.Min(s => s.Length);
        var low = 1;
        var high = minLength;

        while (low <= high)
        {
            var middle = (low + high) / 2;

            if (IsCommonPrefix(strs, middle))
            {
                low = middle + 1;
            }
            else
            {
                high = middle - 1;
            }
        }

        var longestPrefixIndex = (low + high) / 2;

        return strs[0][..longestPrefixIndex];
    }

    private bool IsCommonPrefix(IReadOnlyList<string> strs, int length)
    {
        var str1 = strs[0][..length];
        for (var i = 1; i < strs.Count; i++)
        {
            if (!strs[i].StartsWith(str1))
            {
                return false;
            }
        }

        return true;
    }
}