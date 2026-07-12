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

namespace LeetCode.Algorithms.MaximizeExpressionOfThreeElements;

/// <summary>
///     https://leetcode.com/problems/maximize-expression-of-three-elements/description/
/// </summary>
public interface IMaximizeExpressionOfThreeElements
{
    /// <summary>
    ///     Finds three distinct indices in <paramref name="nums" /> that maximize the expression
    ///     (nums[i] - nums[j]) + (nums[j] - nums[k]) + (nums[k] - nums[i]).
    /// </summary>
    /// <param name="nums">The array of integers to choose three indices from.</param>
    /// <returns>The maximum possible value of the expression over all triples of distinct indices.</returns>
    int MaximizeExpressionOfThree(int[] nums);
}