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

/// <inheritdoc />
public sealed class NumberOfEmployeesWhoMetTheTargetCounting : INumberOfEmployeesWhoMetTheTarget
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        var result = 0;

        for (var i = 0; i < hours.Length; i++)
        {
            var hour = hours[i];

            if (hour < target)
            {
                continue;
            }

            result++;
        }

        return result;
    }
}