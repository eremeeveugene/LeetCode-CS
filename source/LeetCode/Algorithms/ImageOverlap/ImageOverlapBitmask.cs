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

using System.Numerics;

namespace LeetCode.Algorithms.ImageOverlap;

/// <inheritdoc />
public sealed class ImageOverlapBitmask : IImageOverlap
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(n)
    /// </remarks>
    public int LargestOverlap(int[][] img1, int[][] img2)
    {
        var n = img1.Length;

        Span<uint> firstImageRowMasks = stackalloc uint[n];
        Span<uint> secondImageRowMasks = stackalloc uint[n];

        FillRowMasks(img1, firstImageRowMasks);
        FillRowMasks(img2, secondImageRowMasks);

        var result = 0;

        for (var rowOffset = 1 - n; rowOffset < n; rowOffset++)
        {
            var firstRow = Math.Max(0, -rowOffset);
            var rowLimit = Math.Min(n, n - rowOffset);

            for (var columnOffset = 1 - n; columnOffset < n; columnOffset++)
            {
                var overlap = 0;

                for (var row = firstRow; row < rowLimit; row++)
                {
                    var firstRowMask = firstImageRowMasks[row];
                    var secondRowMask = secondImageRowMasks[row + rowOffset];

                    uint shiftedRowMask;

                    if (columnOffset < 0)
                    {
                        shiftedRowMask = firstRowMask >> -columnOffset;
                    }
                    else
                    {
                        shiftedRowMask = firstRowMask << columnOffset;
                    }

                    overlap += BitOperations.PopCount(shiftedRowMask & secondRowMask);
                }

                result = Math.Max(result, overlap);
            }
        }

        return result;
    }

    /// <summary>
    ///     Encodes each image row as a bitmask, with one bit per column.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    private static void FillRowMasks(int[][] image, Span<uint> rowMasks)
    {
        var n = image.Length;

        for (var i = 0; i < n; i++)
        {
            var imageRow = image[i];

            uint rowMask = 0;

            for (var j = 0; j < n; j++)
            {
                rowMask |= (uint)imageRow[j] << j;
            }

            rowMasks[i] = rowMask;
        }
    }
}