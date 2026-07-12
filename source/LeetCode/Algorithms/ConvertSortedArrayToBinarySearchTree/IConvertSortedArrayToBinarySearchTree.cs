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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.ConvertSortedArrayToBinarySearchTree;

/// <summary>
///     https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/
/// </summary>
public interface IConvertSortedArrayToBinarySearchTree
{
    /// <summary>
    ///     Converts the sorted array <paramref name="nums" /> into a height-balanced binary search tree.
    /// </summary>
    /// <param name="nums">The array of integers sorted in ascending order.</param>
    /// <returns>The root node of the height-balanced binary search tree, or <c>null</c> if the array is empty.</returns>
    TreeNode? SortedArrayToBST(int[] nums);
}