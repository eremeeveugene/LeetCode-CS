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

namespace LeetCode.Algorithms.MyCalendar1;

/// <inheritdoc />
public sealed class MyCalendar1BinarySearch : IMyCalendar1
{
    private static readonly Comparer<(int Start, int End)> BookingStartComparer =
        Comparer<(int Start, int End)>.Create((left, right) => left.Start.CompareTo(right.Start));

    private readonly List<(int Start, int End)> _items = [];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool Book(int start, int end)
    {
        var item = (start, end);

        var index = _items.BinarySearch(item, BookingStartComparer);

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
}