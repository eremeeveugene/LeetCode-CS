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

namespace LeetCode.Algorithms.DifferenceBetweenElementSumAndDigitSumOfArray;

/// <inheritdoc />
public sealed class DifferenceBetweenElementSumAndDigitSumOfArrayByDigitExtraction : IDifferenceBetweenElementSumAndDigitSumOfArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * d)
    ///     Space complexity - O(1)
    /// </remarks>
    public int DifferenceOfSum(int[] nums)
    {
        var absoluteSum = 0;

        foreach (var num in nums)
        {
            absoluteSum += num;

            var currentNum = num;

            while (currentNum > 0)
            {
                absoluteSum -= currentNum % 10;

                currentNum /= 10;
            }
        }

        return Math.Abs(absoluteSum);
    }
}