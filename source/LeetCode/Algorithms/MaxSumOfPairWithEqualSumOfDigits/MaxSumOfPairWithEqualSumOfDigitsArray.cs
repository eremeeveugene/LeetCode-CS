// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MaxSumOfPairWithEqualSumOfDigits;

/// <inheritdoc />
public class MaxSumOfPairWithEqualSumOfDigitsDictionary : IMaxSumOfPairWithEqualSumOfDigits
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaximumSum(int[] nums)
    {
        var maximumSum = -1;
        var maxNums = new int[82];
        var secondMaxNums = new int[82];

        foreach (var num in nums)
        {
            var digitSum = GetDigitSum(num);

            if (num > maxNums[digitSum])
            {
                secondMaxNums[digitSum] = maxNums[digitSum];
                maxNums[digitSum] = num;
            }
            else if (num > secondMaxNums[digitSum])
            {
                secondMaxNums[digitSum] = num;
            }

            if (secondMaxNums[digitSum] > 0)
            {
                maximumSum = Math.Max(maximumSum, maxNums[digitSum] + secondMaxNums[digitSum]);
            }
        }

        return maximumSum;
    }

    private static int GetDigitSum(int num)
    {
        var digitSum = 0;

        while (num > 0)
        {
            digitSum += num % 10;

            num /= 10;
        }

        return digitSum;
    }
}