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

namespace LeetCode.Algorithms.FindTriangularSumOfAnArray;

/// <summary>
///     https://leetcode.com/problems/find-triangular-sum-of-an-array/description/
/// </summary>
public interface IFindTriangularSumOfAnArray
{
    /// <summary>
    ///     Computes the triangular sum of <paramref name="nums" /> by repeatedly replacing the array with the sums of
    ///     adjacent elements modulo 10 until a single element remains.
    /// </summary>
    /// <param name="nums">The array of digits.</param>
    /// <returns>The triangular sum of <paramref name="nums" />.</returns>
    int TriangularSum(int[] nums);
}