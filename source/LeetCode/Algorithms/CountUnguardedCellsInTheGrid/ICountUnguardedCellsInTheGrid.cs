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

namespace LeetCode.Algorithms.CountUnguardedCellsInTheGrid;

/// <summary>
///     https://leetcode.com/problems/count-unguarded-cells-in-the-grid/description/
/// </summary>
public interface ICountUnguardedCellsInTheGrid
{
    int CountUnguarded(int m, int n, int[][] guards, int[][] walls);
}