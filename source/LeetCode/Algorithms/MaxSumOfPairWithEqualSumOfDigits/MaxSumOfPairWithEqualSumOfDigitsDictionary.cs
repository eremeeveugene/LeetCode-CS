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

namespace LeetCode.Algorithms.MaxSumOfPairWithEqualSumOfDigits;

/// <inheritdoc />
public sealed class MaxSumOfPairWithEqualSumOfDigits1 : IMaxSumOfPairWithEqualSumOfDigits
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaximumSum(int[] nums)
    {
        var maximumSum = -1;
        var dictionary = new Dictionary<int, (int Num1, int Num2)>();

        foreach (var num in nums)
        {
            var digitSum = GetDigitSum(num);

            if (dictionary.TryGetValue(digitSum, out var digits))
            {
                var num1 = digits.Num1;
                var num2 = digits.Num2;

                if (num > digits.Num1)
                {
                    num2 = num1;
                    num1 = num;
                }
                else if (num > num2)
                {
                    num2 = num;
                }

                maximumSum = Math.Max(maximumSum, num1 + num2);

                dictionary[digitSum] = (num1, num2);
            }
            else
            {
                dictionary.Add(digitSum, (num, 0));
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