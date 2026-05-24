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
    [DataRow("LLL", 0)]
    [DataRow("RRR", 0)]
    [DataRow("SSS", 0)]
    [DataRow("LR", 0)]
    [DataRow("LLLRRR", 0)]
    [DataRow("LLLSSSRRR", 0)]
    [DataRow("RS", 1)]
    [DataRow("SL", 1)]
    [DataRow("RRS", 2)]
    [DataRow("SLL", 2)]
    [DataRow("RRRS", 3)]
    [DataRow("SLLL", 3)]
    [DataRow("RL", 2)]
    [DataRow("RLL", 3)]
    [DataRow("RRL", 3)]
    [DataRow("RRLL", 4)]
    [DataRow("RRRLLL", 6)]
    [DataRow("RSL", 2)]
    [DataRow("RRSSLL", 4)]
    [DataRow("RSSSL", 2)]
    [DataRow("RRSLL", 4)]
    [DataRow("LRL", 2)]
    [DataRow("LLRL", 2)]
    [DataRow("LLRLL", 3)]
    [DataRow("LLRRSLL", 4)]
    [DataRow("RLR", 2)]
    [DataRow("RLLR", 3)]
    [DataRow("RRLLRR", 4)]
    [DataRow("SRRR", 0)]
    [DataRow("LRLR", 2)]
    [DataRow("LLRLRR", 2)]
    [DataRow("LLRRLLRR", 4)]
    [DataRow("RLRL", 4)]
    [DataRow("RLRLRL", 6)]
    [DataRow("LRLRLR", 4)]
    [DataRow("SSRSSRLLRSLLRSRSSRLRRRRLLRRLSSRR", 20)]
    [DataRow("LLSSRRLLSSRR", 4)]
    [DataRow("RRSSLLRRLLSS", 8)]
    [DataRow("LSRRSLLR", 4)]
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