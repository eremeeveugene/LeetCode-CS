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

namespace LeetCode.Algorithms.RichestCustomerWealth;

/// <inheritdoc />
public sealed class RichestCustomerWealthIterative : IRichestCustomerWealth
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaximumWealth(int[][] accounts)
    {
        var maxWealth = 0;

        for (var i = 0; i < accounts.Length; i++)
        {
            var account = accounts[i];

            var wealth = 0;

            for (var j = 0; j < account.Length; j++)
            {
                wealth += account[j];
            }

            maxWealth = Math.Max(maxWealth, wealth);
        }

        return maxWealth;
    }
}