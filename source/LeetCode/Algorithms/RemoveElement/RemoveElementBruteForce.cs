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

namespace LeetCode.Algorithms.RemoveElement;

/// <inheritdoc />
public sealed class RemoveElementBruteForce : IRemoveElement
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(1)
    /// </remarks>
    public int RemoveElement(int[] nums, int val)
    {
        for (var k = 0; k < nums.Length; k++)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    continue;
                }

                for (var j = i; j < nums.Length - 1; j++)
                {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                }
            }
        }

        return nums.Count(num => !num.Equals(val));
    }
}