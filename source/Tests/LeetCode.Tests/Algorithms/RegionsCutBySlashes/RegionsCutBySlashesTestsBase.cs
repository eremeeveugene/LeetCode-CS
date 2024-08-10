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

using LeetCode.Algorithms.RegionsCutBySlashes;

namespace LeetCode.Tests.Algorithms.RegionsCutBySlashes;

public abstract class RegionsCutBySlashesTestsBase<T> where T : IRegionsCutBySlashes, new()
{
    [TestMethod]
    [DataRow(new[] { " /", "  " }, 1)]
    [DataRow(new[] { " /", "/ " }, 2)]
    [DataRow(new[] { @"/\", @"\/" }, 5)]
    [DataRow(new[] { @"/\/\", @"\/\/", @"/\/\", @"\/\\" }, 12)]
    [DataRow(new[] { "   ", "   ", "   " }, 1)]
    [DataRow(new[] { @" /\", @" \/", @"\  " }, 4)]
    [DataRow(
        new[]
        {
            @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\",
            @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\",
            @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\", @"/\/\  /\/\  /\/\",
            @"/\/\  /\/\  /\/\"
        }, 12)]
    public void RegionsBySlashes_WithDifferentGrids_ReturnsRegionCount(string[] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RegionsBySlashes(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}