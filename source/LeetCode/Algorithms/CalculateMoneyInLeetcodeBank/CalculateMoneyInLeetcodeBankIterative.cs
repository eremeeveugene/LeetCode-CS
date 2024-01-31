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
public class CalculateMoneyInLeetcodeBankIterative : ICalculateMoneyInLeetcodeBank
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int TotalMoney(int n)
    {
        var totalMoney = 0;

        for (var i = 0; i < n; i++)
        {
            totalMoney += (i / 7) + (i % 7) + 1;
        }

        return totalMoney;
    }
}