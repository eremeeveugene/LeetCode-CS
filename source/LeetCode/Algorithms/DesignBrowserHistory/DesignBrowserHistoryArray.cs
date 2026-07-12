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
public sealed class DesignBrowserHistoryArray : IDesignBrowserHistory
{
    private const int Capacity = 5000;
    private readonly string[] _history;
    private int _current;
    private int _last;

    /// <summary>
    ///     Initializes a new instance of the <see cref="DesignBrowserHistoryArray" /> class.
    /// </summary>
    /// <param name="homepage">The homepage of the browser.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public DesignBrowserHistoryArray(string homepage)
    {
        _history = new string[Capacity];
        _history[0] = homepage;
        _current = 0;
        _last = 0;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Visit(string url)
    {
        _current++;

        _history[_current] = url;

        _last = _current;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public string Back(int steps)
    {
        _current = Math.Max(0, _current - steps);

        return _history[_current];
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public string Forward(int steps)
    {
        _current = Math.Min(_last, _current + steps);

        return _history[_current];
    }
}