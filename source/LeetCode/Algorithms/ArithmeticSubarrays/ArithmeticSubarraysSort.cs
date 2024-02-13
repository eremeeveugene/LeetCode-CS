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
public class ArithmeticSubarraysSort : IArithmeticSubarrays
{
    /// <summary>
    ///     Time complexity - O(m * n log n)
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
            var subArrayLength = r[i] - l[i] + 1;

            var subArray = new int[subArrayLength];

            for (var j = 0; j < subArrayLength; j++)
            {
                subArray[j] = nums[l[i] + j];
            }

            Array.Sort(subArray);

            var diff = subArray[1] - subArray[0];

            var currentResult = true;

            for (var j = 2; j < subArray.Length; j++)
            {
                currentResult &= subArray[j] - subArray[j - 1] == diff;
            }

            result[i] = currentResult;
        }

        return result;
    }
}