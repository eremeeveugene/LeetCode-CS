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

namespace LeetCode.Algorithms.NumberOfSubsequencesThatSatisfyTheGivenSumCondition;

/// <inheritdoc />
public sealed class NumberOfSubsequencesThatSatisfyTheGivenSumConditionSortingTwoPointers : INumberOfSubsequencesThatSatisfyTheGivenSumCondition
{
    private const int Modulo = 1_000_000_007;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int NumSubseq(int[] nums, int target)
    {
        Array.Sort(nums);

        var powersOfTwo = new int[nums.Length];

        powersOfTwo[0] = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            powersOfTwo[i] = powersOfTwo[i - 1] * 2 % Modulo;
        }

        var result = 0;

        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            if (nums[left] + nums[right] <= target)
            {
                result = (result + powersOfTwo[right - left]) % Modulo;

                left++;
            }
            else
            {
                right--;
            }
        }

        return result;
    }
}