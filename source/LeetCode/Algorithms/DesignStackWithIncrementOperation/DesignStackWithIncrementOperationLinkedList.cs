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

namespace LeetCode.Algorithms.DesignStackWithIncrementOperation;

/// <inheritdoc />
public class DesignStackWithIncrementOperationLinkedList(int maxSize) : IDesignStackWithIncrementOperation
{
    private int _count;
    private Node? _headNode;
    private Node? _tailNode;

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    public void Push(int x)
    {
        if (_count >= maxSize)
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

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    ///     Time complexity - O(min(k,n))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="k"></param>
    /// <param name="val"></param>
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