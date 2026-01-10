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
public sealed class FindIfArrayCanBeSortedTwoPass : IFindIfArrayCanBeSorted
{
    /// <summary>
    ///     Time complexity - O(n log k)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool CanSortArray(int[] nums)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] <= nums[i + 1])
            {
                continue;
            }

            if (GetSetBitsCount(nums[i]) == GetSetBitsCount(nums[i + 1]))
            {
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
            }
            else
            {
                return false;
            }
        }

        for (var i = nums.Length - 1; i >= 1; i--)
        {
            if (nums[i] >= nums[i - 1])
            {
                continue;
            }

            if (GetSetBitsCount(nums[i]) == GetSetBitsCount(nums[i - 1]))
            {
                (nums[i], nums[i - 1]) = (nums[i - 1], nums[i]);
            }
            else
            {
                return false;
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