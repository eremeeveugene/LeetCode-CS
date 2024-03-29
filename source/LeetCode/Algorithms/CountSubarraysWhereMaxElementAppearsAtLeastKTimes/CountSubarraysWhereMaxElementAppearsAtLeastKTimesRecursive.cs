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

namespace LeetCode.Algorithms.CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

/// <inheritdoc />
public class CountSubarraysWhereMaxElementAppearsAtLeastKTimesRecursive :
    ICountSubarraysWhereMaxElementAppearsAtLeastKTimes
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long CountSubarrays(int[] nums, int k)
    {
        var actualDuplicates = new List<List<int>>();

        return CountSubarrays(nums, k, 0, nums.Length, actualDuplicates) +
               CountSubarrays(nums, k, 0, nums.Length, actualDuplicates);
    }

    private static long CountSubarrays(IReadOnlyList<int> nums, int k, int left, int right,
        ICollection<List<int>> actualDuplicates)
    {
        if (left > right)
        {
            return 0;
        }

        var positionsDictionary = new Dictionary<int, int>();

        var isSubarray = false;

        var currentSubarray = nums.Skip(left).Take(right - left).ToList();

        for (var i = left; i < right; i++)
        {
            if (positionsDictionary.TryAdd(nums[i], 1))
            {
                continue;
            }

            positionsDictionary[nums[i]]++;

            if (positionsDictionary[nums[i]] != k || actualDuplicates.Any(l => l.SequenceEqual(currentSubarray)))
            {
                continue;
            }

            actualDuplicates.Add(currentSubarray);

            isSubarray = true;

            break;
        }

        var count = CountSubarrays(nums, k, left + 1, right, actualDuplicates) +
                    CountSubarrays(nums, k, left, right - 1, actualDuplicates);

        if (isSubarray)
        {
            count++;
        }

        return count;
    }
}