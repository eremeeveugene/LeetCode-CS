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

namespace LeetCode.Algorithms.CountSpecialTriplets;

/// <inheritdoc />
public sealed class CountSpecialTripletsDictionary : ICountSpecialTriplets
{
    private const int Modulo = 1_000_000_007;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SpecialTriplets(int[] nums)
    {
        long result = 0;

        var numsLength = nums.Length;

        var rightNumToCountDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (rightNumToCountDictionary.TryAdd(num, 1))
            {
                continue;
            }

            rightNumToCountDictionary[num]++;
        }

        var leftNumToCountDictionary = new Dictionary<int, int>();

        for (var j = 0; j < numsLength; j++)
        {
            var num = nums[j];

            rightNumToCountDictionary[num]--;

            var middle = num * 2;

            long leftCount = leftNumToCountDictionary.GetValueOrDefault(middle, 0);

            if (leftCount != 0)
            {
                long rightCount = rightNumToCountDictionary.GetValueOrDefault(middle, 0);

                if (rightCount != 0)
                {
                    result = (result + (leftCount * rightCount % Modulo)) % Modulo;
                }
            }

            if (leftNumToCountDictionary.TryAdd(num, 1))
            {
                continue;
            }

            leftNumToCountDictionary[num]++;
        }

        return (int)result;
    }
}