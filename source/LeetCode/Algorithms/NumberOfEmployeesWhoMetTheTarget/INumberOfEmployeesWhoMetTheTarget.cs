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

namespace LeetCode.Algorithms.NumberOfEmployeesWhoMetTheTarget;

/// <summary>
///     https://leetcode.com/problems/number-of-employees-who-met-the-target/description/
/// </summary>
public interface INumberOfEmployeesWhoMetTheTarget
{
    /// <summary>
    ///     Counts how many employees worked at least <paramref name="target" /> hours, given each employee's hours
    ///     worked in <paramref name="hours" />.
    /// </summary>
    /// <param name="hours">The array where each element is the number of hours a specific employee worked.</param>
    /// <param name="target">The minimum number of hours required to meet the target.</param>
    /// <returns>The number of employees who worked at least <paramref name="target" /> hours.</returns>
    int NumberOfEmployeesWhoMetTarget(int[] hours, int target);
}