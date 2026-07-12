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

namespace LeetCode.Algorithms.SelfDividingNumbers;

/// <inheritdoc />
public sealed class SelfDividingNumbersMath : ISelfDividingNumbers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * d), where n is range size and d is digit count
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        var result = new List<int>();

        for (var number = left; number <= right; number++)
        {
            if (IsSelfDividing(number))
            {
                result.Add(number);
            }
        }

        return result;
    }

    private static bool IsSelfDividing(int number)
    {
        var temp = number;

        while (temp > 0)
        {
            var digit = temp % 10;

            if (digit == 0)
            {
                return false;
            }

            if (number % digit != 0)
            {
                return false;
            }

            temp /= 10;
        }

        return true;
    }
}