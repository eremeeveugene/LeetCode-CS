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
public class DifferenceBetweenElementSumAndDigitSumOfArrayByDigitExtraction :
    IDifferenceBetweenElementSumAndDigitSumOfArray
{
    /// <summary>
    ///     Time complexity - O(n * d)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
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