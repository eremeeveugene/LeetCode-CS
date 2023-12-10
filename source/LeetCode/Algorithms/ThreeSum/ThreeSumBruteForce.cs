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
///     https://leetcode.com/problems/3sum/
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
        List<IList<int>> arraysWithDuplicates = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        arraysWithDuplicates.Add(new[] { nums[i], nums[j], nums[k] });
                    }
                }
            }
        }

        HashSet<int[]> uniqueArrays = new HashSet<int[]>(new OrderInsensitiveIntArrayEqualityComparer());

        foreach (IList<int> array in arraysWithDuplicates)
        {
            uniqueArrays.Add(array.ToArray());
        }

        return uniqueArrays.Cast<IList<int>>().ToList();
    }
}