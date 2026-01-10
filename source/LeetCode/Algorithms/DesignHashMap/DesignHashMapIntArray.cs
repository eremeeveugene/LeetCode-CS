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

namespace LeetCode.Algorithms.DesignHashMap;

/// <inheritdoc />
public sealed class DesignHashMapIntArray : IDesignHashMap
{
    private readonly int[] _items = new int[1_000_001];

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public void Put(int key, int value)
    {
        _items[key] = value + 1;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public int Get(int key)
    {
        return _items[key] - 1;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="key"></param>
    public void Remove(int key)
    {
        _items[key] = 0;
    }
}