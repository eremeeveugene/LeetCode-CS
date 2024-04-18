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

namespace LeetCode.Algorithms.FloodFill;

/// <inheritdoc />
public class FloodFillIterative : IFloodFill
{
    /// <summary>
    ///     Time complexity - O(n*m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="image"></param>
    /// <param name="sr"></param>
    /// <param name="sc"></param>
    /// <param name="newColor"></param>
    /// <returns></returns>
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        if (image[sr][sc] == newColor)
        {
            return image;
        }

        ReplacePixels(image, sr, sc, image[sr][sc], newColor);

        return image;
    }

    private static void ReplacePixels(IReadOnlyList<int[]> image, int sr, int sc, int oldColor, int newColor)
    {
        if (sr < 0 || sr >= image.Count || sc < 0 || sc >= image[sr].Length || image[sr][sc] != oldColor)
        {
            return;
        }

        image[sr][sc] = newColor;

        ReplacePixels(image, sr - 1, sc, oldColor, newColor);
        ReplacePixels(image, sr + 1, sc, oldColor, newColor);
        ReplacePixels(image, sr, sc - 1, oldColor, newColor);
        ReplacePixels(image, sr, sc + 1, oldColor, newColor);
    }
}