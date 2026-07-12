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

namespace LeetCode.Algorithms.DesignNumberContainerSystem;

/// <inheritdoc />
public sealed class DesignNumberContainerSystemDictionary : IDesignNumberContainerSystem
{
    private readonly Dictionary<int, int> _indexToNumber = [];
    private readonly Dictionary<int, SortedSet<int>> _numberToIndices = [];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public void Change(int index, int number)
    {
        if (_indexToNumber.TryGetValue(index, out var existingNumber))
        {
            if (existingNumber == number)
            {
                return;
            }

            if (_numberToIndices.TryGetValue(existingNumber, out var existingNumberIndices))
            {
                existingNumberIndices.Remove(index);

                if (existingNumberIndices.Count == 0)
                {
                    _numberToIndices.Remove(existingNumber);
                }
            }
        }

        _indexToNumber[index] = number;

        if (!_numberToIndices.TryGetValue(number, out var numberIndices))
        {
            numberIndices = [];

            _numberToIndices[number] = numberIndices;
        }

        numberIndices.Add(index);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </remarks>
    public int Find(int number)
    {
        if (_numberToIndices.TryGetValue(number, out var numberIndices) && numberIndices.Count > 0)
        {
            return numberIndices.Min;
        }

        return -1;
    }
}