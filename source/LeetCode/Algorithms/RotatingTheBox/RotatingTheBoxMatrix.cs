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

namespace LeetCode.Algorithms.RotatingTheBox;

/// <inheritdoc />
public sealed class RotatingTheBoxMatrix : IRotatingTheBox
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </remarks>
    public char[][] RotateTheBox(char[][] box)
    {
        var m = box.Length;
        var n = box[0].Length;

        var result = new char[n][];

        for (var i = 0; i < n; i++)
        {
            result[i] = new char[m];
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                result[j][m - i - 1] = box[i][j];
            }
        }

        for (var j = 0; j < m; j++)
        {
            var emptyRow = n - 1;

            for (var i = n - 1; i >= 0; i--)
            {
                switch (result[i][j])
                {
                    case '#':
                        result[i][j] = '.';
                        result[emptyRow][j] = '#';
                        emptyRow--;
                        break;
                    case '*':
                        emptyRow = i - 1;
                        break;
                }
            }
        }

        return result;
    }
}