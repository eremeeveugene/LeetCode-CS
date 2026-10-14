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

namespace LeetCode.Algorithms.FindAllDuplicatesInAnArray;

/// <inheritdoc />
public sealed class FindAllDuplicatesInAnArrayHashSet : IFindAllDuplicatesInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<int> FindDuplicates(int[] nums)
    {
        var numsHashSet = new HashSet<int>();

        var duplicates = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!numsHashSet.Add(num))
            {
                duplicates.Add(num);
            }
        }

        return duplicates;
    }
}