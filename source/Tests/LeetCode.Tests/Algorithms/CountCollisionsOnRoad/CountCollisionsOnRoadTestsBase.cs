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

using LeetCode.Algorithms.CountCollisionsOnRoad;

namespace LeetCode.Tests.Algorithms.CountCollisionsOnRoad;

public abstract class CountCollisionsOnRoadTestsBase<T> where T : ICountCollisionsOnRoad, new()
{
    [TestMethod]
    [DataRow("LLRR", 0)]
    [DataRow("RLRSLL", 5)]
    [DataRow("S", 0)]
    [DataRow("L", 0)]
    [DataRow("R", 0)]
    [DataRow("SSSS", 0)]
    [DataRow("LLLL", 0)]
    [DataRow("RRRR", 0)]
    [DataRow("LS", 0)]
    [DataRow("SR", 0)]
    [DataRow("RS", 1)]
    [DataRow("SL", 1)]
    [DataRow("RL", 2)]
    [DataRow("RLS", 2)]
    [DataRow("SRL", 2)]
    [DataRow("RSL", 2)]
    [DataRow("RRLL", 4)]
    [DataRow("RRSS", 2)]
    [DataRow("SSLL", 2)]
    [DataRow("RSSL", 2)]
    [DataRow("RRSLL", 4)]
    [DataRow("LRLR", 2)]
    [DataRow("RLRL", 4)]
    [DataRow("LLRRSLL", 4)]
    [DataRow("RRLLSSLLRR", 6)]
    public void CountCollisions_WithInputDirections_ReturnsTotalCollisionCount(string directions, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountCollisions(directions);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}