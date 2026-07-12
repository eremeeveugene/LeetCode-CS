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

namespace LeetCode.Algorithms.FruitsIntoBaskets2;

/// <inheritdoc />
public sealed class FruitsIntoBaskets2BruteForce : IFruitsIntoBaskets2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var unplacedFruitsCount = fruits.Length;

        foreach (var fruit in fruits)
        {
            for (var j = 0; j < baskets.Length; j++)
            {
                if (fruit > baskets[j])
                {
                    continue;
                }

                baskets[j] = 0;

                unplacedFruitsCount--;

                break;
            }
        }

        return unplacedFruitsCount;
    }
}