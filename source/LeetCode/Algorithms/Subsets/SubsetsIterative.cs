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

namespace LeetCode.Algorithms.Subsets;

/// <inheritdoc />
public class SubsetsIterative : ISubsets
{
    /// <summary>
    ///     Time complexity - O(n * 2^n)
    ///     Space complexity - O(n * 2^n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Subsets(int[] nums)
    {
        var subsets = new List<IList<int>> { new List<int>() };

        foreach (var num in nums)
        {
            var size = subsets.Count;

            for (var i = 0; i < size; i++)
            {
                var newSubset = new List<int>();

                newSubset.AddRange(subsets[i]);
                newSubset.Add(num);

                subsets.Add(newSubset);
            }
        }

        return subsets;
    }
}