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

namespace LeetCode.Algorithms.CountPairsWhoseSumIsLessThanTarget;

/// <inheritdoc />
public class CountPairsWhoseSumIsLessThanTargetIterative : ICountPairsWhoseSumIsLessThanTarget
{
    /// <summary>
    ///     Time complexity - O(n^2)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int CountPairs(IList<int> nums, int target)
    {
        var count = 0;

        for (var i = 0; i < nums.Count - 1; i++)
        {
            for (var j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] + nums[j] < target)
                {
                    count++;
                }
            }
        }

        return count;
    }
}