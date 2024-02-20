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

namespace LeetCode.Algorithms.DifferenceBetweenElementSumAndDigitSumOfArray;

/// <inheritdoc />
public class DifferenceBetweenElementSumAndDigitSumOfArrayIterative : IDifferenceBetweenElementSumAndDigitSumOfArray
{
    /// <summary>
    ///     Time complexity - O(n * d)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int DifferenceOfSum(int[] nums)
    {
        var elementSum = nums.Sum();

        var digitSum = 0;

        foreach (var num in nums)
        {
            var currentNum = num;

            while (currentNum > 0)
            {
                digitSum += currentNum % 10;

                currentNum /= 10;
            }
        }

        return Math.Abs(elementSum - digitSum);
    }
}