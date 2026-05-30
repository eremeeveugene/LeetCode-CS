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

using LeetCode.Algorithms.RecoverTreeFromPreorderTraversal;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RecoverTreeFromPreorderTraversal;

public abstract class RecoverTreeFromPreorderTraversalTestsBase<T> where T : IRecoverTreeFromPreorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RecoverFromPreorder_WithTraversalString_ConstructsBinaryTree(string traversal, int?[] expectedResultArray)
    {
        // Arrange
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RecoverFromPreorder(traversal);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return ["1-2--3--4-5--6--7", new int?[] { 1, 2, 5, 3, 4, 6, 7 }];

        yield return ["1-2--3---4-5--6---7", new int?[] { 1, 2, 5, 3, null, 6, null, 4, null, 7 }];

        yield return ["1-401--349---90--88", new int?[] { 1, 401, null, 349, 88, 90 }];
    }
}