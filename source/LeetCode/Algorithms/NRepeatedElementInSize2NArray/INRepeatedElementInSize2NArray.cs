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

namespace LeetCode.Algorithms.NRepeatedElementInSize2NArray;

/// <summary>
///     https://leetcode.com/problems/n-repeated-element-in-size-2n-array/description/
/// </summary>
public interface INRepeatedElementInSize2NArray
{
    /// <summary>
    ///     Finds the element that is repeated exactly <c>n</c> times in the size-<c>2n</c> array
    ///     <paramref name="nums" />, which otherwise contains distinct values.
    /// </summary>
    /// <param name="nums">The array of size 2n containing n distinct values and one value repeated n times.</param>
    /// <returns>The value that appears n times in <paramref name="nums" />.</returns>
    int RepeatedNTimes(int[] nums);
}