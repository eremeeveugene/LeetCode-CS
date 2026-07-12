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

namespace LeetCode.Algorithms.CountLargestGroup;

/// <summary>
///     https://leetcode.com/problems/count-largest-group/description/
/// </summary>
public interface ICountLargestGroup
{
    /// <summary>
    ///     Groups the numbers from 1 to <paramref name="n" /> by the sum of their digits and counts how many groups have
    ///     the largest size.
    /// </summary>
    /// <param name="n">The upper bound of the range of numbers to group.</param>
    /// <returns>The number of groups with the largest size.</returns>
    int CountLargestGroup(int n);
}