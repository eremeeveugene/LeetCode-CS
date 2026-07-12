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

namespace LeetCode.Algorithms.MaxChunksToMakeSorted;

/// <summary>
///     https://leetcode.com/problems/max-chunks-to-make-sorted/description/
/// </summary>
public interface IMaxChunksToMakeSorted
{
    /// <summary>
    ///     Finds the maximum number of chunks that <paramref name="arr" />, a permutation of 0 to n - 1, can be split
    ///     into so that sorting each chunk individually and concatenating them yields a fully sorted array.
    /// </summary>
    /// <param name="arr">The permutation of integers from 0 to n - 1 to split into chunks.</param>
    /// <returns>The maximum number of chunks <paramref name="arr" /> can be split into.</returns>
    int MaxChunksToSorted(int[] arr);
}