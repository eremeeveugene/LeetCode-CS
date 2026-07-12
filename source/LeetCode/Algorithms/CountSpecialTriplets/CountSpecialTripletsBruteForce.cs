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

namespace LeetCode.Algorithms.CountSpecialTriplets;

/// <inheritdoc />
public sealed class CountSpecialTripletsBruteForce : ICountSpecialTriplets
{
    private const int Modulo = 1_000_000_007;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SpecialTriplets(int[] nums)
    {
        long result = 0;

        var numsLength = nums.Length;

        for (var i = 0; i < numsLength - 2; i++)
        {
            var a = nums[i];

            for (var j = i + 1; j < numsLength - 1; j++)
            {
                var b = nums[j] * 2;

                if (a != b)
                {
                    continue;
                }

                for (var k = j + 1; k < numsLength; k++)
                {
                    var c = nums[k];

                    if (b != c)
                    {
                        continue;
                    }

                    result++;

                    if (result == Modulo)
                    {
                        result = 0;
                    }
                }
            }
        }

        return (int)result;
    }
}