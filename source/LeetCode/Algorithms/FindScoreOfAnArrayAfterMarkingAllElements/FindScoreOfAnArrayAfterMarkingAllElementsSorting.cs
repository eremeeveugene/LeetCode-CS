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

namespace LeetCode.Algorithms.FindScoreOfAnArrayAfterMarkingAllElements;

/// <inheritdoc />
public sealed class FindScoreOfAnArrayAfterMarkingAllElementsSorting : IFindScoreOfAnArrayAfterMarkingAllElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public long FindScore(int[] nums)
    {
        long score = 0;
        var markedElements = new bool[nums.Length];

        var elements = new (int Value, int Index)[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            elements[i] = (nums[i], i);
        }

        Array.Sort(elements, (a, b) => a.Value != b.Value ? a.Value.CompareTo(b.Value) : a.Index.CompareTo(b.Index));

        for (var i = 0; i < elements.Length; i++)
        {
            var (value, index) = elements[i];

            if (markedElements[index])
            {
                continue;
            }

            score += value;
            markedElements[index] = true;

            if (index > 0)
            {
                markedElements[index - 1] = true;
            }

            if (index < nums.Length - 1)
            {
                markedElements[index + 1] = true;
            }
        }

        return score;
    }
}