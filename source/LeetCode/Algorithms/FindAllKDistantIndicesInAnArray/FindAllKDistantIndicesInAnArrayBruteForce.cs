// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindAllKDistantIndicesInAnArray;

/// <inheritdoc />
public class FindAllKDistantIndicesInAnArrayBruteForce : IFindAllKDistantIndicesInAnArray
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="key"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var result = new List<int>();

        for (var i = 0; i < nums.Length; ++i)
        {
            for (var j = 0; j < nums.Length; ++j)
            {
                if (nums[j] != key || Math.Abs(i - j) > k)
                {
                    continue;
                }

                result.Add(i);

                break;
            }
        }

        return result;
    }
}