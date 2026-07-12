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

namespace LeetCode.Algorithms.FindAllGroupOfFarmland;

/// <summary>
///     https://leetcode.com/problems/find-all-groups-of-farmland/
/// </summary>
public interface IFindAllGroupOfFarmland
{
    /// <summary>
    ///     Finds all rectangular groups of farmland in the binary matrix <paramref name="land" /> and returns the
    ///     coordinates of the top-left and bottom-right corners of each group.
    /// </summary>
    /// <param name="land">The binary matrix where 1 represents farmland and 0 represents forested land.</param>
    /// <returns>An array of coordinates [r1, c1, r2, c2] describing each group of farmland.</returns>
    int[][] FindFarmland(int[][] land);
}