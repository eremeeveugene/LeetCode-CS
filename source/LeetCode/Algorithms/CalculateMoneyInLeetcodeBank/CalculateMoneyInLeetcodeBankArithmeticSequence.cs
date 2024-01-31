// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.CalculateMoneyInLeetcodeBank;

/// <inheritdoc />
public class CalculateMoneyInLeetcodeBankArithmeticSequence : ICalculateMoneyInLeetcodeBank
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int TotalMoney(int n)
    {
        var fullWeeks = n / 7;
        var remainingDays = n % 7;

        var sumFullWeeks = 0;
        for (var week = 1; week <= fullWeeks; week++)
        {
            sumFullWeeks += 7 * ((2 * week) + ((7 - 1) * 1)) / 2;
        }

        var startAmount = fullWeeks + 1;
        var sumRemainingDays = remainingDays * ((2 * startAmount) + ((remainingDays - 1) * 1)) / 2;

        return sumFullWeeks + sumRemainingDays;
    }
}