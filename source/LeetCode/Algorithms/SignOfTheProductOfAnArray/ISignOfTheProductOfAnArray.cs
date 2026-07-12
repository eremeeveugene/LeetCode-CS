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

namespace LeetCode.Algorithms.SignOfTheProductOfAnArray;

/// <summary>
///     https://leetcode.com/problems/sign-of-the-product-of-an-array/description/
/// </summary>
public interface ISignOfTheProductOfAnArray
{
    /// <summary>
    ///     Determines the sign of the product of all elements in <paramref name="nums" /> without computing the
    ///     product directly.
    /// </summary>
    /// <param name="nums">The array of integers whose product sign is to be determined.</param>
    /// <returns>1 if the product is positive, -1 if negative, or 0 if the product is zero.</returns>
    int ArraySign(int[] nums);
}