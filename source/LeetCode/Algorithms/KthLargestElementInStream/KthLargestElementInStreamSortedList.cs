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
public class KthLargestElementInStreamSortedList(int k, IEnumerable<int> nums) : IKthLargestElementInStream
{
    private readonly List<int> _nums = [.. nums.OrderDescending()];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public int Add(int val)
    {
        Insert(val);

        return _nums.ElementAt(k - 1);
    }

    private void Insert(int val)
    {
        for (var i = 0; i < _nums.Count; i++)
        {
            var sortedNum = _nums[i];

            if (sortedNum > val)
            {
                continue;
            }

            _nums.Insert(i, val);

            return;
        }

        _nums.Add(val);
    }
}