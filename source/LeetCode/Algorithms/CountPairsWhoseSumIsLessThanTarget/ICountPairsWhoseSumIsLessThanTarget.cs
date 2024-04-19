﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.CountPairsWhoseSumIsLessThanTarget;

/// <summary>
///     https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/
/// </summary>
public interface ICountPairsWhoseSumIsLessThanTarget
{
    int CountPairs(IList<int> nums, int target);
}