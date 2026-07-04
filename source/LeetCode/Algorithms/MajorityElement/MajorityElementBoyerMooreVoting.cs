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

namespace LeetCode.Algorithms.MajorityElement;

/// <inheritdoc />
public sealed class MajorityElementBoyerMooreVoting : IMajorityElement
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MajorityElement(int[] nums)
    {
        var n = nums.Length;

        var majorityElement = 0;
        var count = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (count == 0)
            {
                majorityElement = num;

                count++;

                continue;
            }

            if (num == majorityElement)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return majorityElement;
    }
}