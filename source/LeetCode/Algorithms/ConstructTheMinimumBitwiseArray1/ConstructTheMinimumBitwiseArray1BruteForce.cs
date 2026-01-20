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

namespace LeetCode.Algorithms.ConstructTheMinimumBitwiseArray1;

/// <inheritdoc />
public sealed class ConstructTheMinimumBitwiseArray1BruteForce : IConstructTheMinimumBitwiseArray1
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] MinBitwiseArray(IList<int> nums)
    {
        var n = nums.Count;

        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            var value = -1;

            for (var j = 1; j < num; j++)
            {
                if ((j | (j + 1)) != num)
                {
                    continue;
                }

                value = j;

                break;
            }

            result[i] = value;
        }

        return result;
    }
}