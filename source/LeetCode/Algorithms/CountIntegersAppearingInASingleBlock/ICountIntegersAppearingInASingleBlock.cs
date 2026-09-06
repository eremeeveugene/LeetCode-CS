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

namespace LeetCode.Algorithms.CountIntegersAppearingInASingleBlock;

/// <summary>
///     https://leetcode.com/problems/count-integers-appearing-in-a-single-block/description/
/// </summary>
public interface ICountIntegersAppearingInASingleBlock
{
    /// <summary>
    ///     Counts distinct integers whose occurrences form a single contiguous block.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <returns>The number of distinct integers appearing in exactly one contiguous block.</returns>
    int CountSpecialIntegers(int[] nums);
}