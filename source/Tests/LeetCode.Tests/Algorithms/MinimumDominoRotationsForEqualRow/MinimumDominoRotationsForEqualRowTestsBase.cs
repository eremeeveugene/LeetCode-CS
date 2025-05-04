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

using LeetCode.Algorithms.MinimumDominoRotationsForEqualRow;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumDominoRotationsForEqualRow;

public abstract class MinimumDominoRotationsForEqualRowTestsBase<T> where T : IMinimumDominoRotationsForEqualRow, new()
{
    [TestMethod]
    [DataRow("[2,1,2,4,2,2]", "[5,2,6,2,3,2]", 2)]
    [DataRow("[3,5,1,2,3]", "[3,6,3,3,4]", -1)]
    [DataRow("[1,2,1,1,1,2,2,2]", "[2,1,2,2,2,2,2,2]", 1)]
    public void MinDominoRotations_WithTopAndBottomArrays_ReturnsMinimumRotationsOrMinusOne(string topsJsonArray,
        string bottomsJsonArray, int expectedResult)
    {
        // Arrange
        var tops = JsonHelper<int>.DeserializeToArray(topsJsonArray);
        var bottoms = JsonHelper<int>.DeserializeToArray(bottomsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinDominoRotations(tops, bottoms);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}