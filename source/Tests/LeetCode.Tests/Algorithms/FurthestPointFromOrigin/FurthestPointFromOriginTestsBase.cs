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

using LeetCode.Algorithms.FurthestPointFromOrigin;

namespace LeetCode.Tests.Algorithms.FurthestPointFromOrigin;

public abstract class FurthestPointFromOriginTestsBase<T> where T : IFurthestPointFromOrigin, new()
{
    [TestMethod]
    [DataRow("", 0)]
    [DataRow("L_RL__R", 3)]
    [DataRow("_R__LL_", 5)]
    [DataRow("_______", 7)]
    [DataRow("L", 1)]
    [DataRow("R", 1)]
    [DataRow("_", 1)]
    [DataRow("LLLL", 4)]
    [DataRow("RRRR", 4)]
    [DataRow("LLLLLLLLLL", 10)]
    [DataRow("RRRRRRRRRR", 10)]
    [DataRow("LR", 0)]
    [DataRow("LRLR", 0)]
    [DataRow("LLRR", 0)]
    [DataRow("RLRLRL", 0)]
    [DataRow("LR_", 1)]
    [DataRow("_LR_", 2)]
    [DataRow("LLRR__", 2)]
    [DataRow("__LR__", 4)]
    [DataRow("LLR", 1)]
    [DataRow("LRR", 1)]
    [DataRow("LLR_", 2)]
    [DataRow("LRR_", 2)]
    [DataRow("LLLRR_", 2)]
    [DataRow("_LR", 1)]
    [DataRow("__LLRR__", 4)]
    [DataRow("LLLLLR", 4)]
    [DataRow("LLLLL_", 6)]
    [DataRow("RRRRRL", 4)]
    [DataRow("RRRRR_", 6)]
    [DataRow("L_R_L_R_L", 5)]
    [DataRow("__LL__RR__", 6)]
    [DataRow("LRLRLRLR_", 1)]
    [DataRow("__", 2)]
    [DataRow("___", 3)]
    [DataRow("LLLLLRRRRR__________", 10)]
    [DataRow("LLLLLLLLLLRRRRR_____", 10)]
    public void FurthestDistanceFromOrigin_WithGivenMovesString_ReturnsMaximumDistanceFromOrigin(string moves, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FurthestDistanceFromOrigin(moves);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}