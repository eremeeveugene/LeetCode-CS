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
public sealed class MinimumAbsoluteDifferenceSorting : IMinimumAbsoluteDifference
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);

        var result = new List<IList<int>>(arr.Length);

        var minDifference = int.MaxValue;

        for (var i = 0; i < arr.Length - 1; i++)
        {
            var difference = arr[i + 1] - arr[i];

            if (difference < minDifference)
            {
                minDifference = difference;

                result.Clear();
            }

            if (difference == minDifference)
            {
                result.Add(new[] { arr[i], arr[i + 1] });
            }
        }

        return result;
    }
}