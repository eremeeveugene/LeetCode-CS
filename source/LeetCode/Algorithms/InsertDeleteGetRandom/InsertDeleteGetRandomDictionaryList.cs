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

namespace LeetCode.Algorithms.InsertDeleteGetRandom;

/// <inheritdoc />
public sealed class InsertDeleteGetRandomDictionaryList : IInsertDeleteGetRandom
{
    private static readonly Random Random = new();
    private readonly List<int> _values = [];
    private readonly Dictionary<int, int> _valueToIndexDictionary = [];

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool Insert(int value)
    {
        if (_valueToIndexDictionary.ContainsKey(value))
        {
            return false;
        }

        _valueToIndexDictionary.Add(value, _values.Count);
        _values.Add(value);

        return true;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool Remove(int value)
    {
        if (!_valueToIndexDictionary.TryGetValue(value, out var index))
        {
            return false;
        }

        var lastValueIndex = _values.Count - 1;
        var lastValue = _values[lastValueIndex];

        _values[index] = lastValue;
        _values.RemoveAt(lastValueIndex);

        _valueToIndexDictionary[lastValue] = index;
        _valueToIndexDictionary.Remove(value);

        return true;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public int GetRandom()
    {
        var randomIndex = Random.Next(_values.Count);

        return _values[randomIndex];
    }
}