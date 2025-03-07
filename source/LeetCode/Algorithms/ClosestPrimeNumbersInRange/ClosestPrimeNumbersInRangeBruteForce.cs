// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.ClosestPrimeNumbersInRange;

/// <inheritdoc />
public class ClosestPrimeNumbersInRangeBruteForce : IClosestPrimeNumbersInRange
{
    /// <summary>
    ///     Time complexity - O((R−L) * sqrt(R))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public int[] ClosestPrimes(int left, int right)
    {
        var minNum1 = 0;
        var minNum2 = int.MaxValue;
        var num1 = -1;
        var num2 = -1;

        for (var num = left; num <= right; num++)
        {
            if (!IsPrime(num))
            {
                continue;
            }

            num1 = num2;
            num2 = num;

            if (minNum2 - minNum1 > num2 - num1)
            {
                minNum1 = num1;
                minNum2 = num2;
            }

            if (minNum2 - minNum1 == 2)
            {
                break;
            }
        }

        if (num1 <= 0 || num2 <= 0)
        {
            return [-1, -1];
        }

        return [minNum1, minNum2];
    }

    private static bool IsPrime(int num)
    {
        switch (num)
        {
            case <= 1:
                return false;
            case 2 or 3:
                return true;
        }

        if (num % 2 == 0)
        {
            return false;
        }

        for (var i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}