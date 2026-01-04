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

namespace LeetCode.Algorithms.CheckDivisibilityByDigitSumAndProduct;

/// <inheritdoc />
public class CheckDivisibilityByDigitSumAndProductIterative : ICheckDivisibilityByDigitSumAndProduct
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool CheckDivisibility(int n)
    {
        var digitSum = 0;
        var digitProduct = 1;

        var number = n;

        while (number > 0)
        {
            var digit = number % 10;

            digitSum += digit;
            digitProduct *= digit;

            number /= 10;
        }

        return n % (digitSum + digitProduct) == 0;
    }
}