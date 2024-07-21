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

using LeetCode.Algorithms.FindCorrespondingNodeOfBinaryTreeInCloneOfThatTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.FindCorrespondingNodeOfBinaryTreeInCloneOfThatTree;

public abstract class FindCorrespondingNodeOfBinaryTreeInCloneOfThatTreeTestsBase<T>
    where T : IFindCorrespondingNodeOfBinaryTreeInCloneOfThatTree, new()
{
    [TestMethod]
    [DataRow("[7]", 7, 7)]
    [DataRow("[7,4,3,null,null,6,19]", 3, 3)]
    [DataRow("[8,null,6,null,5,null,4,null,3,null,2,null,1]", 4, 4)]
    public void GetTargetCopy_GivenOriginalAndClonedTree_ReturnsCorrespondingNode(string treeJsonArray, int targetValue,
        int expectedResultValue)
    {
        // Arrange
        var treeArray = JsonHelper<int?>.JsonArrayToList(treeJsonArray);
        var original = TreeNode.BuildTree(treeArray) ?? throw new InvalidOperationException();
        var cloned = TreeNode.BuildTree(treeArray) ?? throw new InvalidOperationException();

        TreeNode? target = null;

        var targetStack = new Stack<TreeNode>();

        targetStack.Push(original);

        while (targetStack.Count > 0)
        {
            var node = targetStack.Pop();

            if (node.val == targetValue)
            {
                target = node;

                break;
            }

            if (node.left != null)
            {
                targetStack.Push(node.left);
            }

            if (node.right != null)
            {
                targetStack.Push(node.right);
            }
        }

        TreeNode? expectedResult = null;

        var expectedResultStack = new Stack<TreeNode>();

        expectedResultStack.Push(cloned);

        while (expectedResultStack.Count > 0)
        {
            var node = expectedResultStack.Pop();

            if (node.val == expectedResultValue)
            {
                expectedResult = node;

                break;
            }

            if (node.left != null)
            {
                expectedResultStack.Push(node.left);
            }

            if (node.right != null)
            {
                expectedResultStack.Push(node.right);
            }
        }

        var solution = new T();

        // Act
        var actualResult = solution.GetTargetCopy(original, cloned, target);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}