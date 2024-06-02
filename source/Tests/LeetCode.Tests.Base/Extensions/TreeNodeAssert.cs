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
}