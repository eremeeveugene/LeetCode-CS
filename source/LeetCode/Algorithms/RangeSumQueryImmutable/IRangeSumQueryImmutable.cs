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

namespace LeetCode.Algorithms.RangeSumQueryImmutable;

/// <summary>
///     https://leetcode.com/problems/range-sum-query-immutable/
/// </summary>
public interface IRangeSumQueryImmutable
{
    /// <summary>
    ///     Computes the sum of the elements between indices <paramref name="left" /> and <paramref name="right" />,
    ///     inclusive, of the underlying immutable array.
    /// </summary>
    /// <param name="left">The starting index of the range, inclusive.</param>
    /// <param name="right">The ending index of the range, inclusive.</param>
    /// <returns>The sum of the elements within the given index range.</returns>
    int SumRange(int left, int right);
}