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

namespace LeetCode.Algorithms.RangeSumQueryMutable;

/// <inheritdoc />
public class RangeSumQueryMutableSegmentTree : IRangeSumQueryMutable
{
    private readonly int _n;
    private readonly int[] _tree;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    public RangeSumQueryMutableSegmentTree(int[] nums)
    {
        _n = nums.Length;

        _tree = new int[_n * 2];

        for (var i = 0; i < _n; i++)
        {
            _tree[i + _n] = nums[i];
        }

        for (var i = _n - 1; i >= 1; i--)
        {
            var left = i * 2;
            var right = left + 1;

            _tree[i] = _tree[left] + _tree[right];
        }
    }

    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="index"></param>
    /// <param name="val"></param>
    public void Update(int index, int val)
    {
        var i = index + _n;

        _tree[i] = val;

        while (i > 1)
        {
            i /= 2;

            var left = i * 2;
            var right = left + 1;

            _tree[i] = _tree[left] + _tree[right];
        }
    }

    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public int SumRange(int left, int right)
    {
        var sum = 0;

        var leftIndex = left + _n;
        var rightIndex = right + _n;

        while (leftIndex <= rightIndex)
        {
            if (leftIndex % 2 == 1)
            {
                sum += _tree[leftIndex];

                leftIndex++;
            }

            if (rightIndex % 2 == 0)
            {
                sum += _tree[rightIndex];

                rightIndex--;
            }

            leftIndex /= 2;
            rightIndex /= 2;
        }

        return sum;
    }
}