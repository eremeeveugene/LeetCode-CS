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

namespace LeetCode.Algorithms.DesignBrowserHistory;

/// <inheritdoc />
public sealed class DesignBrowserHistoryLinkedList : IDesignBrowserHistory
{
    private Node _current;

    /// <summary>
    ///     Initializes a new instance of the <see cref="DesignBrowserHistoryLinkedList" /> class.
    /// </summary>
    /// <param name="homepage">The homepage of the browser.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public DesignBrowserHistoryLinkedList(string homepage)
    {
        _current = new Node(homepage);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Visit(string url)
    {
        _current.Next = new Node(url) { Previous = _current };

        _current = _current.Next;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of steps
    ///     Space complexity - O(1)
    /// </remarks>
    public string Back(int steps)
    {
        for (var i = 0; i < steps; i++)
        {
            if (_current.Previous == null)
            {
                break;
            }

            _current = _current.Previous;
        }

        return _current.Value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of steps
    ///     Space complexity - O(1)
    /// </remarks>
    public string Forward(int steps)
    {
        for (var i = 0; i < steps; i++)
        {
            if (_current.Next == null)
            {
                break;
            }

            _current = _current.Next;
        }

        return _current.Value;
    }

    private sealed class Node
    {
        public Node(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public Node? Previous { get; set; }
        public Node? Next { get; set; }
    }
}