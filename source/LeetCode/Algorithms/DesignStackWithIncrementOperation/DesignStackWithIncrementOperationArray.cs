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

namespace LeetCode.Algorithms.DesignStackWithIncrementOperation;

/// <inheritdoc />
public class DesignStackWithIncrementOperationArray(int maxSize) : IDesignStackWithIncrementOperation
{
    private readonly int[] _stackArray = new int[maxSize];
    private int _topIndex = -1;

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    public void Push(int x)
    {
        if (_topIndex >= _stackArray.Length - 1)
        {
            return;
        }

        _topIndex++;

        _stackArray[_topIndex] = x;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public int Pop()
    {
        if (_topIndex < 0)
        {
            return -1;
        }

        return _stackArray[_topIndex--];
    }

    /// <summary>
    ///     Time complexity - O(min(k,n))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="k"></param>
    /// <param name="val"></param>
    public void Increment(int k, int val)
    {
        for (var i = 0; i < Math.Min(k, _topIndex + 1); i++)
        {
            _stackArray[i] += val;
        }
    }
}