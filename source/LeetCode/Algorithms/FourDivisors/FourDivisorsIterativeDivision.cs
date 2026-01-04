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

namespace LeetCode.Algorithms.FourDivisors;

/// <inheritdoc />
public sealed class FourDivisorsIterativeDivision : IFourDivisors
{
    /// <summary>
    ///     Time complexity - O(n * sqrt(m))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SumFourDivisors(int[] nums)
    {
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            result += GetSum(num);
        }

        return result;
    }

    private static int GetSum(int num)
    {
        var count = 1;
        var sum = num + 1;

        var divisor = 2;

        while (divisor * divisor <= num)
        {
            if (num % divisor == 0)
            {
                var pairedDivisor = num / divisor;

                sum += divisor;

                count++;

                if (pairedDivisor != divisor)
                {
                    sum += pairedDivisor;

                    count++;
                }

                if (count > 3)
                {
                    return 0;
                }
            }

            divisor++;
        }

        return count < 3 ? 0 : sum;
    }
}