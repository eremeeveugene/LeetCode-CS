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

namespace LeetCode.Algorithms.CheckIfArrayIsSortedAndRotated;

/// <inheritdoc />
public sealed class CheckIfArrayIsSortedAndRotatedIterative : ICheckIfArrayIsSortedAndRotated
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool Check(int[] nums)
    {
        var isRotated = false;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] <= nums[i + 1])
            {
                continue;
            }

            if (isRotated)
            {
                return false;
            }

            isRotated = true;
        }

        if (nums[^1] <= nums[0])
        {
            return true;
        }

        return !isRotated;
    }
}