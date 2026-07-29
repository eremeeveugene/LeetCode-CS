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

namespace LeetCode.Algorithms.FindTheDuplicateNumber;

/// <inheritdoc />
public sealed class FindTheDuplicateNumberBruteForce : IFindTheDuplicateNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindDuplicate(int[] nums)
    {
        var duplicate = nums[0];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!HasDuplicate(nums, num, i))
            {
                continue;
            }

            duplicate = nums[i];

            break;
        }

        return duplicate;
    }

    /// <summary>
    ///     Determines whether <paramref name="value" /> appears again in <paramref name="nums" /> at any index after
    ///     <paramref name="i" />.
    /// </summary>
    /// <param name="nums">The array to scan.</param>
    /// <param name="value">The value to search for a later occurrence of.</param>
    /// <param name="i">The index whose value is being checked; scanning starts at the next index.</param>
    /// <returns><c>true</c> if a later element equals <paramref name="value" />; otherwise, <c>false</c>.</returns>
    private static bool HasDuplicate(int[] nums, int value, int i)
    {
        for (var j = i + 1; j < nums.Length; j++)
        {
            var num = nums[j];

            if (num == value)
            {
                return true;
            }
        }

        return false;
    }
}