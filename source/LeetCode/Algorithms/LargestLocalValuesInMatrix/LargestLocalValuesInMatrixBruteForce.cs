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

namespace LeetCode.Algorithms.LargestLocalValuesInMatrix;

/// <inheritdoc />
public class LargestLocalValuesInMatrixBruteForce : ILargestLocalValuesInMatrix
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int[][] LargestLocal(int[][] grid)
    {
        var result = new int[grid.Length - 2][];

        for (var i = 0; i < grid.Length - 2; i++)
        {
            result[i] = new int[grid.Length - 2];

            for (var j = 0; j < grid.Length - 2; j++)
            {
                for (var k = 0; k < 3; k++)
                {
                    for (var l = 0; l < 3; l++)
                    {
                        result[i][j] = Math.Max(result[i][j], grid[i + k][j + l]);
                    }
                }
            }
        }

        return result;
    }
}