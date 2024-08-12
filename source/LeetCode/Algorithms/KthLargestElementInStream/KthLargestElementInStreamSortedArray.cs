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

namespace LeetCode.Algorithms.KthLargestElementInStream;

/// <inheritdoc />
public class KthLargestElementInStreamSortedArray : IKthLargestElementInStream
{
    private readonly int _k;
    private readonly int[] _nums;

    public KthLargestElementInStreamSortedArray(int k, int[] nums)
    {
        _k = k;

        var newNums = new int[k];

        Array.Fill(newNums, int.MinValue);

        if (nums.Length > 0)
        {
            Array.Sort(nums, (a, b) => b.CompareTo(a));

            var i = 0;

            while (i < nums.Length && i < k)
            {
                newNums[i] = nums[i];

                i++;
            }
        }

        _nums = newNums;
    }

    /// <summary>
    ///     Time complexity - O(k)
    ///     Space complexity - O(k)
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public int Add(int val)
    {
        for (var i = 0; i < _nums.Length; i++)
        {
            if (_nums[i] < val)
            {
                (_nums[i], val) = (val, _nums[i]);
            }
        }

        return _nums[_k - 1];
    }
}