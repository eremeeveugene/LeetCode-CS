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

namespace LeetCode.Algorithms.KthSmallestPrimeFraction;

/// <inheritdoc />
public sealed class KthSmallestPrimeFractionBinarySearch : IKthSmallestPrimeFraction
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n * log m)
    ///     Space complexity - O(k)
    /// </remarks>
    public int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        var result = new int[2];

        double left = 0, right = 1.0;

        while (left < right)
        {
            var mid = (left + right) / 2;
            var total = 0;
            var p = 0;
            var q = 1;
            var j = 1;

            var heap = new SortedSet<(double value, int i, int j)>(
                Comparer<(double value, int i, int j)>.Create((a, b) =>
                {
                    var comparerResult = a.value.CompareTo(b.value);

                    return comparerResult == 0 ? a.i.CompareTo(b.i) : comparerResult;
                }));

            for (var i = 0; i < arr.Length - 1; i++)
            {
                while (j < arr.Length && arr[i] > mid * arr[j])
                {
                    j++;
                }

                total += arr.Length - j;

                if (j == arr.Length)
                {
                    break;
                }

                if (arr[i] * q > arr[j] * p)
                {
                    p = arr[i];
                    q = arr[j];
                }

                heap.Add((arr[i] / (double)arr[j], i, j));

                if (heap.Count > k)
                {
                    heap.Remove(heap.Max);
                }
            }

            if (total == k)
            {
                result[0] = p;
                result[1] = q;

                break;
            }

            if (total < k)
            {
                left = mid;
            }
            else
            {
                right = mid;

                if (heap.Count != k)
                {
                    continue;
                }

                result[0] = arr[heap.Max.i];
                result[1] = arr[heap.Max.j];
            }
        }

        return result;
    }
}