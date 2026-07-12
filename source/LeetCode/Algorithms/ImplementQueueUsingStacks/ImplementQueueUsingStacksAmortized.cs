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

namespace LeetCode.Algorithms.ImplementQueueUsingStacks;

/// <inheritdoc />
public sealed class ImplementQueueUsingStacksAmortized : IImplementQueueUsingStacks
{
    private readonly Stack<int> _dequeueStack = new();
    private readonly Stack<int> _enqueueStack = new();

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </remarks>
    public void Push(int x)
    {
        _enqueueStack.Push(x);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - Amortized O(1), worst case - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Pop()
    {
        if (_dequeueStack.Count != 0)
        {
            return _dequeueStack.Pop();
        }

        while (_enqueueStack.Count > 0)
        {
            _dequeueStack.Push(_enqueueStack.Pop());
        }

        return _dequeueStack.Pop();
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - Amortized O(1), worst case - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Peek()
    {
        if (_dequeueStack.Count != 0)
        {
            return _dequeueStack.Peek();
        }

        while (_enqueueStack.Count > 0)
        {
            _dequeueStack.Push(_enqueueStack.Pop());
        }

        return _dequeueStack.Peek();
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool Empty()
    {
        return _enqueueStack.Count == 0 && _dequeueStack.Count == 0;
    }
}