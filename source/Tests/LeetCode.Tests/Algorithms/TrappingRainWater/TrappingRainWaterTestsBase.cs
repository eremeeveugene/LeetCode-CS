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

using LeetCode.Algorithms.TrappingRainWater;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TrappingRainWater;

public abstract class TrappingRainWaterTestsBase<T> where T : ITrappingRainWater, new()
{
    [TestMethod]
    [DataRow("[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]", 6)]
    [DataRow("[4, 2, 0, 3, 2, 5]", 9)]
    public void Trap_WithHeightArray_ReturnsTrappedWaterAmount(string heightJsonArray, int expectedResult)
    {
        // Arrange
        var height = JsonHelper<int>.DeserializeToArray(heightJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.Trap(height);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}