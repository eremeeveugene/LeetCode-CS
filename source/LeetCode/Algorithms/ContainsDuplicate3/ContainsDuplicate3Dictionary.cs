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

namespace LeetCode.Algorithms.ContainsDuplicate3;

/// <inheritdoc />
public sealed class ContainsDuplicate3Dictionary : IContainsDuplicate3
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(min(n, k)),where k is the maximum number of elements the dictionary can hold at any one time
    ///     based on the indexDiff
    /// </remarks>
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        if (indexDiff <= 0 || valueDiff < 0)
        {
            return false;
        }

        var numsDictionary = new Dictionary<long, long>();

        var w = (long)valueDiff + 1;

        for (var i = 0; i < nums.Length; i++)
        {
            var m = GetId(nums[i], w);

            if (numsDictionary.ContainsKey(m) ||
                (numsDictionary.ContainsKey(m - 1) && Math.Abs(nums[i] - numsDictionary[m - 1]) < w) ||
                (numsDictionary.ContainsKey(m + 1) && Math.Abs(nums[i] - numsDictionary[m + 1]) < w))
            {
                return true;
            }

            if (i >= indexDiff)
            {
                var oldBucket = GetId(nums[i - indexDiff], w);

                numsDictionary.Remove(oldBucket);
            }

            numsDictionary[m] = nums[i];
        }

        return false;
    }

    private static long GetId(long x, long w)
    {
        return x < 0 ? ((x + 1) / w) - 1 : x / w;
    }
}