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

namespace LeetCode.Algorithms.FindMissingElements;

/// <inheritdoc />
public sealed class FindMissingElementsLookup : IFindMissingElements
{
    private const int MaxValue = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> FindMissingElements(int[] nums)
    {
        var n = nums.Length;

        Span<bool> seen = stackalloc bool[MaxValue + 1];

        var min = MaxValue + 1;
        var max = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            seen[num] = true;

            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        var missingElements = new List<int>();

        for (var i = min + 1; i < max; i++)
        {
            if (seen[i])
            {
                continue;
            }

            missingElements.Add(i);
        }

        return missingElements;
    }
}