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

namespace LeetCode.Algorithms.RemoveDuplicatesFromSortedArray;

/// <inheritdoc />
public class RemoveDuplicatesFromSortedArrayIterative : IRemoveDuplicatesFromSortedArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RemoveDuplicates(int[] nums)
    {
        var indexToInsert = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                continue;
            }

            nums[indexToInsert] = nums[i];

            indexToInsert++;
        }

        return indexToInsert;
    }
}