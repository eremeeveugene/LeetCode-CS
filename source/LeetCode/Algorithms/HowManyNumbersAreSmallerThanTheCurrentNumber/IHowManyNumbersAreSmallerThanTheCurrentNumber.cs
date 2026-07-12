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

namespace LeetCode.Algorithms.HowManyNumbersAreSmallerThanTheCurrentNumber;

/// <summary>
///     https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/description/
/// </summary>
public interface IHowManyNumbersAreSmallerThanTheCurrentNumber
{
    /// <summary>
    ///     Counts, for each element of <paramref name="nums" />, how many other elements of the array are smaller than it.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>An array where each element is the number of other elements smaller than the corresponding element.</returns>
    int[] SmallerNumbersThanCurrent(int[] nums);
}