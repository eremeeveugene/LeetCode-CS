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

namespace LeetCode.Algorithms.DesignStackWithIncrementOperation;

/// <inheritdoc />
public sealed class DesignStackWithIncrementOperationLinkedList : IDesignStackWithIncrementOperation
{
    private readonly int _maxSize;
    private int _count;
    private Node? _headNode;
    private Node? _tailNode;

    public DesignStackWithIncrementOperationLinkedList(int maxSize)
    {
        _maxSize = maxSize;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Push(int x)
    {
        if (_count >= _maxSize)
        {
            return;
        }

        var newNode = new Node(x, _headNode);

        if (_headNode == null)
        {
            _tailNode = newNode;
        }
        else
        {
            _headNode.Previous = newNode;
        }

        _headNode = newNode;

        _count++;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Pop()
    {
        if (_headNode == null)
        {
            return -1;
        }

        var value = _headNode.Value;

        _headNode = _headNode.Next;

        if (_headNode != null)
        {
            _headNode.Previous = null;
        }
        else
        {
            _tailNode = null;
        }

        _count--;

        return value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(min(k,n))
    ///     Space complexity - O(1)
    /// </remarks>
    public void Increment(int k, int val)
    {
        var i = 0;
        var currentNode = _tailNode;

        while (i < k && currentNode != null)
        {
            currentNode.Value += val;

            currentNode = currentNode.Previous;

            i++;
        }
    }

    private class Node(int value, Node? next = null, Node? previous = null)
    {
        public int Value { get; set; } = value;
        public Node? Next { get; } = next;
        public Node? Previous { get; set; } = previous;
    }
}