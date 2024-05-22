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

namespace LeetCode.Algorithms.Permutations;

/// <inheritdoc />
public class PermutationsBacktracking : IPermutations
{
    /// <summary>
    ///     Time complexity - O(n * n!)
    ///     Space complexity - O(n * n!)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();

        Backtrack(nums, 0, nums.Length, result);

        return result;
    }

    private static void Backtrack(IList<int> nums, int start, int end, ICollection<IList<int>> result)
    {
        if (start == end)
        {
            result.Add(new List<int>(nums));
        }
        else
        {
            for (var i = start; i < end; i++)
            {
                (nums[i], nums[start]) = (nums[start], nums[i]);

                Backtrack(nums, start + 1, end, result);

                (nums[i], nums[start]) = (nums[start], nums[i]);
            }
        }
    }
}