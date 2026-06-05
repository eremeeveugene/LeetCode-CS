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

namespace LeetCode.Algorithms.CountTheNumberOfSpecialCharacters1;

/// <inheritdoc />
public sealed class CountTheNumberOfSpecialCharacters1HashSet : ICountTheNumberOfSpecialCharacters1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumberOfSpecialChars(string word)
    {
        var lowerCaseHashSet = new HashSet<char>();
        var upperCaseHashSet = new HashSet<char>();
        var countedHashSet = new HashSet<char>();

        var result = 0;

        for (var i = 0; i < word.Length; i++)
        {
            var c = word[i];

            if (char.IsLower(c))
            {
                lowerCaseHashSet.Add(c);

                if (upperCaseHashSet.Contains(c) && countedHashSet.Add(c))
                {
                    result++;
                }
            }
            else
            {
                var lowerCaseChar = char.ToLower(c);

                upperCaseHashSet.Add(lowerCaseChar);

                if (lowerCaseHashSet.Contains(lowerCaseChar) && countedHashSet.Add(lowerCaseChar))
                {
                    result++;
                }
            }
        }

        return result;
    }
}