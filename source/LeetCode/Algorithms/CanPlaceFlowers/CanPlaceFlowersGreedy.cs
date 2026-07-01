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

namespace LeetCode.Algorithms.CanPlaceFlowers;

/// <inheritdoc />
public sealed class CanPlaceFlowersGreedy : ICanPlaceFlowers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanPlaceFlowers(int[] flowerbed, int flower)
    {
        var n = flowerbed.Length;

        var i = 0;

        while (i < n)
        {
            if (flowerbed[i] == 1)
            {
                i += 2;

                continue;
            }

            var rightEmpty = i == n - 1 || flowerbed[i + 1] == 0;

            if (rightEmpty)
            {
                flowerbed[i] = 1;
                flower--;

                if (flower <= 0)
                {
                    return true;
                }

                i += 2;
            }
            else
            {
                i += 3;
            }
        }

        return flower <= 0;
    }
}