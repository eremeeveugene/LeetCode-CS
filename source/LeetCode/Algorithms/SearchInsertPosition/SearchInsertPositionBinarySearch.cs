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

namespace LeetCode.Algorithms.SearchInsertPosition;

/// <summary>
///     https://leetcode.com/problems/search-insert-position/description/
/// </summary>
public static class SearchInsertPositionBinarySearch
{
    /// <summary>
    ///     Time complexity - O (log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int GetResult(int[] nums, int target)
    {
        var index = Array.BinarySearch(nums, target);

        return index < 0 ? ~index : index;
    }
}