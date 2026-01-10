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

namespace LeetCode.Algorithms.FlippingAnImage;

/// <inheritdoc />
public sealed class FlippingAnImageReverse : IFlippingAnImage
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </summary>
    /// <param name="image"></param>
    /// <returns></returns>
    public int[][] FlipAndInvertImage(int[][] image)
    {
        for (var i = 0; i < image.Length; i++)
        {
            image[i] = ReverseRow(image[i]);
        }

        return image;
    }

    private static int[] ReverseRow(int[] row)
    {
        return row.Reverse().Select(cell => cell ^ 1).ToArray();
    }
}