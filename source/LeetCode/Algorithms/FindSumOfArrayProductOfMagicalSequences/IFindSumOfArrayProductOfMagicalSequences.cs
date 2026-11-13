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

namespace LeetCode.Algorithms.FindSumOfArrayProductOfMagicalSequences;

/// <summary>
///     https://leetcode.com/problems/find-sum-of-array-product-of-magical-sequences/description/
/// </summary>
public interface IFindSumOfArrayProductOfMagicalSequences
{
    /// <summary>
    ///     Computes the sum of array products over all magical sequences, where a sequence of
    ///     <paramref name="m" /> indices into <paramref name="nums" /> is magical when the binary representation of
    ///     the sum of 2^seq[i] has exactly <paramref name="k" /> set bits, and its array product is the product of
    ///     nums[seq[i]].
    /// </summary>
    /// <param name="m">The length of each sequence.</param>
    /// <param name="k">The required number of set bits in the sum of 2^seq[i].</param>
    /// <param name="nums">The values whose indices form the sequences.</param>
    /// <returns>The sum of the array products of all magical sequences, modulo 10^9 + 7.</returns>
    int MagicalSum(int m, int k, int[] nums);
}