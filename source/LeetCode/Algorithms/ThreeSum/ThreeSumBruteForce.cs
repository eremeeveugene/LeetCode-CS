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

using LeetCode.Core.EqualityComparers;

namespace LeetCode.Algorithms.ThreeSum;

/// <inheritdoc />
public class ThreeSumBruteForce : IThreeSum
{
    /// <summary>
    ///     Time complexity - O (n^3)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> arraysWithDuplicates = [];

        for (var i = 0; i < nums.Length - 2; i++)
        {
            for (var j = i + 1; j < nums.Length - 1; j++)
            {
                for (var k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        arraysWithDuplicates.Add(new[] { nums[i], nums[j], nums[k] });
                    }
                }
            }
        }

        HashSet<int[]> uniqueArrays = new(new OrderInsensitiveIntArrayEqualityComparer());

        uniqueArrays.UnionWith(arraysWithDuplicates.Select(array => array.ToArray()));

        return uniqueArrays.Cast<IList<int>>().ToList();
    }
}