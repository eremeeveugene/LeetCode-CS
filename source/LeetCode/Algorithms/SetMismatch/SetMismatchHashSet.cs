// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.SetMismatch;

/// <inheritdoc />
public sealed class SetMismatchHashSet : ISetMismatch
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] FindErrorNums(int[] nums)
    {
        var duplicate = 0;
        var missing = 0;

        var duplicatesHashSet = new HashSet<int>();
        var numsHashSet = new HashSet<int>(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            if (!duplicatesHashSet.Add(nums[i]))
            {
                duplicate = nums[i];
            }

            var number = i + 1;

            if (!numsHashSet.Contains(number))
            {
                missing = number;
            }
        }

        return [duplicate, missing];
    }
}