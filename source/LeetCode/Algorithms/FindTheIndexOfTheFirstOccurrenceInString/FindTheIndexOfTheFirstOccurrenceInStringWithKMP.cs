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

namespace LeetCode.Algorithms.FindTheIndexOfTheFirstOccurrenceInString;

/// <inheritdoc />
public class FindTheIndexOfTheFirstOccurrenceInStringWithKMP : IFindTheIndexOfTheFirstOccurrenceInString
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(m)
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns></returns>
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        if (string.IsNullOrEmpty(haystack))
        {
            return -1;
        }

        var lps = ComputeLongestPrefixSuffixArray(needle);

        var i = 0;
        var j = 0;

        while (i < haystack.Length)
        {
            if (needle[j] == haystack[i])
            {
                j++;
                i++;
            }

            if (j == needle.Length)
            {
                return i - j;
            }

            if (i >= haystack.Length || needle[j] == haystack[i])
            {
                continue;
            }

            if (j != 0)
            {
                j = lps[j - 1];
            }
            else
            {
                i += 1;
            }
        }

        return -1;
    }

    private static int[] ComputeLongestPrefixSuffixArray(string needle)
    {
        var length = needle.Length;
        var lps = new int[length];

        lps[0] = 0;

        var len = 0;
        var i = 1;

        while (i < length)
        {
            if (needle[i] == needle[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if (len == 0)
                {
                    lps[i] = len;
                    i++;
                }
                else
                {
                    len = lps[len - 1];
                }
            }
        }

        return lps;
    }
}