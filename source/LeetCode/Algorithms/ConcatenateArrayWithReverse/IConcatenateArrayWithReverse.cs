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

namespace LeetCode.Algorithms.ConcatenateArrayWithReverse;

/// <summary>
///     https://leetcode.com/problems/concatenate-array-with-reverse/description/
/// </summary>
public interface IConcatenateArrayWithReverse
{
    /// <summary>
    ///     Concatenates the array with its reversed version.
    /// </summary>
    /// <param name="nums">The integer array to concatenate with its reverse.</param>
    /// <returns>An array containing the original values followed by the same values in reverse order.</returns>
    int[] ConcatWithReverse(int[] nums);
}