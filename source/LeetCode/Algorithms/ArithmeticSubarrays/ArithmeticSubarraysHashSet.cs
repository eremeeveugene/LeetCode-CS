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

namespace LeetCode.Algorithms.ArithmeticSubarrays;

/// <inheritdoc />
public class ArithmeticSubarraysHashSet : IArithmeticSubarrays
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="l"></param>
    /// <param name="r"></param>
    /// <returns></returns>
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var result = new bool[l.Length];

        for (var i = 0; i < l.Length; i++)
        {
            int start = l[i], end = r[i];
            int minVal = int.MaxValue, maxVal = int.MinValue;
            var elements = new HashSet<int>();

            for (var j = start; j <= end; j++)
            {
                minVal = Math.Min(minVal, nums[j]);
                maxVal = Math.Max(maxVal, nums[j]);
                elements.Add(nums[j]);
            }

            var subArrayLength = end - start + 1;

            if (subArrayLength < 2 || (maxVal - minVal) % (subArrayLength - 1) != 0)
            {
                result[i] = false;

                continue;
            }

            var diff = (maxVal - minVal) / (subArrayLength - 1);
            var isArithmetic = true;

            for (var j = 0; j < subArrayLength; j++)
            {
                if (elements.Contains(minVal + (j * diff)))
                {
                    continue;
                }

                isArithmetic = false;

                break;
            }

            result[i] = isArithmetic;
        }

        return result;
    }
}