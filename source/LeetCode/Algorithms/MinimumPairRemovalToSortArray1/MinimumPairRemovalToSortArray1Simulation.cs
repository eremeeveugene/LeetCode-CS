// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MinimumPairRemovalToSortArray1;

/// <inheritdoc />
public class MinimumPairRemovalToSortArray1Simulation : IMinimumPairRemovalToSortArray1
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinimumPairRemoval(int[] nums)
    {
        var list = new List<int>(nums);
        var operations = 0;

        while (!IsSorted(list))
        {
            var minIndex = GetMinSumIndex(list);

            list[minIndex] += list[minIndex + 1];

            list.RemoveAt(minIndex + 1);

            operations++;
        }

        return operations;
    }

    private static bool IsSorted(List<int> list)
    {
        for (var i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    private static int GetMinSumIndex(List<int> list)
    {
        var minSum = int.MaxValue;
        var minSumIndex = 0;

        for (var i = 0; i < list.Count - 1; i++)
        {
            var sum = list[i] + list[i + 1];

            if (sum >= minSum)
            {
                continue;
            }

            minSum = sum;
            minSumIndex = i;
        }

        return minSumIndex;
    }
}