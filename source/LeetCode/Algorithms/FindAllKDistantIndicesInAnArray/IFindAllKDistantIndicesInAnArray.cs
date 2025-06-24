// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindAllKDistantIndicesInAnArray;

/// <summary>
///     https://leetcode.com/problems/find-all-k-distant-indices-in-an-array/description/
/// </summary>
public interface IFindAllKDistantIndicesInAnArray
{
    IList<int> FindKDistantIndices(int[] nums, int key, int k);
}