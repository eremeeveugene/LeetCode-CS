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

namespace LeetCode.Algorithms.CountElementsWithStrictlySmallerAndGreaterElements;

/// <inheritdoc />
public sealed class CountElementsWithStrictlySmallerAndGreaterElementsIterative :
    ICountElementsWithStrictlySmallerAndGreaterElements
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int CountElements(int[] nums)
    {
        if (nums.Length < 3)
        {
            return 0;
        }

        var min = int.MaxValue;
        var max = int.MinValue;

        foreach (var num in nums)
        {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        return nums.Count(num => num > min && num < max);
    }
}