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

namespace LeetCode.Algorithms.MinimumRecolorsToGetKConsecutiveBlackBlocks;

/// <summary>
///     https://leetcode.com/problems/minimum-recolors-to-get-k-consecutive-black-blocks/description/
/// </summary>
public interface IMinimumRecolorsToGetKConsecutiveBlackBlocks
{
    /// <summary>
    ///     Finds the minimum number of white blocks ('W') that must be recolored to black ('B') so that some window
    ///     of <paramref name="k" /> consecutive blocks in <paramref name="blocks" /> are all black.
    /// </summary>
    /// <param name="blocks">The string of 'B' and 'W' characters representing the blocks.</param>
    /// <param name="k">The length of the consecutive window of blocks that must all be black.</param>
    /// <returns>The minimum number of recolor operations required.</returns>
    int MinimumRecolors(string blocks, int k);
}