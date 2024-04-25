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

namespace LeetCode.Algorithms.DesignAnOrderedStream;

/// <inheritdoc />
public class DesignAnOrderedStreamArray(int n) : IDesignAnOrderedStream
{
    private readonly string?[] _stream = new string[n];
    private int _pointer;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="idKey"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public IList<string?> Insert(int idKey, string value)
    {
        var result = new List<string?>();

        _stream[idKey - 1] = value;

        while (_pointer < _stream.Length && _stream[_pointer] != null)
        {
            result.Add(_stream[_pointer]);
            _pointer++;
        }

        return result;
    }
}