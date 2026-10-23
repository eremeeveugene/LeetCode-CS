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

namespace LeetCode.Algorithms.RearrangeArrayByRemovingDistinctValues;

/// <summary>
///     https://leetcode.com/problems/rearrange-array-by-removing-distinct-values/description/
/// </summary>
public interface IRearrangeArrayByRemovingDistinctValues
{
    /// <summary>
    ///     Builds the array formed by repeatedly removing one occurrence of every distinct value in
    ///     <paramref name="nums" /> and appending those values in ascending order.
    /// </summary>
    /// <param name="nums">The array of integers to rearrange.</param>
    /// <returns>The rearranged array.</returns>
    int[] RearrangeArray(int[] nums);
}