// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindThePowerOfKSizeSubarrays1;

/// <inheritdoc />
public class FindThePowerOfKSizeSubarrays1ConsecutiveCount : IFindThePowerOfKSizeSubarrays1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int[] ResultsArray(int[] nums, int k)
    {
        if (k == 1)
        {
            return nums;
        }

        var result = new int[nums.Length - k + 1];

        Array.Fill(result, -1);

        var consecutiveCount = 1;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] + 1 == nums[i + 1])
            {
                consecutiveCount++;
            }
            else
            {
                consecutiveCount = 1;
            }

            if (consecutiveCount >= k)
            {
                result[i - k + 2] = nums[i + 1];
            }
        }

        return result;
    }
}