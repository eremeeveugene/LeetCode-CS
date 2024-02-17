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

namespace LeetCode.Algorithms.PascalsTriangle;

/// <inheritdoc />
public class PascalsTriangleDynamicProgramming : IPascalsTriangle
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="numRows"></param>
    /// <returns></returns>
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>> { new List<int> { 1 } };

        for (var i = 1; i < numRows; i++)
        {
            var row = new List<int> { 1 };

            for (var j = 1; j < i; j++)
            {
                var value = result[i - 1][j - 1] + result[i - 1][j];

                row.Add(value);
            }

            row.Add(1);
            result.Add(row);
        }

        return result;
    }
}