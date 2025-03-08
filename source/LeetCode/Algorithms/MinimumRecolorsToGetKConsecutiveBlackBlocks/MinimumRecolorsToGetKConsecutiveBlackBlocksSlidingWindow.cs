// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MinimumRecolorsToGetKConsecutiveBlackBlocks;

/// <inheritdoc />
public class MinimumRecolorsToGetKConsecutiveBlackBlocksSlidingWindow : IMinimumRecolorsToGetKConsecutiveBlackBlocks
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="blocks"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MinimumRecolors(string blocks, int k)
    {
        var blackCount = 0;

        for (var i = 0; i < k; i++)
        {
            if (blocks[i] == 'B')
            {
                blackCount++;
            }
        }

        var minimumRecolors = k - blackCount;

        for (var i = k; i < blocks.Length; i++)
        {
            if (blocks[i] == 'B')
            {
                blackCount++;
            }

            if (blocks[i - k] == 'B')
            {
                blackCount--;
            }

            minimumRecolors = Math.Min(minimumRecolors, k - blackCount);

            if (minimumRecolors == 0)
            {
                return 0;
            }
        }

        return minimumRecolors;
    }
}