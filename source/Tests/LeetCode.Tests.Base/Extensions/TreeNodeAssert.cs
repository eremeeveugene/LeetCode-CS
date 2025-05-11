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

using LeetCode.Core.Models;
using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Tests.Base.Extensions;

[ExcludeFromCodeCoverage]
public static class TreeNodeAssert
{
    public static void AreEqual(TreeNode? expectedTree, TreeNode? actualTree)
    {
        var queue = new Queue<(TreeNode? expectedResult, TreeNode? actualResult)>();
        queue.Enqueue((expectedTree, actualTree));

        while (queue.Count > 0)
        {
            var (expectedResult, actualResult) = queue.Dequeue();

            if (expectedResult == null && actualResult == null)
            {
                continue;
            }

            if (expectedResult == null || actualResult == null)
            {
                Assert.Fail("One of the trees is null while the other is not.");
            }

            Assert.AreEqual(expectedResult.val, actualResult.val, "Values should be equal at each node.");

            queue.Enqueue((expectedResult.left, actualResult.left));
            queue.Enqueue((expectedResult.right, actualResult.right));
        }
    }

    public static void AreEqual(IEnumerable<TreeNode?>? expectedTrees, IEnumerable<TreeNode?>? actualTrees)
    {
        if (expectedTrees == null && actualTrees == null)
        {
            return;
        }

        if (expectedTrees == null || actualTrees == null)
        {
            Assert.Fail("One of the tree collections is null while the other is not.");
        }

        var expectedList = expectedTrees.ToList();
        var actualList = actualTrees.ToList();

        Assert.AreEqual(expectedList.Count, actualList.Count,
            "Tree collections should have the same number of elements.");

        for (var i = 0; i < expectedList.Count; i++)
        {
            AreEqual(expectedList[i], actualList[i]);
        }
    }

    public static void AreEquivalent(IEnumerable<TreeNode?>? expectedTrees, IEnumerable<TreeNode?>? actualTrees)
    {
        if (expectedTrees == null && actualTrees == null)
        {
            return;
        }

        if (expectedTrees == null || actualTrees == null)
        {
            Assert.Fail("One of the tree collections is null while the other is not.");
        }

        var expectedList = expectedTrees.ToList();
        var actualList = actualTrees.ToList();

        Assert.AreEqual(expectedList.Count, actualList.Count,
            "Tree collections should have the same number of elements.");

        var actualQueue = new Queue<TreeNode?>(actualList);

        foreach (var expectedTree in expectedList)
        {
            var matchFound = false;

            for (var i = 0; i < actualQueue.Count; i++)
            {
                var actualTree = actualQueue.ElementAt(i);
                try
                {
                    AreEqual(expectedTree, actualTree);
                    // Remove matched tree
                    actualQueue = new Queue<TreeNode?>(actualQueue.Where((_, index) => index != i));
                    matchFound = true;
                    break;
                }
                catch
                {
                    // Continue checking other trees
                }
            }

            if (!matchFound)
            {
                Assert.Fail("No matching tree found in the actual collection for the expected tree.");
            }
        }
    }
}