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

namespace LeetCode.Algorithms.FindTheMaximumNumberOfElementsInSubset;

/// <inheritdoc />
public sealed class FindTheMaximumNumberOfElementsInSubsetDictionary : IFindTheMaximumNumberOfElementsInSubset
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * log(log(m))), where n is the length of the array and m is the maximum value.
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaximumLength(int[] nums)
    {
        var n = nums.Length;

        var numToCountsDictionary = new Dictionary<long, int>();

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            numToCountsDictionary.TryGetValue(num, out var count);

            numToCountsDictionary[num] = count + 1;
        }

        int maximumLength;

        if (numToCountsDictionary.TryGetValue(1, out var ones))
        {
            if (ones % 2 == 0)
            {
                maximumLength = ones - 1;
            }
            else
            {
                maximumLength = ones;
            }
        }
        else
        {
            maximumLength = 0;
        }

        foreach (var key in numToCountsDictionary.Keys)
        {
            if (key == 1)
            {
                continue;
            }

            var length = 0;

            var num = key;

            while (numToCountsDictionary.TryGetValue(num, out var count) && count >= 2)
            {
                length += 2;

                num *= num;
            }

            if (numToCountsDictionary.ContainsKey(num))
            {
                length += 1;
            }
            else
            {
                length += -1;
            }

            maximumLength = Math.Max(maximumLength, length);
        }

        return maximumLength;
    }
}