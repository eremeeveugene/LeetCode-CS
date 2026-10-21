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

namespace LeetCode.Algorithms.MinimumOperationsToSortAString;

/// <inheritdoc />
public sealed class MinimumOperationsToSortAStringIterative : IMinimumOperationsToSortAString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinOperations(string s)
    {
        var n = s.Length;

        switch (n)
        {
            case 1:
                return 0;
            case 2 when s[0] > s[1]:
                return -1;
            case 2:
                return 0;
        }

        var isSorted = true;

        var min = int.MaxValue;
        var minIndex = 0;

        var max = int.MinValue;
        var maxIndex = 0;

        var previousNum = 0;

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            var num = c - 'a';

            if (min > num)
            {
                min = num;
                minIndex = i;
            }

            if (max <= num)
            {
                max = num;
                maxIndex = i;
            }

            if (num < previousNum)
            {
                isSorted = false;
            }

            previousNum = num;
        }

        if (isSorted)
        {
            return 0;
        }

        if (minIndex == 0 || maxIndex == n - 1)
        {
            return 1;
        }

        if (minIndex == n - 1 && maxIndex == 0)
        {
            return 3;
        }

        return 2;
    }
}