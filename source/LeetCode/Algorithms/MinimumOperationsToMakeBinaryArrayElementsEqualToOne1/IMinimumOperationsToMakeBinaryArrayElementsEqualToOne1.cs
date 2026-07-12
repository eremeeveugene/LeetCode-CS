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

namespace LeetCode.Algorithms.MinimumOperationsToMakeBinaryArrayElementsEqualToOne1;

/// <summary>
///     https://leetcode.com/problems/minimum-operations-to-make-binary-array-elements-equal-to-one-i/description/
/// </summary>
public interface IMinimumOperationsToMakeBinaryArrayElementsEqualToOne1
{
    /// <summary>
    ///     Finds the minimum number of operations needed to make every element of the binary array
    ///     <paramref name="nums" /> equal to 1, where each operation flips any three consecutive elements.
    /// </summary>
    /// <param name="nums">The binary array of 0s and 1s to convert to all ones.</param>
    /// <returns>The minimum number of operations required, or -1 if it is not possible.</returns>
    int MinOperations(int[] nums);
}