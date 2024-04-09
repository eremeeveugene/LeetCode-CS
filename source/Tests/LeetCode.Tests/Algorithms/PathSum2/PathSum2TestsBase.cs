﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.PathSum2;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Algorithms.PathSum2;

public abstract class PathSum2TestsBase<T> where T : IPathSum2, new()
{
    [TestMethod]
    [DataRow("[5,4,8,11,null,13,4,7,2,null,null,5,1]", 22, "[[5,4,11,2],[5,8,4,5]]")]
    [DataRow("[1,2,3]", 5, "[]")]
    [DataRow("[1,2]", 0, "[]")]
    public void PathSum_GivenTreeAndTargetSum_ReturnsExpectedPaths(string jsonRootArray, int targetSum,
        string expectedJsonResult)
    {
        // Arrange
        var expectedResult = JsonConvertHelper<int>.JsonArrayToJaggedList(expectedJsonResult);

        var solution = new T();

        IList<int?> rootArray = JsonConvertHelper<int?>.JsonArrayToList(jsonRootArray);
        var root = TreeNode.BuildTree(rootArray);

        // Act
        var actualResult = solution.PathSum(root, targetSum);

        // Assert
        AssertExtensions.AssertJaggedArrayEqual(expectedResult, actualResult);
    }
}