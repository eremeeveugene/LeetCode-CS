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

namespace LeetCode.Algorithms.CountTripletsThatCanFormTwoArraysOfEqualXOR;

/// <summary>
///     https://leetcode.com/problems/count-triplets-that-can-form-two-arrays-of-equal-xor/
/// </summary>
public interface ICountTripletsThatCanFormTwoArraysOfEqualXOR
{
    /// <summary>
    ///     Counts the triplets of indices (i, j, k) in <paramref name="arr" /> such that the XOR of the elements from
    ///     i to j-1 equals the XOR of the elements from j to k.
    /// </summary>
    /// <param name="arr">The array of integers to examine.</param>
    /// <returns>The total number of qualifying triplets.</returns>
    int CountTriplets(int[] arr);
}