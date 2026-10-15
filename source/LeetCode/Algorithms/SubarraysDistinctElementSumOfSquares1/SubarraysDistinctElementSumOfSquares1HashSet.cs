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

namespace LeetCode.Algorithms.SubarraysDistinctElementSumOfSquares1;

/// <inheritdoc />
public sealed class SubarraysDistinctElementSumOfSquares1HashSet : ISubarraysDistinctElementSumOfSquares1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </remarks>
    public int SumCounts(IList<int> nums)
    {
        var n = nums.Count;

        var seen = new HashSet<int>();

        var sum = 0;

        for (var i = 0; i < n; i++)
        {
            seen.Clear();

            for (var j = i; j < n; j++)
            {
                var num = nums[j];

                seen.Add(num);

                sum += seen.Count * seen.Count;
            }
        }

        return sum;
    }
}