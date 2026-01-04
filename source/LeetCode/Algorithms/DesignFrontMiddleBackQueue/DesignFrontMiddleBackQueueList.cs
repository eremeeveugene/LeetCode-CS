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

namespace LeetCode.Algorithms.DesignFrontMiddleBackQueue;

/// <inheritdoc />
public class DesignFrontMiddleBackQueueList : IDesignFrontMiddleBackQueue
{
    private readonly List<int> _items = [];
    private int _count;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="value"></param>
    public void PushFront(int value)
    {
        _items.Insert(0, value);

        _count++;
    }

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="value"></param>
    public void PushMiddle(int value)
    {
        _items.Insert(_count / 2, value);

        _count++;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="value"></param>
    public void PushBack(int value)
    {
        _items.Add(value);

        _count++;
    }

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <returns></returns>
    public int PopFront()
    {
        if (_count == 0)
        {
            return -1;
        }

        var front = _items[0];

        _items.RemoveAt(0);

        _count--;

        return front;
    }

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <returns></returns>
    public int PopMiddle()
    {
        if (_count == 0)
        {
            return -1;
        }

        var index = (_count - 1) / 2;

        var middle = _items[index];

        _items.RemoveAt(index);

        _count--;

        return middle;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </summary>
    /// <returns></returns>
    public int PopBack()
    {
        if (_count == 0)
        {
            return -1;
        }

        var index = _count - 1;

        var back = _items[index];

        _items.RemoveAt(index);

        _count--;

        return back;
    }
}