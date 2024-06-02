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

using LeetCode.Algorithms.PathSum;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.PathSum;

public abstract class PathSumTestsBase<T> where T : IPathSum, new()
{
    [TestMethod]
    [DataRow("[5,4,8,11,null,13,4,7,2,null,null,null,1]", 22, true)]
    [DataRow("[1,2,3]", 5, false)]
    [DataRow("[]", 0, false)]
    [DataRow("[1]", 1, true)]
    [DataRow("[1,2]", 1, false)]
    [DataRow("[1,2,null,3,null,4,null,5]", 6, false)]
    [DataRow("[1,-2,-3,1,3,-2,null,-1]", -1, true)]
    public void HasPathSum_GivenBinaryTreeAndTargetSum_ReturnsExpectedBoolean(string jsonRootArray, int targetSum,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        IList<int?> rootArray = JsonHelper<int?>.JsonArrayToList(jsonRootArray);
        var root = TreeNode.BuildTree(rootArray);

        // Act
        var actualResult = solution.HasPathSum(root, targetSum);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}