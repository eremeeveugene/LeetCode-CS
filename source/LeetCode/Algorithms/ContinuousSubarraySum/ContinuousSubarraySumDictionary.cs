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

namespace LeetCode.Algorithms.ContinuousSubarraySum;

/// <inheritdoc />
public class ContinuousSubarraySumDictionary : IContinuousSubarraySum
{
    /// <summary>
    ///     Time complexity - O(n), where n is the length of the input array nums
    ///     Space complexity - O(min(n,k)), where n is the length of the input array nums and k is the number of possible
    ///     remainders when taking modulo k
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool CheckSubarraySum(int[] nums, int k)
    {
        var remainderDictionary = new Dictionary<int, int> { [0] = -1 };

        var sum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (k != 0)
            {
                sum %= k;
            }

            if (remainderDictionary.TryAdd(sum, i))
            {
                continue;
            }

            if (i - remainderDictionary[sum] > 1)
            {
                return true;
            }
        }

        return false;
    }
}