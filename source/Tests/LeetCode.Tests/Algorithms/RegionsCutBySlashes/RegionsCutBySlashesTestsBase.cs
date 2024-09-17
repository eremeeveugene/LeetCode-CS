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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RegionsCutBySlashes;

public abstract class RegionsCutBySlashesTestsBase<T> where T : IRegionsCutBySlashes, new()
{
    [TestMethod]
    [DataRow("[\" /\",\"  \"]", 1)]
    [DataRow("[\" /\",\"/ \"]", 2)]
    [DataRow("[\"/\\\\\",\"\\\\/\"]", 5)]
    [DataRow("[\"   \",\"   \",\"   \"]", 1)]
    [DataRow("[\" /\\\\\",\" \\\\/\",\"\\\\  \"]", 4)]
    [DataRow(
        "[\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\",\"/\\\\/\\\\  /\\\\/\\\\  /\\\\/\\\\\"]",
        12)]
    public void RegionsBySlashes_WithDifferentGrids_ReturnsRegionCount(string gridJsonArray, int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<string>.DeserializeToArray(gridJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RegionsBySlashes(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}