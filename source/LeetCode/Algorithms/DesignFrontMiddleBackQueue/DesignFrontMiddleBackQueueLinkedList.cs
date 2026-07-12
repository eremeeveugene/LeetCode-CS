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
public sealed class DesignFrontMiddleBackQueueLinkedList : IDesignFrontMiddleBackQueue
{
    private int _count;
    private Node? _head;
    private Node? _tail;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void PushFront(int value)
    {
        if (_head == null)
        {
            var node = new Node(value);

            _head = node;
            _tail = node;
        }
        else
        {
            var node = new Node(value) { Next = _head };

            _head.Previous = node;
            _head = node;
        }

        _count++;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public void PushMiddle(int value)
    {
        if (_count == 0)
        {
            var node = new Node(value);

            _head = node;
            _tail = node;
        }
        else
        {
            var node = new Node(value);

            var middleIndex = _count / 2;
            var current = _head;

            for (var i = 0; i < middleIndex; i++)
            {
                current = current?.Next;
            }

            if (current != null)
            {
                node.Next = current;
                node.Previous = current.Previous;

                if (current.Previous != null)
                {
                    current.Previous.Next = node;
                }
                else
                {
                    _head = node;
                }

                current.Previous = node;
            }
        }

        _count++;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void PushBack(int value)
    {
        if (_tail == null)
        {
            var node = new Node(value);

            _head = node;
            _tail = node;
        }
        else
        {
            var node = new Node(value) { Previous = _tail };

            _tail.Next = node;
            _tail = node;
        }

        _count++;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int PopFront()
    {
        if (_head == null)
        {
            return -1;
        }

        var head = _head;

        _head = _head.Next;

        if (_head != null)
        {
            _head.Previous = null;
        }
        else
        {
            _tail = null;
        }

        _count--;

        return head.Value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int PopMiddle()
    {
        if (_head == null)
        {
            return -1;
        }

        var middleIndex = (_count - 1) / 2;
        var current = _head;

        for (var i = 0; i < middleIndex; i++)
        {
            current = current?.Next;
        }

        if (current == null)
        {
            return -1;
        }

        var middle = current;

        if (current.Previous != null)
        {
            current.Previous.Next = current.Next;
        }
        else
        {
            _head = current.Next;
        }

        if (current.Next != null)
        {
            current.Next.Previous = current.Previous;
        }
        else
        {
            _tail = current.Previous;
        }

        _count--;

        return middle.Value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int PopBack()
    {
        if (_tail == null)
        {
            return -1;
        }

        var tail = _tail;

        _tail = _tail.Previous;

        if (_tail != null)
        {
            _tail.Next = null;
        }
        else
        {
            _head = null;
        }

        _count--;

        return tail.Value;
    }

    private class Node(int value)
    {
        public Node? Next { get; set; }
        public Node? Previous { get; set; }
        public int Value { get; } = value;
    }
}