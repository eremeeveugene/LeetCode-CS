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

namespace LeetCode.Algorithms.Convert1DArrayInto2DArray;

/// <inheritdoc />
public class Convert1DArrayInto2DArraySimulation : IConvert1DArrayInto2DArray
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="original"></param>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        if (original.Length != m * n)
        {
            return [];
        }

        var result = new int[m][];

        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];

            for (var j = 0; j < n; j++)
            {
                result[i][j] = original[(i * n) + j];
            }
        }

        return result;
    }
}