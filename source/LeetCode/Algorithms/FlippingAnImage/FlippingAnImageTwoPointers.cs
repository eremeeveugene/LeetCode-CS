// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class FlippingAnImageTwoPointers : IFlippingAnImage
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="image"></param>
    /// <returns></returns>
    public int[][] FlipAndInvertImage(int[][] image)
    {
        foreach (var row in image)
        {
            var left = 0;
            var right = row.Length - 1;

            while (left < right)
            {
                (row[left], row[right]) = (row[right] ^ 1, row[left] ^ 1);

                left++;
                right--;
            }

            if (left == right)
            {
                row[left] ^= 1;
            }
        }

        return image;
    }
}