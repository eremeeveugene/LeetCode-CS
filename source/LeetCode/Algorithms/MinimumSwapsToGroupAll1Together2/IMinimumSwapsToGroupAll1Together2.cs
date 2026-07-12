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

namespace LeetCode.Algorithms.MinimumSwapsToGroupAll1Together2;

/// <summary>
///     https://leetcode.com/problems/minimum-swaps-to-group-all-1s-together-ii/description/
/// </summary>
public interface IMinimumSwapsToGroupAll1Together2
{
    /// <summary>
    ///     Finds the minimum number of swaps required to group all the 1s present in the circular binary array
    ///     <paramref name="nums" /> together in any location.
    /// </summary>
    /// <param name="nums">The circular binary array of 0s and 1s.</param>
    /// <returns>The minimum number of swaps needed to group all the 1s together.</returns>
    int MinSwaps(int[] nums);
}