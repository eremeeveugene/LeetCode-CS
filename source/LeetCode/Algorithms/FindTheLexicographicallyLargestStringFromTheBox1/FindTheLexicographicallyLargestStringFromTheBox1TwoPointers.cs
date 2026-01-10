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

namespace LeetCode.Algorithms.FindTheLexicographicallyLargestStringFromTheBox1;

/// <inheritdoc />
public sealed class FindTheLexicographicallyLargestStringFromTheBox1TwoPointers :
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

    private static string GetLastSubstring(string word)
    {
        var i = 0;
        var j = 1;

        while (j < word.Length)
        {
            var k = 0;

            while (j + k < word.Length && word[i + k] == word[j + k])
            {
                k++;
            }

            if (j + k < word.Length && word[i + k] < word[j + k])
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

        return word[i..];
    }
}