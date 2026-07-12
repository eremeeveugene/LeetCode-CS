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

namespace LeetCode.Algorithms.MoveZeroes;

/// <summary>
///     https://leetcode.com/problems/move-zeroes/
/// </summary>
public interface IMoveZeroes
{
    /// <summary>
    ///     Moves all zeroes in <paramref name="nums" /> to the end of the array in place while maintaining the
    ///     relative order of the non-zero elements.
    /// </summary>
    /// <param name="nums">The array of integers to rearrange in place.</param>
    void MoveZeroes(int[] nums);
}