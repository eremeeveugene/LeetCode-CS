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

namespace LeetCode.Algorithms.TupleWithSameProduct;

/// <summary>
///     https://leetcode.com/problems/tuple-with-same-product/description/
/// </summary>
public interface ITupleWithSameProduct
{
    /// <summary>
    ///     Counts the number of ordered tuples <c>(a, b, c, d)</c> of distinct elements from
    ///     <paramref name="nums" /> such that <c>a * b == c * d</c>.
    /// </summary>
    /// <param name="nums">The array of distinct positive integers to search for equal-product tuples in.</param>
    /// <returns>The number of valid tuples <c>(a, b, c, d)</c>.</returns>
    int TupleSameProduct(int[] nums);
}