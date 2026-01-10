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

namespace LeetCode.Algorithms.LargestNumberAtLeastTwiceOfOthers;

/// <inheritdoc />
public sealed class LargestNumberAtLeastTwiceOfOthersIterative : ILargestNumberAtLeastTwiceOfOthers
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int DominantIndex(int[] nums)
    {
        var maxIndex = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= nums[maxIndex])
            {
                continue;
            }

            maxIndex = i;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (i == maxIndex)
            {
                continue;
            }

            if (nums[i] * 2 > nums[maxIndex])
            {
                return -1;
            }
        }

        return maxIndex;
    }
}