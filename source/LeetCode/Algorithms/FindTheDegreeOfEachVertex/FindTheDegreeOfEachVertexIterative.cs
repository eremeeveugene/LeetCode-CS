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

namespace LeetCode.Algorithms.FindTheDegreeOfEachVertex;

/// <inheritdoc />
public sealed class FindTheDegreeOfEachVertexIterative : IFindTheDegreeOfEachVertex
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] FindDegrees(int[][] matrix)
    {
        var n = matrix.Length;

        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            var count = 0;

            var row = matrix[i];

            for (var j = 0; j < n; j++)
            {
                count += row[j];
            }

            result[i] = count;
        }

        return result;
    }
}