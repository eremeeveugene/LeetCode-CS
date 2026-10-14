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
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </remarks>
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
        var result = new int[row.Length];

        for (var i = 0; i < row.Length; i++)
        {
            result[i] = row[row.Length - 1 - i] ^ 1;
        }

        return result;
    }
}