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

using LeetCode.Algorithms.SumOfRootToLeafBinaryNumbers;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SumOfRootToLeafBinaryNumbers;

public abstract class SumOfRootToLeafBinaryNumbersTestsBase<T> where T : ISumOfRootToLeafBinaryNumbers, new()
{
    [TestMethod]
    [DataRow("[0]", 0)]
    [DataRow("[1,0,1,0,1,0,1]", 22)]
    public void SumRootToLeaf_WithBinaryTreeInput_ReturnsSumOfRootToLeafBinaryNumbers(string rootJson,
        int expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper.Parse<int?[]>(rootJson);
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.SumRootToLeaf(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}