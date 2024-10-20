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

namespace LeetCode.Algorithms.SmallestRangeCoveringElementsFromKLists;

/// <summary>
///     https://leetcode.com/problems/smallest-range-covering-elements-from-k-lists/description/
/// </summary>
public interface ISmallestRangeCoveringElementsFromKLists
{
    int[] SmallestRange(IList<IList<int>> nums);
}