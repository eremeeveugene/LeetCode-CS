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

namespace LeetCode.Algorithms.MyCalendar3;

/// <inheritdoc />
public sealed class MyCalendar3FrequencyDictionary : IMyCalendar3
{
    private readonly SortedDictionary<int, int> _frequencyDictionary = new();
    private int _maxFrequency;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <returns></returns>
    public int Book(int startTime, int endTime)
    {
        if (!_frequencyDictionary.TryAdd(startTime, 1))
        {
            _frequencyDictionary[startTime]++;
        }

        if (!_frequencyDictionary.TryAdd(endTime, 0))
        {
            _frequencyDictionary[endTime]--;
        }
        else
        {
            _frequencyDictionary[endTime] -= 1;
        }

        var currentFrequency = 0;

        foreach (var frequency in _frequencyDictionary.Values)
        {
            currentFrequency += frequency;

            _maxFrequency = Math.Max(_maxFrequency, currentFrequency);
        }

        return _maxFrequency;
    }
}