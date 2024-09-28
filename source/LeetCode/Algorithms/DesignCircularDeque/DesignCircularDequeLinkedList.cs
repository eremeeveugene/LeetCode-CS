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

namespace LeetCode.Algorithms.DesignCircularDeque;

/// <inheritdoc />
public class DesignCircularDequeLinkedList(int k) : IDesignCircularDeque
{
    private int _count;
    private DequeNode? _frontNode = new();
    private DequeNode? _rearNode = new();

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool InsertFront(int value)
    {
        if (IsFull())
        {
            return false;
        }

        if (_frontNode == null)
        {
            _frontNode = new DequeNode(value);

            _rearNode = _frontNode;
        }
        else
        {
            _frontNode.Previous = new DequeNode(value, _frontNode);

            _frontNode = _frontNode.Previous;
        }

        _count++;

        return true;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool InsertLast(int value)
    {
        if (IsFull())
        {
            return false;
        }

        if (_rearNode == null)
        {
            _rearNode = new DequeNode(value);

            _frontNode = _rearNode;
        }
        else
        {
            _rearNode.Next = new DequeNode(value, _frontNode);

            _rearNode = _rearNode.Next;
        }

        _count++;

        return true;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public bool DeleteFront()
    {
        if (IsEmpty())
        {
            return false;
        }

        if (_count == 1)
        {
            _frontNode = null;
            _rearNode = null;
        }
        else
        {
            _frontNode = _frontNode?.Next;
        }

        _count--;

        return true;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public bool DeleteLast()
    {
        if (IsEmpty())
        {
            return false;
        }

        if (_count == 1)
        {
            _frontNode = null;
            _rearNode = null;
        }
        else
        {
            _rearNode = _rearNode?.Previous;
        }

        _count--;

        return true;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public int GetFront()
    {
        if (_frontNode == null)
        {
            return -1;
        }

        return _frontNode.Value;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public int GetRear()
    {
        if (_rearNode == null)
        {
            return -1;
        }

        return _rearNode.Value;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        return _count == 0;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public bool IsFull()
    {
        return _count == k;
    }

    private class DequeNode(int value = 0, DequeNode? next = null, DequeNode? previous = null)
    {
        public DequeNode? Previous { get; set; } = previous;

        public DequeNode? Next { get; set; } = next;

        public int Value { get; } = value;
    }
}