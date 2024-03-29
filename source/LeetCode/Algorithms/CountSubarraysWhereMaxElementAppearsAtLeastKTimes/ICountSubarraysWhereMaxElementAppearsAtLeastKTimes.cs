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

namespace LeetCode.Algorithms.CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

/// <summary>
///     https://leetcode.com/problems/count-subarrays-where-max-element-appears-at-least-k-times/description/
/// </summary>
public interface ICountSubarraysWhereMaxElementAppearsAtLeastKTimes
{
    long CountSubarrays(int[] nums, int k);
}