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

namespace LeetCode.Algorithms.BinarySubarraysWithSum;

/// <inheritdoc />
public class BinarySubarraysWithSumDictionary : IBinarySubarraysWithSum
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        var sumDictionary = new Dictionary<int, int> { [0] = 1 };

        int currentSum = 0, count = 0;

        foreach (var num in nums)
        {
            currentSum += num;

            if (sumDictionary.ContainsKey(currentSum - goal))
            {
                count += sumDictionary[currentSum - goal];
            }

            if (!sumDictionary.TryAdd(currentSum, 1))
            {
                sumDictionary[currentSum]++;
            }
        }

        return count;
    }
}