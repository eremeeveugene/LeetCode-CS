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

namespace LeetCode.Algorithms.CheckIfTwoStringArraysAreEquivalent;

/// <inheritdoc />
public class CheckIfTwoStringArraysAreEquivalentTwoPointers : ICheckIfTwoStringArraysAreEquivalent
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    /// <returns></returns>
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        int wordIndex1 = 0, wordIndex2 = 0, charIndex1 = 0, charIndex2 = 0;

        while (wordIndex1 < word1.Length && wordIndex2 < word2.Length)
        {
            if (word1[wordIndex1][charIndex1] != word2[wordIndex2][charIndex2])
            {
                return false;
            }

            charIndex1++;
            charIndex2++;

            if (charIndex1 == word1[wordIndex1].Length)
            {
                wordIndex1++;
                charIndex1 = 0;
            }

            if (charIndex2 != word2[wordIndex2].Length)
            {
                continue;
            }

            wordIndex2++;
            charIndex2 = 0;
        }

        return wordIndex1 == word1.Length && wordIndex2 == word2.Length;
    }
}