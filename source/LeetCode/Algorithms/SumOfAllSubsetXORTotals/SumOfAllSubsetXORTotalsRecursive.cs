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

namespace LeetCode.Algorithms.SumOfAllSubsetXORTotals;

/// <inheritdoc />
public class SumOfAllSubsetXORTotalsRecursive : ISumOfAllSubsetXORTotals
{
    /// <summary>
    ///     Time complexity - O(2^n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SubsetXORSum(int[] nums)
    {
        return CalculateXORSum(nums, 0, 0);
    }

    private static int CalculateXORSum(IReadOnlyList<int> nums, int index, int currentXOR)
    {
        if (index == nums.Count)
        {
            return currentXOR;
        }

        return CalculateXORSum(nums, index + 1, currentXOR ^ nums[index]) +
               CalculateXORSum(nums, index + 1, currentXOR);
    }
}