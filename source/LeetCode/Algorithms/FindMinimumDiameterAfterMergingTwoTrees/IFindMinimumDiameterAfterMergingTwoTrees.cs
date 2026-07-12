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

namespace LeetCode.Algorithms.FindMinimumDiameterAfterMergingTwoTrees;

/// <summary>
///     https://leetcode.com/problems/find-minimum-diameter-after-merging-two-trees/description/
/// </summary>
public interface IFindMinimumDiameterAfterMergingTwoTrees
{
    /// <summary>
    ///     Finds the minimum possible diameter of the tree obtained by connecting one node of the first tree with one node
    ///     of the second tree by an edge.
    /// </summary>
    /// <param name="edges1">The edges of the first tree.</param>
    /// <param name="edges2">The edges of the second tree.</param>
    /// <returns>The minimum possible diameter of the merged tree.</returns>
    int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2);
}