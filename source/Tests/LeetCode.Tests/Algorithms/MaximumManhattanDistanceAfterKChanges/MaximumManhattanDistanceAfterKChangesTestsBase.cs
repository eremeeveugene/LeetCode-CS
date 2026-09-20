// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MaximumManhattanDistanceAfterKChanges;

namespace LeetCode.Tests.Algorithms.MaximumManhattanDistanceAfterKChanges;

public abstract class MaximumManhattanDistanceAfterKChangesTestsBase<T> where T : IMaximumManhattanDistanceAfterKChanges, new()
{
    [TestMethod]
    [DataRow("NWSE", 1, 3)]
    [DataRow("NSWWEW", 3, 6)]
    [DataRow("N", 0, 1)]
    [DataRow("S", 0, 1)]
    [DataRow("E", 0, 1)]
    [DataRow("W", 0, 1)]
    [DataRow("N", 1, 1)]
    [DataRow("S", 1, 1)]
    [DataRow("E", 1, 1)]
    [DataRow("W", 1, 1)]
    [DataRow("NS", 0, 1)]
    [DataRow("NS", 1, 2)]
    [DataRow("SN", 1, 2)]
    [DataRow("EW", 0, 1)]
    [DataRow("EW", 1, 2)]
    [DataRow("WE", 1, 2)]
    [DataRow("NE", 0, 2)]
    [DataRow("NW", 0, 2)]
    [DataRow("SE", 0, 2)]
    [DataRow("SW", 0, 2)]
    [DataRow("NNNN", 0, 4)]
    [DataRow("SSSS", 2, 4)]
    [DataRow("EEEE", 4, 4)]
    [DataRow("WWWW", 1, 4)]
    [DataRow("NSNS", 0, 1)]
    [DataRow("NSNS", 1, 3)]
    [DataRow("NSNS", 2, 4)]
    [DataRow("EWEW", 1, 3)]
    [DataRow("NWSE", 0, 2)]
    [DataRow("NWSE", 2, 4)]
    [DataRow("NWSE", 4, 4)]
    [DataRow("NNNSSS", 0, 3)]
    [DataRow("NNNSSS", 1, 4)]
    [DataRow("NNNSSS", 2, 5)]
    [DataRow("NNNSSS", 3, 6)]
    [DataRow("EEWWNNSS", 1, 4)]
    [DataRow("EEWWNNSS", 2, 6)]
    [DataRow("SENWN", 1, 3)]
    [DataRow("WWSSEE", 1, 5)]
    [DataRow("NSEWNS", 1, 3)]
    [DataRow("NSEWNS", 2, 5)]
    [DataRow("NNEESSWW", 1, 5)]
    public void MaxDistance_WithGivenMovementsAndChanges_ReturnsMaximumManhattanDistance(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDistance(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}