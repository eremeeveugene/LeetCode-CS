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

using LeetCode.Algorithms.MaximumDepthOfNaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MaximumDepthOfNaryTree;

public abstract class MaximumDepthOfNaryTreeTestsBase<T> where T : IMaximumDepthOfNaryTree, new()
{
    [TestMethod]
    [DataRow("[]", 0)]
    [DataRow("[1,null,3,2,4,null,5,6]", 3)]
    [DataRow("[1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]", 5)]
    public void MaxDepth_WithNaryTreeInput_ReturnsMaximumDepth(string rootJson, int expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.DeserializeToArray(rootJson);
        var root = Node.ToNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxDepth(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}