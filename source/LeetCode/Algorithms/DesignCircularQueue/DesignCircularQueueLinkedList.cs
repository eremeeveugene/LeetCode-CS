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

namespace LeetCode.Algorithms.DesignCircularQueue;

/// <inheritdoc />
public class DesignCircularQueueLinkedList(int k) : IDesignCircularQueue
{
    private int _count;

    private Node? _front;

    private Node? _rear;

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
            var nextNode = new Node(value);

            _rear.Next = nextNode;

            _rear = nextNode;
        }

        _count++;

        return true;
    }

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

    public int Front()
    {
        if (_front == null)
        {
            return -1;
        }

        return _front.Value;
    }

    public int Rear()
    {
        if (_rear == null)
        {
            return -1;
        }

        return _rear.Value;
    }

    public bool IsEmpty()
    {
        return _count == 0;
    }

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