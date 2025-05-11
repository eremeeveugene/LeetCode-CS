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

using LeetCode.Algorithms.RangeSumOfBST;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.RangeSumOfBST;

public abstract class RangeSumOfBSTTestsBase<T> where T : IRangeSumOfBST, new()
{
    [TestMethod]
    [DataRow("[10,5,15,3,7,null,18]", 7, 15, 32)]
    [DataRow("[10,5,15,3,7,13,18,1,null,6]", 6, 10, 23)]
    public void RangeSumBST_WithTreeAndInclusiveBounds_ReturnsSumOfValuesInRange(string rootJson, int low, int high,
        int expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?[]>.Parse(rootJson);
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.RangeSumBST(root, low, high);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}