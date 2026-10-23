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

namespace LeetCode.Algorithms.RearrangeArrayByRemovingDistinctValues;

/// <inheritdoc />
public sealed class RearrangeArrayByRemovingDistinctValuesBruteForce : IRearrangeArrayByRemovingDistinctValues
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] RearrangeArray(int[] nums)
    {
        var n = nums.Length;

        var remainingNums = new List<int>(nums);

        var result = new int[n];

        var resultIndex = 0;

        while (remainingNums.Count > 0)
        {
            var distinctValues = new List<int>();

            for (var i = 0; i < remainingNums.Count; i++)
            {
                var num = remainingNums[i];

                if (!distinctValues.Contains(num))
                {
                    distinctValues.Add(num);
                }
            }

            distinctValues.Sort();

            for (var i = 0; i < distinctValues.Count; i++)
            {
                var distinctValue = distinctValues[i];

                remainingNums.Remove(distinctValue);

                result[resultIndex] = distinctValue;

                resultIndex++;
            }
        }

        return result;
    }
}