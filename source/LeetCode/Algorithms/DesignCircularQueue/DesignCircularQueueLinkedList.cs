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

namespace LeetCode.Algorithms.DesignCircularQueue;

/// <inheritdoc />
public sealed class DesignCircularQueueLinkedList(int k) : IDesignCircularQueue
{
    private int _count;
    private Node? _front;
    private Node? _rear;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool EnQueue(int value)
    {
        if (IsFull())
        {
            return false;
        }

        if (_rear == null)
        {
            _rear = new Node(value);
            _front = _rear;
        }
        else
        {
            var node = new Node(value);

            _rear.Next = node;

            _rear = node;
        }

        _count++;

        return true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool DeQueue()
    {
        if (IsEmpty())
        {
            return false;
        }

        if (_front == null)
        {
            return false;
        }

        _front = _front.Next;

        _count--;

        if (IsEmpty())
        {
            _rear = null;
        }

        return true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Front()
    {
        if (_front == null)
        {
            return -1;
        }

        return _front.Value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Rear()
    {
        if (_rear == null)
        {
            return -1;
        }

        return _rear.Value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsEmpty()
    {
        return _count == 0;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsFull()
    {
        return _count == k;
    }

    private class Node(int value)
    {
        public Node? Next { get; set; }

        public int Value { get; } = value;
    }
}