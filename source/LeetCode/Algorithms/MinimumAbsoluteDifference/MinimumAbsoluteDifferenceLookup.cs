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

namespace LeetCode.Algorithms.MinimumAbsoluteDifference;

/// <inheritdoc />
public sealed class MinimumAbsoluteDifferenceLookup : IMinimumAbsoluteDifference
{
    /// <summary>
    ///     Time complexity - O(n + R), where R = maxValue - MinValue + 1
    ///     Space complexity - O(R), where R = maxValue - MinValue + 1
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        var minValue = int.MaxValue;
        var maxValue = int.MinValue;

        for (var i = 0; i < arr.Length; i++)
        {
            var num = arr[i];

            minValue = Math.Min(minValue, num);
            maxValue = Math.Max(maxValue, num);
        }

        Span<bool> numsLookup = stackalloc bool[maxValue - minValue + 1];

        for (var i = 0; i < arr.Length; i++)
        {
            var num = arr[i];

            numsLookup[num - minValue] = true;
        }

        var minDifference = int.MaxValue;

        var result = new List<IList<int>>(arr.Length);

        var previousValue = minValue;

        for (var i = 1; i < numsLookup.Length; i++)
        {
            if (!numsLookup[i])
            {
                continue;
            }

            var currentValue = minValue + i;
            var difference = currentValue - previousValue;

            if (difference < minDifference)
            {
                minDifference = difference;

                result.Clear();
            }

            if (difference == minDifference)
            {
                result.Add(new[]
                {
                    previousValue,
                    currentValue
                });
            }

            previousValue = currentValue;
        }

        return result;
    }
}