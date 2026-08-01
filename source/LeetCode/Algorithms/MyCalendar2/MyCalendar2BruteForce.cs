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

namespace LeetCode.Algorithms.MyCalendar2;

/// <inheritdoc />
public sealed class MyCalendar2BruteForce : IMyCalendar2
{
    private readonly List<(int Start, int End)> _items = [];
    private readonly List<(int Start, int End)> _overlapItems = [];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool Book(int start, int end)
    {
        if (_overlapItems.Any(overlapItem => start < overlapItem.End && end > overlapItem.Start))
        {
            return false;
        }

        for (var i = 0; i < _items.Count; i++)
        {
            var item = _items[i];

            if (start >= item.End || end <= item.Start)
            {
                continue;
            }

            _overlapItems.Add((Math.Max(start, item.Start), Math.Min(end, item.End)));
        }

        _items.Add((start, end));

        return true;
    }
}