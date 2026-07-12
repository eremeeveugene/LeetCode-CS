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

namespace LeetCode.Algorithms.SpecialArray;

/// <inheritdoc />
public sealed class SpecialArrayIterative : ISpecialArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsArraySpecial(int[] nums)
    {
        if (nums.Length == 1)
        {
            return true;
        }

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] % 2 == nums[i + 1] % 2)
            {
                return false;
            }
        }

        return true;
    }
}