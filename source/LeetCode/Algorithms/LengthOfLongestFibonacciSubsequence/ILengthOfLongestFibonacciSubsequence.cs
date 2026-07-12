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

namespace LeetCode.Algorithms.LengthOfLongestFibonacciSubsequence;

/// <summary>
///     https://leetcode.com/problems/length-of-longest-fibonacci-subsequence/description/
/// </summary>
public interface ILengthOfLongestFibonacciSubsequence
{
    /// <summary>
    ///     Finds the length of the longest subsequence of the strictly increasing array <paramref name="arr" /> that forms a Fibonacci-like sequence, where each element is the sum of the two preceding ones.
    /// </summary>
    /// <param name="arr">The strictly increasing array of positive integers to search.</param>
    /// <returns>The length of the longest Fibonacci-like subsequence, or <c>0</c> if none exists.</returns>
    int LenLongestFibSubseq(int[] arr);
}