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

namespace LeetCode.Algorithms.MaximumAveragePassRatio;

/// <summary>
///     https://leetcode.com/problems/maximum-average-pass-ratio/description/
/// </summary>
public interface IMaximumAveragePassRatio
{
    /// <summary>
    ///     Distributes <paramref name="extraStudents" /> guaranteed-to-pass students among <paramref name="classes" />
    ///     to maximize the average pass ratio across all classes.
    /// </summary>
    /// <param name="classes">The array of classes, where each element is a [passCount, totalCount] pair.</param>
    /// <param name="extraStudents">The number of extra students, each guaranteed to pass, to distribute among the classes.</param>
    /// <returns>The maximum possible average pass ratio across all classes after distributing the extra students.</returns>
    double MaxAverageRatio(int[][] classes, int extraStudents);
}