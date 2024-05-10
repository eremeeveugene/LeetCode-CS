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

namespace LeetCode.Algorithms.KthSmallestPrimeFraction;

/// <inheritdoc />
public class KthSmallestPrimeFractionBruteForce : IKthSmallestPrimeFraction
{
    /// <summary>
    ///     Time complexity - O(n^2 log n)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        var fractions = new List<(int i, int j, double fraction)>();

        for (var i = 0; i < arr.Length - 1; i++)
        {
            for (var j = i + 1; j < arr.Length; j++)
            {
                fractions.Add((arr[i], arr[j], arr[i] / (double)arr[j]));
            }
        }

        var orderedFractions = fractions.OrderBy(f => f.fraction).ToArray();

        return [orderedFractions[k - 1].i, orderedFractions[k - 1].j];
    }
}