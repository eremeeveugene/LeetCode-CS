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

namespace LeetCode.Algorithms.DistributeMoneyToMaximumChildren;

/// <summary>
///     https://leetcode.com/problems/distribute-money-to-maximum-children/
/// </summary>
public interface IDistributeMoneyToMaximumChildren
{
    /// <summary>
    ///     Distributes <paramref name="money" /> dollars among <paramref name="children" /> children so that each child
    ///     receives a whole positive dollar amount, no child receives exactly 4, and the number of children receiving
    ///     exactly 8 dollars is maximized.
    /// </summary>
    /// <param name="money">The total amount of money, in dollars, to distribute.</param>
    /// <param name="children">The number of children the money must be distributed among.</param>
    /// <returns>The maximum number of children that can receive exactly 8 dollars, or -1 if no valid distribution exists.</returns>
    int DistMoney(int money, int children);
}