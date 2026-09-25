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

namespace LeetCode.Algorithms.DesignLinkedList;

/// <inheritdoc />
public sealed class DesignLinkedListDoublyLinkedList : IDesignLinkedList
{
    private int _count;
    private Node? _head;
    private Node? _tail;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Get(int index)
    {
        if (index >= _count)
        {
            return -1;
        }

        var node = GetNode(index);

        return node.Value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void AddAtHead(int value)
    {
        var head = new Node(value, _head);

        if (_head == null)
        {
            _tail = head;
        }
        else
        {
            _head.Previous = head;
        }

        _head = head;

        _count++;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void AddAtTail(int value)
    {
        var tail = new Node(value, null, _tail);

        if (_tail == null)
        {
            _head = tail;
        }
        else
        {
            _tail.Next = tail;
        }

        _tail = tail;

        _count++;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public void AddAtIndex(int index, int value)
    {
        if (index == 0)
        {
            AddAtHead(value);

            return;
        }

        if (index == _count)
        {
            AddAtTail(value);

            return;
        }

        var next = GetNode(index);
        var previous = next.Previous!;

        var node = new Node(value, next, previous);

        previous.Next = node;
        next.Previous = node;

        _count++;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public void DeleteAtIndex(int index)
    {
        if (index >= _count)
        {
            return;
        }

        var node = GetNode(index);

        if (node.Previous == null)
        {
            _head = node.Next;
        }
        else
        {
            node.Previous.Next = node.Next;
        }

        if (node.Next == null)
        {
            _tail = node.Previous;
        }
        else
        {
            node.Next.Previous = node.Previous;
        }

        _count--;
    }

    /// <summary>
    ///     Finds the node at a valid index by traversing from the head or tail.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    private Node GetNode(int index)
    {
        if (index < _count - index)
        {
            var node = _head!;

            for (var i = 0; i < index; i++)
            {
                node = node.Next!;
            }

            return node;
        }
        else
        {
            var node = _tail!;

            for (var i = _count - 1; i > index; i--)
            {
                node = node.Previous!;
            }

            return node;
        }
    }

    private sealed class Node
    {
        public Node(int value, Node? next = null, Node? previous = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }

        public Node? Previous { get; set; }

        public Node? Next { get; set; }

        public int Value { get; }
    }
}