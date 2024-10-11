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

using System.Text;

namespace LeetCode.Algorithms.MergeStringsAlternately;

/// <inheritdoc />
public class MergeStringsAlternatelyTwoPointers : IMergeStringsAlternately
{
    /// <summary>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    /// <returns></returns>
    public string MergeAlternately(string word1, string word2)
    {
        var word1Index = 0;
        var word2Index = 0;

        var resultStringBuilder = new StringBuilder();

        while (word1Index < word1.Length || word2Index < word2.Length)
        {
            if (word1Index < word1.Length)
            {
                resultStringBuilder.Append(word1[word1Index]);

                word1Index++;
            }

            if (word2Index < word2.Length)
            {
                resultStringBuilder.Append(word2[word2Index]);

                word2Index++;
            }
        }

        return resultStringBuilder.ToString();
    }
}