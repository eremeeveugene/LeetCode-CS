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

namespace LeetCode.Algorithms.ProductOfTheLastKNumbers;

/// <summary>
///     https://leetcode.com/problems/product-of-the-last-k-numbers/description/
/// </summary>
public interface IProductOfTheLastKNumbers
{
    /// <summary>
    ///     Appends <paramref name="num" /> to the running stream of numbers.
    /// </summary>
    /// <param name="num">The number to append to the stream.</param>
    void Add(int num);

    /// <summary>
    ///     Computes the product of the last <paramref name="k" /> numbers added to the stream.
    /// </summary>
    /// <param name="k">The number of most recent elements to multiply together.</param>
    /// <returns>The product of the last <paramref name="k" /> numbers added to the stream.</returns>
    int GetProduct(int k);
}