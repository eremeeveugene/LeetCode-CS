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

namespace LeetCode.Algorithms.SentenceSimilarity3;

/// <inheritdoc />
public class SentenceSimilarity3TwoPointers : ISentenceSimilarity3
{
    /// <summary>
    ///     Time complexity - O(min(n, m))
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="sentence1"></param>
    /// <param name="sentence2"></param>
    /// <returns></returns>
    public bool AreSentencesSimilar(string sentence1, string sentence2)
    {
        var sentence1Words = sentence1.Split(' ');
        var sentence2Words = sentence2.Split(' ');

        var sentence1Left = 0;
        var sentence1Right = sentence1Words.Length - 1;

        var sentence2Left = 0;
        var sentence2Right = sentence2Words.Length - 1;

        while (sentence1Left <= sentence1Right && sentence2Left <= sentence2Right)
        {
            var word1Left = sentence1Words[sentence1Left];
            var word1Right = sentence1Words[sentence1Right];

            var word2Left = sentence2Words[sentence2Left];
            var word2Right = sentence2Words[sentence2Right];

            if (word1Left == word2Left)
            {
                sentence1Left++;
                sentence2Left++;
            }
            else if (word1Right == word2Right)
            {
                sentence1Right--;
                sentence2Right--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}