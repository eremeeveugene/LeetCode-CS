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

namespace LeetCode.Algorithms.MaximumKToSortAPermutation;

/// <inheritdoc />
public sealed class MaximumKToSortAPermutationBitManipulation : IMaximumKToSortAPermutation
{
    private const int AllBitsSet = -1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SortPermutation(int[] nums)
    {
        var n = nums.Length;

        var misplacedAnd = AllBitsSet;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num == i)
            {
                continue;
            }

            misplacedAnd &= num;
        }

        return misplacedAnd == AllBitsSet ? 0 : misplacedAnd;
    }
}