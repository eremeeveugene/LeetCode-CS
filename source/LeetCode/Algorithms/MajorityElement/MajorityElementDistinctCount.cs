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

namespace LeetCode.Algorithms.MajorityElement;

/// <inheritdoc />
public sealed class MajorityElementDistinctCount : IMajorityElement
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MajorityElement(int[] nums)
    {
        var result = 0;
        var resultFrequency = 0;

        var distinctNumsHashSet = new HashSet<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            distinctNumsHashSet.Add(nums[i]);
        }

        var distinctNums = new int[distinctNumsHashSet.Count];

        distinctNumsHashSet.CopyTo(distinctNums);

        for (var i = 0; i < distinctNums.Length; i++)
        {
            var distinctNum = distinctNums[i];
            var frequency = 0;

            for (var j = 0; j < nums.Length; j++)
            {
                if (nums[j] == distinctNum)
                {
                    frequency++;
                }
            }

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