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

namespace LeetCode.Algorithms.MaximalRectangle;

/// <inheritdoc />
public sealed class MaximalRectangleStack : IMaximalRectangle
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaximalRectangle(char[][] matrix)
    {
        var maxArea = 0;
        var height = new int[matrix[0].Length + 1];

        foreach (var item in matrix)
        {
            var stack = new Stack<int>();

            for (var col = 0; col <= matrix[0].Length; col++)
            {
                UpdateHeight(height, item, col);

                while (stack.Count > 0 && height[col] < height[stack.Peek()])
                {
                    var h = height[stack.Pop()];
                    var w = stack.Count == 0 ? col : col - stack.Peek() - 1;

                    maxArea = Math.Max(maxArea, h * w);
                }

                stack.Push(col);
            }
        }

        return maxArea;
    }

    private static void UpdateHeight(int[] height, char[] row, int column)
    {
        if (column >= row.Length)
        {
            return;
        }

        height[column] = row[column] == '1' ? height[column] + 1 : 0;
    }
}