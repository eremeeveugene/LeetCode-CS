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

namespace LeetCode.Algorithms.FindIfArrayCanBeSorted;

/// <inheritdoc />
public sealed class FindIfArrayCanBeSortedBubbleSort : IFindIfArrayCanBeSorted
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 * log k)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanSortArray(int[] nums)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j] <= nums[j + 1])
                {
                    continue;
                }

                if (GetSetBitsCount(nums[j]) == GetSetBitsCount(nums[j + 1]))
                {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }

    private static int GetSetBitsCount(int number)
    {
        var count = 0;

        while (number > 0)
        {
            count += number & 1;

            number >>= 1;
        }

        return count;
    }
}