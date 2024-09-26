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

namespace LeetCode.Algorithms.MyCalendar1;

/// <inheritdoc />
public class MyCalendar1BinarySearch : IMyCalendar1
{
    private readonly List<Item> _items = [];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public bool Book(int start, int end)
    {
        var item = new Item(start, end);

        var index = _items.BinarySearch(item);

        if (index < 0)
        {
            index = ~index;
        }

        if ((index < _items.Count && _items[index].Start < end) || (index > 0 && _items[index - 1].End > start))
        {
            return false;
        }

        _items.Insert(index, item);

        return true;
    }

    private class Item(int start, int end) : IComparable<Item>
    {
        public int Start { get; } = start;
        public int End { get; } = end;

        public int CompareTo(Item? other)
        {
            if (other == null)
            {
                return -1;
            }

            return Start.CompareTo(other.Start);
        }
    }
}