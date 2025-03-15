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

using LeetCode.Algorithms.ZigzagGridTraversalWithSkip;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ZigzagGridTraversalWithSkip;

public abstract class ZigzagGridTraversalWithSkipTestsBase<T> where T : IZigzagGridTraversalWithSkip, new()
{
    [TestMethod]
    [DataRow("[[1,2],[3,4]]", "[1,4]")]
    [DataRow("[[2,1],[2,1],[2,1]]", "[2,1,2]")]
    [DataRow("[[1,2,3],[4,5,6],[7,8,9]]", "[1,3,5,7,9]")]
    public void ZigzagTraversal_WithJaggedGrid_ReturnsZigzagOrderArray(string gridJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var grid = JsonHelper<int>.DeserializeToJaggedArray(gridJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ZigzagTraversal(grid);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}