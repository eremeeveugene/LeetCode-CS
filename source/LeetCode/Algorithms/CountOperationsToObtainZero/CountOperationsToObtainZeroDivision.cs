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

namespace LeetCode.Algorithms.CountOperationsToObtainZero;

/// <inheritdoc />
public sealed class CountOperationsToObtainZeroDivision : ICountOperationsToObtainZero
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log(min(num1, num2)))
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountOperations(int num1, int num2)
    {
        if (num1 == 0 || num2 == 0)
        {
            return 0;
        }

        if (num1 == num2)
        {
            return 1;
        }

        var count = 0;

        while (num1 != 0 && num2 != 0)
        {
            if (num1 > num2)
            {
                count += num1 / num2;

                num1 %= num2;
            }
            else
            {
                count += num2 / num1;

                num2 %= num1;
            }
        }

        return count;
    }
}