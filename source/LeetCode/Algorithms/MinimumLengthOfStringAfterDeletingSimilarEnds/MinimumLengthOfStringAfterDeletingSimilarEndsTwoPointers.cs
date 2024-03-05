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

namespace LeetCode.Algorithms.MinimumLengthOfStringAfterDeletingSimilarEnds;

/// <inheritdoc />
public class MinimumLengthOfStringAfterDeletingSimilarEndsTwoPointers : IMinimumLengthOfStringAfterDeletingSimilarEnds
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MinimumLength(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right && s[left] == s[right])
        {
            var currentChar = s[left];

            while (left <= right && s[left] == currentChar)
            {
                left++;
            }

            while (left <= right && s[right] == currentChar)
            {
                right--;
            }
        }

        return Math.Max(right - left + 1, 0);
    }
}