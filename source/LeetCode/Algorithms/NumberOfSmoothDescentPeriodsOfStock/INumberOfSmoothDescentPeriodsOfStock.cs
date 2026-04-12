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

namespace LeetCode.Algorithms.NumberOfSmoothDescentPeriodsOfStock;

/// <summary>
///     https://leetcode.com/problems/number-of-smooth-descent-periods-of-a-stock/description/
/// </summary>
public interface INumberOfSmoothDescentPeriodsOfStock
{
    long GetDescentPeriods(int[] prices);
}