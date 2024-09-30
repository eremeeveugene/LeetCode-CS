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

    public void Push(int x)
    {
        if (_topIndex >= _stackArray.Length - 1)
        {
            return;
        }

        _topIndex++;

        _stackArray[_topIndex] = x;
    }

    public int Pop()
    {
        if (_topIndex >= 0)
        {
            return _stackArray[_topIndex--];
        }

        return -1;
    }

    public void Increment(int k, int val)
    {
        var limit = Math.Min(k, _topIndex + 1);

        for (var i = 0; i < limit; i++)
        {
            _stackArray[i] += val;
        }
    }
}