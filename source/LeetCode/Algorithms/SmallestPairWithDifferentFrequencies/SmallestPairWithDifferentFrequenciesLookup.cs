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

namespace LeetCode.Algorithms.SmallestPairWithDifferentFrequencies;

/// <inheritdoc />
public sealed class SmallestPairWithDifferentFrequenciesLookup : ISmallestPairWithDifferentFrequencies
{
    private static readonly int[] EmptyPair = [-1, -1];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] MinDistinctFreqPair(int[] nums)
    {
        if (nums.Length < 3)
        {
            return EmptyPair;
        }

        Span<int> frequencies = stackalloc int[101];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            frequencies[num]++;
        }

        var xFrequency = 0;
        var x = -1;
        var y = -1;

        for (var i = 0; i < frequencies.Length; i++)
        {
            var frequency = frequencies[i];

            if (frequency <= 0)
            {
                continue;
            }

            if (x < 0)
            {
                x = i;
                xFrequency = frequency;
            }
            else if (y < 0)
            {
                if (frequency != xFrequency)
                {
                    y = i;
                }
            }
            else
            {
                break;
            }
        }

        return y == -1 ? EmptyPair : [x, y];
    }
}