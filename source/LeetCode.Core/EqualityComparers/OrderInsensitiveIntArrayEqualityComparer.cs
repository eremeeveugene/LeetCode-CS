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

namespace LeetCode.Core.EqualityComparers;

public class OrderInsensitiveIntArrayEqualityComparer : IEqualityComparer<int[]>
{
    private const int Seed = 13;
    private const int Multiplier = 17;

    public bool Equals(int[]? x, int[]? y)
    {
        if (x == null && y == null)
        {
            return true;
        }

        if (x == null || y == null)
        {
            return false;
        }

        return x.OrderBy(a => a).SequenceEqual(y.OrderBy(b => b));
    }

    public int GetHashCode(int[] array)
    {
        unchecked
        {
            return array.OrderBy(a => a).Aggregate(Seed, (accumulator, value) => (accumulator * Multiplier) + value);
        }
    }
}