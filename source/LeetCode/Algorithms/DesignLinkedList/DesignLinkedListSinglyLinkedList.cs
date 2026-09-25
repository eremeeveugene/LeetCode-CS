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
public sealed class DesignLinkedListSinglyLinkedList : IDesignLinkedList
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
        var tail = new Node(value);

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

        var previous = GetNode(index - 1);
        var next = previous.Next;

        var node = new Node(value, next);

        previous.Next = node;

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

        var previous = index == 0 ? null : GetNode(index - 1);
        var node = previous == null ? _head! : previous.Next!;

        if (previous == null)
        {
            _head = node.Next;
        }
        else
        {
            previous.Next = node.Next;
        }

        if (node == _tail)
        {
            _tail = previous;
        }

        _count--;
    }

    /// <summary>
    ///     Finds the node at a valid index by traversing from the head.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    private Node GetNode(int index)
    {
        var node = _head!;

        for (var i = 0; i < index; i++)
        {
            node = node.Next!;
        }

        return node;
    }

    private sealed class Node
    {
        public Node(int value, Node? next = null)
        {
            Value = value;
            Next = next;
        }

        public Node? Next { get; set; }

        public int Value { get; }
    }
}