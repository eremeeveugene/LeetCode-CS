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

namespace LeetCode.Algorithms.MinimumCapacityBox;

/// <inheritdoc />
public sealed class MinimumCapacityBoxIterative : IMinimumCapacityBox
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="capacities"></param>
    /// <param name="itemSize"></param>
    /// <returns></returns>
    public int MinimumIndex(int[] capacities, int itemSize)
    {
        var minCapacity = int.MaxValue;

        var result = -1;

        for (var i = 0; i < capacities.Length; i++)
        {
            var capacity = capacities[i];

            if (capacity < itemSize || capacity >= minCapacity)
            {
                continue;
            }

            minCapacity = capacity;

            result = i;
        }

        return result;
    }
}