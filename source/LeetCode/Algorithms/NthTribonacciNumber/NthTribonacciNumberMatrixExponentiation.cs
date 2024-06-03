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

namespace LeetCode.Algorithms.NthTribonacciNumber;

/// <inheritdoc />
public class NthTribonacciNumberMatrixExponentiation : INthTribonacciNumber
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Time complexity - O(log n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Tribonacci(int n)
    {
        switch (n)
        {
            case 0:
                return 0;
            case 1:
            case 2:
                return 1;
        }

        int[,] matrix = { { 1, 1, 1 }, { 1, 0, 0 }, { 0, 1, 0 } };

        var result = Power(matrix, n - 2);

        return result[0, 0] + result[0, 1];
    }

    private static int[,] Power(int[,] matrix, int power)
    {
        int[,] result = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

        while (power > 0)
        {
            if (power % 2 == 1)
            {
                result = Multiply(result, matrix);
            }

            matrix = Multiply(matrix, matrix);
            power /= 2;
        }

        return result;
    }

    private static int[,] Multiply(int[,] a, int[,] b)
    {
        var result = new int[3, 3];

        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                result[i, j] = 0;

                for (var k = 0; k < 3; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return result;
    }
}