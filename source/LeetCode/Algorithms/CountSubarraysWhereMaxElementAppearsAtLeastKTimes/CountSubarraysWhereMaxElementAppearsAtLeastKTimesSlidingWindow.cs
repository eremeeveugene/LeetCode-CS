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

namespace LeetCode.Algorithms.CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

/// <inheritdoc />
public class CountSubarraysWhereMaxElementAppearsAtLeastKTimesSlidingWindow :
    ICountSubarraysWhereMaxElementAppearsAtLeastKTimes
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long CountSubarrays(int[] nums, int k)
    {
        var maxElement = nums.Max();

        var count = 0;
        var start = 0;
        var maxElementsInWindow = 0;

        foreach (var num in nums)
        {
            if (num == maxElement)
            {
                maxElementsInWindow++;
            }

            while (k == maxElementsInWindow)
            {
                if (nums[start] == maxElement)
                {
                    maxElementsInWindow--;
                }

                start++;
            }

            count += start;
        }

        return count;
    }
}