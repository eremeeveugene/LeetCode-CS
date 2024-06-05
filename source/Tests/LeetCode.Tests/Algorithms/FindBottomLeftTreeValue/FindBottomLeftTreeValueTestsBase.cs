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

using LeetCode.Algorithms.FindBottomLeftTreeValue;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindBottomLeftTreeValue;

public abstract class FindBottomLeftTreeValueTestsBase<T> where T : IFindBottomLeftTreeValue, new()
{
    [TestMethod]
    [DataRow("[]", 0)]
    [DataRow("[2,1,3]", 1)]
    [DataRow("[1,2,3,4,null,5,6,null,null,7]", 7)]
    [DataRow("[1,null,1]", 1)]
    [DataRow("[1,2,3,4,null,5,6,null,null,7, null, 8, 9, null, null, null, null, null, 10]", 10)]
    public void FindBottomLeftValue_GivenBinaryTreeJsonArray_ReturnsBottomLeftValue(string jsonArrayRoot,
        int expectedResult)
    {
        // Arrange
        var arrayRoot = JsonHelper<int?>.JsonArrayToList(jsonArrayRoot);
        var root = TreeNode.BuildTree(arrayRoot);

        var solution = new T();

        // Act
        var actualResult = solution.FindBottomLeftValue(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}