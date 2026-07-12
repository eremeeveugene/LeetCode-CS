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

namespace LeetCode.Algorithms.MaximumValueOfAnOrderedTriplet1;

/// <summary>
///     https://leetcode.com/problems/maximum-value-of-an-ordered-triplet-i/description/
/// </summary>
public interface IMaximumValueOfAnOrderedTriplet1
{
    /// <summary>
    ///     Finds indices <c>i &lt; j &lt; k</c> in <paramref name="nums" /> that maximize the value
    ///     <c>(nums[i] - nums[j]) * nums[k]</c>.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>The maximum triplet value, or 0 if every valid triplet yields a non-positive value.</returns>
    long MaximumTripletValue(int[] nums);
}