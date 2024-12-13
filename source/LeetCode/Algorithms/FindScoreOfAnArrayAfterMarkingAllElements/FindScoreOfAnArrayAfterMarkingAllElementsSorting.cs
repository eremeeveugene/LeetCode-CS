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

namespace LeetCode.Algorithms.FindScoreOfAnArrayAfterMarkingAllElements;

/// <inheritdoc />
public class FindScoreOfAnArrayAfterMarkingAllElementsSorting : IFindScoreOfAnArrayAfterMarkingAllElements
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public long FindScore(int[] nums)
    {
        long score = 0;
        var markedElements = new bool[nums.Length];

        var elements = nums.Select((value, index) => (Value: value, Index: index))
            .OrderBy(e => e.Value)
            .ThenBy(e => e.Index);

        foreach (var (value, index) in elements)
        {
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