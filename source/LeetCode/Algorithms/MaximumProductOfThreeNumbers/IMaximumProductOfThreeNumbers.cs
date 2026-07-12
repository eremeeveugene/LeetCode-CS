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

namespace LeetCode.Algorithms.MaximumProductOfThreeNumbers;

/// <summary>
///     https://leetcode.com/problems/maximum-product-of-three-numbers/
/// </summary>
public interface IMaximumProductOfThreeNumbers
{
    /// <summary>
    ///     Finds three numbers in <paramref name="nums" /> whose product is maximum.
    /// </summary>
    /// <param name="nums">The array of integers to pick three numbers from.</param>
    /// <returns>The maximum product of any three numbers in <paramref name="nums" />.</returns>
    int MaximumProduct(int[] nums);
}