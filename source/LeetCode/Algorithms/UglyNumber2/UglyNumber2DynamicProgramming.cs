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

namespace LeetCode.Algorithms.UglyNumber2;

/// <inheritdoc />
public class UglyNumber2DynamicProgramming : IUglyNumber2
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int NthUglyNumber(int n)
    {
        var uglyNumbers = new int[n];

        uglyNumbers[0] = 1;

        var i2 = 0;
        var i3 = 0;
        var i5 = 0;

        var nextMultipleOf2 = 2;
        var nextMultipleOf3 = 3;
        var nextMultipleOf5 = 5;

        for (var i = 1; i < n; i++)
        {
            var nextUgly = Math.Min(nextMultipleOf2, Math.Min(nextMultipleOf3, nextMultipleOf5));

            uglyNumbers[i] = nextUgly;

            if (nextUgly == nextMultipleOf2)
            {
                i2++;

                nextMultipleOf2 = uglyNumbers[i2] * 2;
            }

            if (nextUgly == nextMultipleOf3)
            {
                i3++;

                nextMultipleOf3 = uglyNumbers[i3] * 3;
            }

            if (nextUgly == nextMultipleOf5)
            {
                i5++;

                nextMultipleOf5 = uglyNumbers[i5] * 5;
            }
        }

        return uglyNumbers[n - 1];
    }
}