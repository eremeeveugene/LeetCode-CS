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

namespace LeetCode.Algorithms.MaximumProductOfThreeNumbers;

/// <inheritdoc />
public sealed class MaximumProductOfThreeNumbersLinear : IMaximumProductOfThreeNumbers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaximumProduct(int[] nums)
    {
        var firstMaximum = int.MinValue;
        var secondMaximum = int.MinValue;
        var thirdMaximum = int.MinValue;

        var firstMinimum = int.MaxValue;
        var secondMinimum = int.MaxValue;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num >= firstMaximum)
            {
                thirdMaximum = secondMaximum;
                secondMaximum = firstMaximum;
                firstMaximum = num;
            }
            else if (num >= secondMaximum)
            {
                thirdMaximum = secondMaximum;
                secondMaximum = num;
            }
            else if (num > thirdMaximum)
            {
                thirdMaximum = num;
            }

            if (num <= firstMinimum)
            {
                secondMinimum = firstMinimum;
                firstMinimum = num;
            }
            else if (num < secondMinimum)
            {
                secondMinimum = num;
            }
        }

        var largestProduct = firstMaximum * secondMaximum * thirdMaximum;

        var smallestPairProduct = firstMinimum * secondMinimum * firstMaximum;

        return Math.Max(largestProduct, smallestPairProduct);
    }
}