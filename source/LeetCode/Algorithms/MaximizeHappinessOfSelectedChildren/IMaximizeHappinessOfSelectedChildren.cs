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

namespace LeetCode.Algorithms.MaximizeHappinessOfSelectedChildren;

/// <summary>
///     https://leetcode.com/problems/maximize-happiness-of-selected-children/description/
/// </summary>
public interface IMaximizeHappinessOfSelectedChildren
{
    /// <summary>
    ///     Selects <paramref name="k" /> children from <paramref name="happiness" /> one at a time, decrementing the
    ///     happiness value of every remaining child by 1 (not below 0) after each selection, to maximize the sum of the
    ///     selected children's happiness values.
    /// </summary>
    /// <param name="happiness">The array of happiness values of the children.</param>
    /// <param name="k">The number of children to select.</param>
    /// <returns>The maximum possible sum of the happiness values of the selected children.</returns>
    long MaximumHappinessSum(int[] happiness, int k);
}