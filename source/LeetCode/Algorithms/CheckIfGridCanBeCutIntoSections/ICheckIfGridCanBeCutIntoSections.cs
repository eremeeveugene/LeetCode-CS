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

namespace LeetCode.Algorithms.CheckIfGridCanBeCutIntoSections;

/// <summary>
///     https://leetcode.com/problems/check-if-grid-can-be-cut-into-sections/description/
/// </summary>
public interface ICheckIfGridCanBeCutIntoSections
{
    bool CheckValidCuts(int n, int[][] rectangles);
}