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

namespace LeetCode.Algorithms.TheNumberOfBeautifulSubsets;

/// <inheritdoc />
public class TheNumberOfBeautifulSubsetsBacktracking : ITheNumberOfBeautifulSubsets
{
    /// <summary>
    ///     Time complexity - O(n * 2^n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int BeautifulSubsets(int[] nums, int k)
    {
        if (nums.Length <= 1)
        {
            return nums.Length;
        }

        var count = 0;

        Backtrack(nums, k, 0, new List<int>(), ref count);

        return count - 1;
    }

    private static void Backtrack(IReadOnlyList<int> nums, int k, int index, IList<int> subset, ref int count)
    {
        while (true)
        {
            if (index >= nums.Count)
            {
                count++;

                return;
            }

            if (!subset.Contains(nums[index] - k) && !subset.Contains(k + nums[index]))
            {
                subset.Add(nums[index]);

                Backtrack(nums, k, index + 1, subset, ref count);

                subset.RemoveAt(subset.Count - 1);
            }

            index += 1;
        }
    }
}