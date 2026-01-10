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

namespace LeetCode.Algorithms.CountOfSubstringsContainingEveryVowelAndKConsonants2;

/// <inheritdoc />
public sealed class CountOfSubstringsContainingEveryVowelAndKConsonants2SlidingWindow :
    ICountOfSubstringsContainingEveryVowelAndKConsonants2
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="word"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long CountOfSubstrings(string word, int k)
    {
        return AtLeastK(word, k) - AtLeastK(word, k + 1);
    }

    private static long AtLeastK(string word, int k)
    {
        long count = 0;

        var start = 0;
        var end = 0;

        var vowelDictionary = new Dictionary<char, int>();
        var consonantCount = 0;

        while (end < word.Length)
        {
            var newLetter = word[end];

            if (IsVowel(newLetter))
            {
                vowelDictionary.TryAdd(newLetter, 0);

                vowelDictionary[newLetter]++;
            }
            else
            {
                consonantCount++;
            }

            while (vowelDictionary.Count == 5 && consonantCount >= k)
            {
                count += word.Length - end;

                var startLetter = word[start];

                if (IsVowel(startLetter))
                {
                    vowelDictionary[startLetter]--;

                    if (vowelDictionary[startLetter] == 0)
                    {
                        vowelDictionary.Remove(startLetter);
                    }
                }
                else
                {
                    consonantCount--;
                }

                start++;
            }

            end++;
        }

        return count;
    }

    private static bool IsVowel(char c)
    {
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}