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

namespace LeetCode.Algorithms.FindThePunishmentNumberOfInteger;

/// <inheritdoc />
public sealed class FindThePunishmentNumberOfIntegerRecursive : IFindThePunishmentNumberOfInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * 2^(log10 n))
    ///     Space complexity - O(log10 n)
    /// </remarks>
    public int PunishmentNumber(int n)
    {
        var punishmentNumber = 0;

        for (var i = 1; i <= n; i++)
        {
            var square = i * i;
            var squareStr = square.ToString();

            if (CanPartitionToSum(squareStr, 0, i, 0))
            {
                punishmentNumber += square;
            }
        }

        return punishmentNumber;
    }

    private static bool CanPartitionToSum(string s, int index, int target, int currentSum)
    {
        if (index == s.Length)
        {
            return currentSum == target;
        }

        var num = 0;

        for (var i = index; i < s.Length; i++)
        {
            num = (num * 10) + (s[i] - '0');

            if (currentSum + num > target)
            {
                break;
            }

            if (CanPartitionToSum(s, i + 1, target, currentSum + num))
            {
                return true;
            }
        }

        return false;
    }
}