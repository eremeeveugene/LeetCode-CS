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

namespace LeetCode.Algorithms.HeightChecker;

/// <inheritdoc />
public class HeightCheckerCounting : IHeightChecker
{
    /// <summary>
    ///     Time complexity - O(n + k), where n is the number of elements in the input array and k is the range of the input
    ///     values
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="heights"></param>
    /// <returns></returns>
    public int HeightChecker(int[] heights)
    {
        var maxHeight = heights.Max();

        var count = new int[maxHeight + 1];

        foreach (var height in heights)
        {
            count[height]++;
        }

        var result = 0;
        var currentHeight = 0;

        foreach (var height in heights)
        {
            while (count[currentHeight] == 0)
            {
                currentHeight++;
            }

            if (currentHeight != height)
            {
                result++;
            }

            count[currentHeight]--;
        }

        return result;
    }
}