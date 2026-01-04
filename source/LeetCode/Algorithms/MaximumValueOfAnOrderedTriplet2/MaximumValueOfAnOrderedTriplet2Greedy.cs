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

namespace LeetCode.Algorithms.MaximumValueOfAnOrderedTriplet2;

/// <inheritdoc />
public class MaximumValueOfAnOrderedTriplet2Greedy : IMaximumValueOfAnOrderedTriplet2
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public long MaximumTripletValue(int[] nums)
    {
        long maximumTripletValue = 0;

        var maxI = 0;
        long maxDifference = 0;

        foreach (var num in nums)
        {
            maximumTripletValue = Math.Max(maximumTripletValue, maxDifference * num);

            maxDifference = Math.Max(maxDifference, maxI - num);
            maxI = Math.Max(maxI, num);
        }

        return maximumTripletValue;
    }
}