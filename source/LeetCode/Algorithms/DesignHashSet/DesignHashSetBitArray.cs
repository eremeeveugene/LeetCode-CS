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

using System.Collections;

namespace LeetCode.Algorithms.DesignHashSet;

/// <inheritdoc />
public class DesignHashSetBitArray : DesignHashSetBase
{
    private readonly BitArray _items = new(ItemsCount);

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="key"></param>
    public override void Add(int key)
    {
        _items[key] = true;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="key"></param>
    public override void Remove(int key)
    {
        _items[key] = false;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public override bool Contains(int key)
    {
        return _items[key];
    }
}