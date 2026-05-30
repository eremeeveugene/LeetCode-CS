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

namespace LeetCode.Algorithms.AverageSalaryExcludingTheMinimumAndMaximumSalary;

/// <inheritdoc />
public sealed class AverageSalaryExcludingTheMinimumAndMaximumSalaryIterative : IAverageSalaryExcludingTheMinimumAndMaximumSalary
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="salary"></param>
    /// <returns></returns>
    public double Average(int[] salary)
    {
        var min = salary[0];
        var max = salary[0];

        double sum = 0;

        foreach (var item in salary)
        {
            sum += item;

            min = Math.Min(min, item);
            max = Math.Max(max, item);
        }

        return (sum - min - max) / (salary.Length - 2);
    }
}