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

namespace LeetCode.Algorithms.ImplementQueueUsingStacks;

/// <inheritdoc />
public class ImplementQueueUsingStacksTwoStacks : IImplementQueueUsingStacks
{
    private readonly Stack<int> _stack = new();

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="x"></param>
    public void Push(int x)
    {
        var tempStack = new Stack<int>();

        while (_stack.Count > 0)
        {
            tempStack.Push(_stack.Pop());
        }

        _stack.Push(x);

        while (tempStack.Count > 0)
        {
            _stack.Push(tempStack.Pop());
        }
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public int Pop()
    {
        return _stack.Pop();
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public int Peek()
    {
        return _stack.Peek();
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public bool Empty()
    {
        return _stack.Count == 0;
    }
}