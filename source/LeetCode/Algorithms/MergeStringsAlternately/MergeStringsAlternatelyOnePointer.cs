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
public class MergeStringsAlternatelyOnePointer : IMergeStringsAlternately
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
        var resultStringBuilder = new StringBuilder();

        var i = 0;

        while (i < word1.Length || i < word2.Length)
        {
            if (i < word1.Length)
            {
                resultStringBuilder.Append(word1[i]);
            }

            if (i < word2.Length)
            {
                resultStringBuilder.Append(word2[i]);
            }

            i++;
        }

        return resultStringBuilder.ToString();
    }
}