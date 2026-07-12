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

namespace LeetCode.Algorithms.TransformedArray;

/// <summary>
///     https://leetcode.com/problems/transformed-array/description/
/// </summary>
public interface ITransformedArray
{
    /// <summary>
    ///     Builds a new array where each element at index <c>i</c> is taken from <paramref name="nums" /> at the
    ///     circular offset given by the value <c>nums[i]</c>.
    /// </summary>
    /// <param name="nums">The array of integers defining the circular offsets to apply.</param>
    /// <returns>The transformed array built by circularly indexing into <paramref name="nums" />.</returns>
    int[] ConstructTransformedArray(int[] nums);
}