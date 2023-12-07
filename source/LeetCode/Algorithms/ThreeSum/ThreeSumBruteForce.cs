// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.EqualityComparers;

namespace LeetCode.Algorithms.ThreeSum;

/// <summary>
///     Three Sum
///     https://leetcode.com/problems/3sum/
///     Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k,
///     and j != k, and nums[i] + nums[j] + nums[k] == 0.
///     Notice that the solution set must not contain duplicate triplets.
///     Example 1:
///     Input: nums = [-1,0,1,2,-1,-4]
///     Output: [[-1,-1,2],[-1,0,1]]
///     Explanation:
///     nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
///     nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
///     nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
///     The distinct triplets are [-1,0,1] and [-1,-1,2].
///     Notice that the order of the output and the order of the triplets does not matter.
///     Example 2:
///     Input: nums = [0,1,1]
///     Output: []
///     Explanation: The only possible triplet does not sum up to 0.
///     Example 3:
///     Input: nums = [0,0,0]
///     Output: [[0,0,0]]
///     Explanation: The only possible triplet sums up to 0.
///     Constraints:
///     3 less than or equal to nums.length less than or equal to 3000
///     -105 less than or equal to nums[i] less than or equal to 105
/// </summary>
public static class ThreeSumBruteForce
{
    /// <summary>
    ///     Time complexity - O (n^3)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static IList<IList<int>> GetResult(int[] nums)
    {
        var arraysWithDuplicates = new List<IList<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
        for (var j = i + 1; j < nums.Length - 1; j++)
        for (var k = j + 1; k < nums.Length; k++)
            if (nums[i] + nums[j] + nums[k] == 0)
                arraysWithDuplicates.Add(new[] { nums[i], nums[j], nums[k] });

        var uniqueArrays = new HashSet<int[]>(new OrderInsensitiveIntArrayEqualityComparer());

        foreach (var array in arraysWithDuplicates) uniqueArrays.Add(array.ToArray());

        return uniqueArrays.Cast<IList<int>>().ToList();
    }
}