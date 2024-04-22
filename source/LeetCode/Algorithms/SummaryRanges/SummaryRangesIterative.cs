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

namespace LeetCode.Algorithms.SummaryRanges;

/// <inheritdoc />
public class SummaryRangesIterative : ISummaryRanges
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0)
        {
            return new List<string>();
        }

        var ranges = new List<string>();

        var start = nums[0];
        var end = start;

        for (var i = 1; i < nums.Length; i++)
        {
            if (end + 1 == nums[i])
            {
                end = nums[i];
            }
            else
            {
                ranges.Add(GetRangeString(start, end));

                start = nums[i];
                end = start;
            }
        }

        ranges.Add(GetRangeString(start, end));

        return ranges;
    }

    private static string GetRangeString(int start, int end)
    {
        return start == end ? start.ToString() : $"{start}->{end}";
    }
}