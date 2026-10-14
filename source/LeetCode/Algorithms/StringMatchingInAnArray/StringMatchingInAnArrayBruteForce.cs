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

namespace LeetCode.Algorithms.StringMatchingInAnArray;

/// <inheritdoc />
public sealed class StringMatchingInAnArrayBruteForce : IStringMatchingInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<string> StringMatching(string[] words)
    {
        var result = new List<string>();

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            for (var j = 0; j < words.Length; j++)
            {
                if (i == j || !words[j].Contains(word))
                {
                    continue;
                }

                result.Add(word);

                break;
            }
        }

        return result;
    }
}