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

namespace LeetCode.Algorithms.ThirdMaximumNumber;

/// <summary>
///     https://leetcode.com/problems/third-maximum-number/description/
/// </summary>
public interface IThirdMaximumNumber
{
    /// <summary>
    ///     Time complexity - O (n log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    int ThirdMax(int[] nums);
}