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

namespace LeetCode.Algorithms.MaximizeSumOfAtMostKDistinctElements;

/// <summary>
///     https://leetcode.com/problems/maximize-sum-of-at-most-k-distinct-elements/description/
/// </summary>
public interface IMaximizeSumOfAtMostKDistinctElements
{
    int[] MaxKDistinct(int[] nums, int k);
}