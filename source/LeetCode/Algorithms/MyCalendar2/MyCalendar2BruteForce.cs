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

namespace LeetCode.Algorithms.MyCalendar2;

/// <inheritdoc />
public class MyCalendar2BruteForce : IMyCalendar2
{
    private readonly List<Item> _items = [];
    private readonly List<Item> _overlapItems = [];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public bool Book(int start, int end)
    {
        var newItem = new Item(start, end);

        if (_overlapItems.Any(overlapItem => start < overlapItem.End && end > overlapItem.Start))
        {
            return false;
        }

        foreach (var item in _items.Where(item => start < item.End && end > item.Start))
        {
            _overlapItems.Add(new Item(Math.Max(start, item.Start), Math.Min(end, item.End)));
        }

        _items.Add(newItem);

        return true;
    }

    private class Item(int start, int end)
    {
        public int Start { get; } = start;
        public int End { get; } = end;
    }
}