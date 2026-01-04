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

namespace LeetCode.Algorithms.ConvertIntegerToTheSumOfTwoNoZeroIntegers;

/// <inheritdoc />
public class ConvertIntegerToTheSumOfTwoNoZeroIntegersBruteForce : IConvertIntegerToTheSumOfTwoNoZeroIntegers
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] GetNoZeroIntegers(int n)
    {
        var a = 1;

        while (a < n)
        {
            if (IsNoZero(a) && IsNoZero(n - a))
            {
                break;
            }

            a++;
        }

        return [a, n - a];
    }

    private static bool IsNoZero(int x)
    {
        while (x > 0)
        {
            if (x % 10 == 0)
            {
                return false;
            }

            x /= 10;
        }

        return true;
    }
}