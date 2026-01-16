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

namespace LeetCode.Algorithms.SplitStringsBySeparator;

/// <inheritdoc />
public sealed class SplitStringsBySeparatorIterative : ISplitStringsBySeparator
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="words"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
    {
        var result = new List<string>();

        foreach (var word in words)
        {
            var span = word.AsSpan();

            var wordStart = 0;

            for (var i = 0; i < span.Length; i++)
            {
                var c = span[i];

                if (c != separator)
                {
                    continue;
                }

                var wordLength = i - wordStart;

                if (wordLength > 0)
                {
                    result.Add(span[wordStart..i].ToString());
                }

                wordStart = i + 1;
            }

            if (wordStart < word.Length)
            {
                result.Add(word[wordStart..]);
            }
        }

        return result;
    }
}