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

public static class TreeNodeAssert
{
    public static void AreEqual(TreeNode? expectedTree, TreeNode? actualTree)
    {
        var queue = new Queue<(TreeNode? expected, TreeNode? actual)>();
        queue.Enqueue((expectedTree, actualTree));

        while (queue.Count > 0)
        {
            var (expected, actual) = queue.Dequeue();

            if (expected == null && actual == null)
            {
                continue;
            }

            if (expected == null || actual == null)
            {
                Assert.Fail("One of the trees is null while the other is not.");
            }

            Assert.AreEqual(expected.val, actual.val, "Values should be equal at each node.");

            queue.Enqueue((expected.left, actual.left));
            queue.Enqueue((expected.right, actual.right));
        }
    }

    public static void AreEqual(IList<TreeNode?>? expectedTrees, IList<TreeNode>? actualTrees)
    {
        if (expectedTrees == null && actualTrees == null)
        {
            return;
        }

        if (expectedTrees == null || actualTrees == null)
        {
            Assert.Fail("One of the tree lists is null while the other is not.");
        }

        Assert.AreEqual(expectedTrees.Count, actualTrees.Count, "Tree lists should have the same number of elements.");

        for (var i = 0; i < expectedTrees.Count; i++)
        {
            AreEqual(expectedTrees[i], actualTrees[i]);
        }
    }

    public static void AreEquivalent(IList<TreeNode?>? expectedTrees, IList<TreeNode>? actualTrees)
    {
        if (expectedTrees == null && actualTrees == null)
        {
            return;
        }

        if (expectedTrees == null || actualTrees == null)
        {
            Assert.Fail("One of the tree lists is null while the other is not.");
        }

        Assert.AreEqual(expectedTrees.Count, actualTrees.Count, "Tree lists should have the same number of elements.");

        var expectedQueue = new Queue<TreeNode?>(expectedTrees);
        var actualQueue = new Queue<TreeNode?>(actualTrees);

        while (expectedQueue.Count > 0)
        {
            var expectedTree = expectedQueue.Dequeue();
            var matchFound = false;

            foreach (var actualTree in actualQueue)
            {
                try
                {
                    AreEqual(expectedTree, actualTree);
                    actualQueue = new Queue<TreeNode?>(actualQueue.Where(t => t != actualTree));
                    matchFound = true;
                    break;
                }
                catch
                {
                    // Ignore and continue searching for a match
                }
            }

            if (!matchFound)
            {
                Assert.Fail("No matching tree found in the actual collection for the expected tree.");
            }
        }
    }
}