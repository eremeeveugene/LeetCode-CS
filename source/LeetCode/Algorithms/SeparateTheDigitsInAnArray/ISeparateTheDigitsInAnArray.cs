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

namespace LeetCode.Algorithms.SeparateTheDigitsInAnArray;

/// <summary>
///     https://leetcode.com/problems/separate-the-digits-in-an-array/description/
/// </summary>
public interface ISeparateTheDigitsInAnArray
{
    /// <summary>
    ///     Separates each integer in the array into its digits while preserving the original order.
    /// </summary>
    /// <param name="nums">The integer array whose values should be separated into digits.</param>
    /// <returns>An array containing all digits from the input values in their original order.</returns>
    int[] SeparateDigits(int[] nums);
}