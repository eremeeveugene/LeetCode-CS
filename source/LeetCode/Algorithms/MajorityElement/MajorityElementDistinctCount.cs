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

namespace LeetCode.Algorithms.MajorityElement;

/// <inheritdoc />
public class MajorityElementDistinctCount : IMajorityElement
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MajorityElement(int[] nums)
    {
        var result = 0;
        var resultFrequency = 0;

        foreach (var distinctNum in nums.Distinct())
        {
            var frequency = nums.Count(num => num.Equals(distinctNum));

            if (frequency <= resultFrequency)
            {
                continue;
            }

            resultFrequency = frequency;
            result = distinctNum;
        }

        return result;
    }
}