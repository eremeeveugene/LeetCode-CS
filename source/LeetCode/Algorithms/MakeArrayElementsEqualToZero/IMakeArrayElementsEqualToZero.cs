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

namespace LeetCode.Algorithms.MakeArrayElementsEqualToZero;

/// <summary>
///     https://leetcode.com/problems/make-array-elements-equal-to-zero/description/
/// </summary>
public interface IMakeArrayElementsEqualToZero
{
    /// <summary>
    ///     Counts the number of valid starting positions and directions from which a simulated pointer, moving through
    ///     <paramref name="nums" /> and decrementing non-zero values it lands on, ends up making all elements zero.
    /// </summary>
    /// <param name="nums">The array of non-negative integers to simulate the pointer traversal over.</param>
    /// <returns>The number of (position, direction) selections that result in all elements of <paramref name="nums" /> becoming zero.</returns>
    int CountValidSelections(int[] nums);
}