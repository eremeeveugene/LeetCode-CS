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

namespace LeetCode.Algorithms.FindSmallestLetterGreaterThanTarget;

/// <summary>
///     https://leetcode.com/problems/find-smallest-letter-greater-than-target/description/
/// </summary>
public interface IFindSmallestLetterGreaterThanTarget
{
    /// <summary>
    ///     Finds the smallest character in the sorted array <paramref name="letters" /> that is lexicographically greater than <paramref name="target" />,
    ///     wrapping around to the first letter if none is greater.
    /// </summary>
    /// <param name="letters">The sorted array of characters to search.</param>
    /// <param name="target">The character to compare against.</param>
    /// <returns>The smallest character greater than <paramref name="target" />.</returns>
    char NextGreatestLetter(char[] letters, char target);
}