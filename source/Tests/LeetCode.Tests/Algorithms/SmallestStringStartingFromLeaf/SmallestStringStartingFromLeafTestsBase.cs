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

using LeetCode.Algorithms.SmallestStringStartingFromLeaf;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SmallestStringStartingFromLeaf;

public abstract class SmallestStringStartingFromLeafTestsBase<T> where T : ISmallestStringStartingFromLeaf, new()
{
    [TestMethod]
    [DataRow("[0,1,2,3,4,3,4]", "dba")]
    [DataRow("[25,1,3,1,3,0,2]", "adz")]
    [DataRow("[2,2,1,null,1,0,null,0]", "abc")]
    public void SmallestFromLeaf_WithDifferentTreeConfigurations_ReturnsSmallestLexicographicalStringFromLeaf(
        string jsonArrayRoot, string? expectedResult)
    {
        // Arrange
        IList<int?> arrayRoot = JsonHelper<int?>.JsonArrayToList(jsonArrayRoot);
        var root = TreeNode.BuildTree(arrayRoot);

        var solution = new T();

        // Act
        var actualResult = solution.SmallestFromLeaf(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}