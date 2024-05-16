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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.ConvertSortedArrayToBinarySearchTree;

/// <inheritdoc />
public class ConvertSortedArrayToBinarySearchTreeRecursive : IConvertSortedArrayToBinarySearchTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public TreeNode? SortedArrayToBST(int[] nums)
    {
        return CreateNode(nums, 0, nums.Length - 1);
    }

    private static TreeNode? CreateNode(IReadOnlyList<int> nums, int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        var mid = left + ((right - left) / 2);

        return new TreeNode(nums[mid], CreateNode(nums, left, mid - 1), CreateNode(nums, mid + 1, right));
    }
}