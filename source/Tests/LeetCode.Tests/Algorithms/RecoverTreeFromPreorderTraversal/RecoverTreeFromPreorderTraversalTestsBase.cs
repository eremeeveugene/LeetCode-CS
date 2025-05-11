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

using LeetCode.Algorithms.RecoverTreeFromPreorderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RecoverTreeFromPreorderTraversal;

public abstract class RecoverTreeFromPreorderTraversalTestsBase<T> where T : IRecoverTreeFromPreorderTraversal, new()
{
    [TestMethod]
    [DataRow("1-2--3--4-5--6--7", "[1,2,5,3,4,6,7]")]
    [DataRow("1-2--3---4-5--6---7", "[1,2,5,3,null,6,null,4,null,7]")]
    [DataRow("1-401--349---90--88", "[1,401,null,349,88,90]")]
    public void RecoverFromPreorder_WithTraversalString_ConstructsBinaryTree(string traversal,
        string expectedResultJson)
    {
        // Arrange
        var expectedResultArray = JsonHelper<int?[]>.Parse(expectedResultJson);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RecoverFromPreorder(traversal);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}