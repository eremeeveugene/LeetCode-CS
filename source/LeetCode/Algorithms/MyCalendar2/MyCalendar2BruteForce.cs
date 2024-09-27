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
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public bool Book(int start, int end)
    {
        var newItem = new Item(start, end);

        if (_overlapItems.Any(overlapItem =>
                Math.Max(newItem.Start, overlapItem.Start) < Math.Min(newItem.End, overlapItem.End)))
        {
            return false;
        }

        foreach (var item in _items)
        {
            var overlapStart = Math.Max(newItem.Start, item.Start);
            var overlapEnd = Math.Min(newItem.End, item.End);

            if (overlapStart < overlapEnd)
            {
                _overlapItems.Add(new Item(overlapStart, overlapEnd));
            }
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