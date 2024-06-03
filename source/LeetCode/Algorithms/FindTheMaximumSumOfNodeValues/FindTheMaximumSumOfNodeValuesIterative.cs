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

namespace LeetCode.Algorithms.FindTheMaximumSumOfNodeValues;

/// <inheritdoc />
public class FindTheMaximumSumOfNodeValuesIterative : IFindTheMaximumSumOfNodeValues
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <param name="edges"></param>
    /// <returns></returns>
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        long sum = 0;

        long min = int.MaxValue;

        var count = 0;

        foreach (var num in nums)
        {
            if ((num ^ k) > num)
            {
                sum += num ^ k;

                min = Math.Min(min, (num ^ k) - num);

                count++;
            }
            else
            {
                sum += num;

                min = Math.Min(min, num - (num ^ k));
            }
        }

        return count % 2 == 0 ? sum : sum - min;
    }
}