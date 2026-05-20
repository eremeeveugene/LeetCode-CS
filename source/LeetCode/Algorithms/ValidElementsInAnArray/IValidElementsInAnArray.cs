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

namespace LeetCode.Algorithms.ValidElementsInAnArray;

/// <summary>
///     https://leetcode.com/problems/valid-elements-in-an-array/description/
/// </summary>
public interface IValidElementsInAnArray
{
    /// <summary>
    ///     Finds all valid elements in the integer array.
    /// </summary>
    /// <param name="nums">The integer array whose valid elements should be found.</param>
    /// <returns>The list of valid elements from the array.</returns>
    IList<int> FindValidElements(int[] nums);
}