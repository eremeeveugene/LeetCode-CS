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

namespace LeetCode.Algorithms.AdjacentIncreasingSubarraysDetection1;

/// <inheritdoc />
public class AdjacentIncreasingSubarraysDetection1Greedy : IAdjacentIncreasingSubarraysDetection1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool HasIncreasingSubarrays(IList<int> nums, int k)
    {
        var n = nums.Count;
        var previousLength = 0;
        var currentLength = 1;
        var requiredRunLength = 2 * k;

        for (var i = 1; i < n; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                currentLength++;
            }
            else
            {
                previousLength = currentLength;

                currentLength = 1;
            }

            if ((previousLength >= k && currentLength >= k) || currentLength >= requiredRunLength)
            {
                return true;
            }
        }

        return false;
    }
}