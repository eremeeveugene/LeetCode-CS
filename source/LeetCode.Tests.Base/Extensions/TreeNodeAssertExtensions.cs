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

namespace LeetCode.Tests.Base.Extensions;

public static class TreeNodeAssertExtensions
{
    public static void AreEqual(TreeNode? expected, TreeNode? actual, string message = "")
    {
        if (!AreTreesEqual(expected, actual))
        {
            throw new AssertFailedException($"Assert.AreEqual failed. {message}");
        }
    }

    public static void AreNotEqual(TreeNode? expected, TreeNode? actual, string message = "")
    {
        if (AreTreesEqual(expected, actual))
        {
            throw new AssertFailedException($"Assert.AreNotEqual failed. {message}");
        }
    }

    private static bool AreTreesEqual(TreeNode? x, TreeNode? y)
    {
        if (x == null && y == null)
        {
            return true;
        }

        if (x == null || y == null || x.val != y.val)
        {
            return false;
        }

        return AreTreesEqual(x.left, y.left) && AreTreesEqual(x.right, y.right);
    }
}