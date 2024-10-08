﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.ImplementStackUsingQueues;

/// <inheritdoc />
public class ImplementStackUsingQueuesTwoQueues : IImplementStackUsingQueues
{
    private readonly Queue<int> _queue1 = new();
    private readonly Queue<int> _queue2 = new();

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="x"></param>
    public void Push(int x)
    {
        if (_queue1.Count > 0)
        {
            _queue2.Enqueue(x);

            while (_queue1.Count > 0)
            {
                _queue2.Enqueue(_queue1.Dequeue());
            }
        }
        else
        {
            _queue1.Enqueue(x);

            while (_queue2.Count > 0)
            {
                _queue1.Enqueue(_queue2.Dequeue());
            }
        }
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </summary>
    /// <returns></returns>
    public int Pop()
    {
        return _queue1.Count > 0 ? _queue1.Dequeue() : _queue2.Dequeue();
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </summary>
    /// <returns></returns>
    public int Top()
    {
        return _queue1.Count > 0 ? _queue1.Peek() : _queue2.Peek();
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </summary>
    /// <returns></returns>
    public bool Empty()
    {
        return _queue1.Count == 0 && _queue2.Count == 0;
    }
}