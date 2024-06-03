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

namespace LeetCode.Algorithms.MaximalRectangle;

/// <inheritdoc />
public class MaximalRectangleStack : IMaximalRectangle
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public int MaximalRectangle(char[][] matrix)
    {
        var maxArea = 0;
        var height = new int[matrix[0].Length + 1];

        foreach (var item in matrix)
        {
            var stack = new Stack<int>();

            for (var col = 0; col <= matrix[0].Length; col++)
            {
                if (col < matrix[0].Length)
                {
                    if (item[col] == '1')
                    {
                        height[col] += 1;
                    }
                    else
                    {
                        height[col] = 0;
                    }
                }

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
}