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

namespace LeetCode.Algorithms.MajorityElement2;

/// <inheritdoc />
public sealed class MajorityElement2BoyerMooreVoting : IMajorityElement2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> MajorityElement(int[] nums)
    {
        var majorityElement1 = 0;
        var majorityElement2 = 1;
        var majorityElement1Count = 0;
        var majorityElement2Count = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num == majorityElement1)
            {
                majorityElement1Count++;
            }
            else if (num == majorityElement2)
            {
                majorityElement2Count++;
            }
            else if (majorityElement1Count == 0)
            {
                majorityElement1 = num;
                majorityElement1Count++;
            }
            else if (majorityElement2Count == 0)
            {
                majorityElement2 = num;
                majorityElement2Count++;
            }
            else
            {
                majorityElement1Count--;
                majorityElement2Count--;
            }
        }

        majorityElement1Count = 0;
        majorityElement2Count = 0;

        foreach (var num in nums)
        {
            if (num == majorityElement1)
            {
                majorityElement1Count++;
            }
            else if (num == majorityElement2)
            {
                majorityElement2Count++;
            }
        }

        var result = new List<int>(2);
        var threshold = nums.Length / 3;

        if (majorityElement1Count > threshold)
        {
            result.Add(majorityElement1);
        }

        if (majorityElement2Count > threshold)
        {
            result.Add(majorityElement2);
        }

        return result;
    }
}