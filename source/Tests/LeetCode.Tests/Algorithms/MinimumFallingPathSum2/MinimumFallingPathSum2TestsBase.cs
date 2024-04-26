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

using LeetCode.Algorithms.MinimumFallingPathSum2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumFallingPathSum2;

public abstract class MinimumFallingPathSum2TestsBase<T> where T : IMinimumFallingPathSum2, new()
{
    [TestMethod]
    [DataRow("[[1,2,3],[4,5,6],[7,8,9]]", 13)]
    [DataRow("[[7]]", 7)]
    public void Test(string gridJsonArray, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var grid = JsonConvertHelper<int>.JsonArrayToJaggedArray(gridJsonArray);

        // Act
        var actualResult = solution.MinFallingPathSum(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}