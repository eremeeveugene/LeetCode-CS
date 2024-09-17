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

using LeetCode.Algorithms.NumberOfIslands;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NumberOfIslands;

public abstract class NumberOfIslandsTestsBase<T> where T : INumberOfIslands, new()
{
    [TestMethod]
    [DataRow(
        "[[\"1\",\"1\",\"1\",\"1\",\"0\"],[\"1\",\"1\",\"0\",\"1\",\"0\"],[\"1\",\"1\",\"0\",\"0\",\"0\"],[\"0\",\"0\",\"0\",\"0\",\"0\"]]",
        1)]
    [DataRow(
        "[[\"1\",\"1\",\"0\",\"0\",\"0\"],[\"1\",\"1\",\"0\",\"0\",\"0\"],[\"0\",\"0\",\"1\",\"0\",\"0\"],[\"0\",\"0\",\"0\",\"1\",\"1\"]]",
        3)]
    public void NumIslands_GivenJaggedArrayGrid_ReturnsNumberOfIslands(string gridJsonArray, int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<char>.DeserializeToJaggedArray(gridJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.NumIslands(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}