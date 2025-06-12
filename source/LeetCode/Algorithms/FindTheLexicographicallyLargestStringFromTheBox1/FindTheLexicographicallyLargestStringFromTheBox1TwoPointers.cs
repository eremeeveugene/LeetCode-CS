// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindTheLexicographicallyLargestStringFromTheBox1;

/// <inheritdoc />
public class FindTheLexicographicallyLargestStringFromTheBox1TwoPointers :
    IFindTheLexicographicallyLargestStringFromTheBox1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="word"></param>
    /// <param name="numFriends"></param>
    /// <returns></returns>
    public string AnswerString(string word, int numFriends)
    {
        if (numFriends == 1)
        {
            return word;
        }

        var lastSubstring = GetLastSubstring(word);

        return lastSubstring[..Math.Min(lastSubstring.Length, word.Length - numFriends + 1)];
    }

    private static string GetLastSubstring(string s)
    {
        var i = 0;
        var j = 1;

        while (j < s.Length)
        {
            var k = 0;

            while (j + k < s.Length && s[i + k] == s[j + k])
            {
                k++;
            }

            if (j + k < s.Length && s[i + k] < s[j + k])
            {
                var t = i;

                i = j;

                j = Math.Max(j + 1, t + k + 1);
            }
            else
            {
                j = j + k + 1;
            }
        }

        return s[i..];
    }
}