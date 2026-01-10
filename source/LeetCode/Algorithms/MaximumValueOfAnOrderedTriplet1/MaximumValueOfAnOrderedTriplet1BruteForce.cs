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

namespace LeetCode.Algorithms.MaximumValueOfAnOrderedTriplet1;

/// <inheritdoc />
public sealed class MaximumValueOfAnOrderedTriplet1BruteForce : IMaximumValueOfAnOrderedTriplet1
{
    /// <summary>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public long MaximumTripletValue(int[] nums)
    {
        long maximumTripletValue = 0;

        for (var i = 0; i < nums.Length - 2; i++)
        {
            for (var j = i + 1; j < nums.Length - 1; j++)
            {
                for (var k = j + 1; k < nums.Length; k++)
                {
                    var tripletValue = (long)(nums[i] - nums[j]) * nums[k];

                    maximumTripletValue = Math.Max(maximumTripletValue, tripletValue);
                }
            }
        }

        return maximumTripletValue;
    }
}