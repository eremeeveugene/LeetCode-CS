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

namespace LeetCode.Algorithms.PartitionArrayIntoThreePartsWithEqualSum;

/// <summary>
///     https://leetcode.com/problems/partition-array-into-three-parts-with-equal-sum/
/// </summary>
public interface IPartitionArrayIntoThreePartsWithEqualSum
{
    /// <summary>
    ///     Determines whether <paramref name="arr" /> can be split into three contiguous, non-empty parts that each have
    ///     the same sum.
    /// </summary>
    /// <param name="arr">The array of integers to evaluate.</param>
    /// <returns><see langword="true" /> if such a partition exists; otherwise, <see langword="false" />.</returns>
    bool CanThreePartsEqualSum(int[] arr);
}