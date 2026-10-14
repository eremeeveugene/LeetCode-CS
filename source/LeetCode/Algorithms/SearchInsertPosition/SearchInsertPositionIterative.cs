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

namespace LeetCode.Algorithms.SearchInsertPosition;

/// <inheritdoc />
public sealed class SearchInsertPositionIterative : ISearchInsertPosition
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SearchInsert(int[] nums, int target)
    {
        var count = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num >= target)
            {
                break;
            }

            count++;
        }

        return count;
    }
}