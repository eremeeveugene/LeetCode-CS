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

namespace LeetCode.Algorithms.CountElementsWithStrictlySmallerAndGreaterElements;

/// <summary>
///     https://leetcode.com/problems/count-elements-with-strictly-smaller-and-greater-elements/description/
/// </summary>
public interface ICountElementsWithStrictlySmallerAndGreaterElements
{
    /// <summary>
    ///     Counts the elements of <paramref name="nums" /> that have both a strictly smaller and a strictly greater element
    ///     in the array.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The number of elements with both a strictly smaller and a strictly greater element.</returns>
    int CountElements(int[] nums);
}