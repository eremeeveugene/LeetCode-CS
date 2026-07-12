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

namespace LeetCode.Algorithms.FirstMissingPositive;

/// <inheritdoc />
public sealed class FirstMissingPositiveHashSet : IFirstMissingPositive
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int FirstMissingPositive(int[] nums)
    {
        var numsHashSet = new HashSet<int>(nums);

        var missingPositive = 1;

        while (numsHashSet.Contains(missingPositive))
        {
            missingPositive++;
        }

        return missingPositive;
    }
}