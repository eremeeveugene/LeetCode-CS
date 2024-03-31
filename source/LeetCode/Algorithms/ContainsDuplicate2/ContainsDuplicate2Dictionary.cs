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

namespace LeetCode.Algorithms.ContainsDuplicate2;

/// <inheritdoc />
public class ContainsDuplicate2Dictionary : IContainsDuplicate2
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var numsDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (numsDictionary.TryAdd(nums[i], i))
            {
                continue;
            }

            if (Math.Abs(numsDictionary[nums[i]] - i) <= k)
            {
                return true;
            }

            numsDictionary[nums[i]] = i;
        }

        return false;
    }
}