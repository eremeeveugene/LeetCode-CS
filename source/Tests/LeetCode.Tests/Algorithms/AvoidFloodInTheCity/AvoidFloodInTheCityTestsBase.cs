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

using LeetCode.Algorithms.AvoidFloodInTheCity;

namespace LeetCode.Tests.Algorithms.AvoidFloodInTheCity;

public abstract class AvoidFloodInTheCityTestsBase<T> where T : IAvoidFloodInTheCity, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { -1, -1, -1, -1 })]
    [DataRow(new[] { 1, 2, 0, 0, 2, 1 }, new[] { -1, -1, 2, 1, -1, -1 })]
    [DataRow(new[] { 1, 2, 0, 1, 2 }, new int[] { })]
    [DataRow(new[] { 0 }, new[] { 1 })]
    [DataRow(new[] { 1 }, new[] { -1 })]
    [DataRow(new[] { 1, 1 }, new int[] { })]
    [DataRow(new[] { 1, 0, 1 }, new[] { -1, 1, -1 })]
    [DataRow(new[] { 0, 1, 1 }, new int[] { })]
    [DataRow(new[] { 1, 1, 0 }, new int[] { })]
    [DataRow(new[] { 0, 0, 0 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 0, 1, 2, 0 }, new[] { 1, -1, -1, 1 })]
    [DataRow(new[] { 1, 2, 0, 2, 1 }, new int[] { })]
    [DataRow(new[] { 1, 2, 0, 2, 0, 1 }, new[] { -1, -1, 2, -1, 1, -1 })]
    [DataRow(new[] { 1, 2, 0, 1, 0, 2 }, new[] { -1, -1, 1, -1, 2, -1 })]
    [DataRow(new[] { 1, 0, 1, 0, 1 }, new[] { -1, 1, -1, 1, -1 })]
    [DataRow(new[] { 1, 0, 1, 1 }, new int[] { })]
    [DataRow(new[] { 1, 2, 3, 0, 0, 3, 2, 1 }, new int[] { })]
    [DataRow(new[] { 1, 2, 3, 0, 0, 0, 3, 2, 1 }, new[] { -1, -1, -1, 3, 2, 1, -1, -1, -1 })]
    [DataRow(new[] { 1, 2, 3, 0, 1, 0, 2, 0, 3 }, new[] { -1, -1, -1, 1, -1, 2, -1, 3, -1 })]
    [DataRow(new[] { 1, 2, 3, 0, 2, 0, 1, 0, 3 }, new[] { -1, -1, -1, 2, -1, 1, -1, 3, -1 })]
    [DataRow(new[] { 1, 2, 0, 3, 0, 2, 1 }, new[] { -1, -1, 2, -1, 1, -1, -1 })]
    [DataRow(new[] { 1, 2, 0, 3, 1, 2 }, new int[] { })]
    [DataRow(new[] { 10, 20, 0, 20, 0, 10 }, new[] { -1, -1, 20, -1, 10, -1 })]
    [DataRow(new[] { 1000000000, 0, 1000000000 }, new[] { -1, 1000000000, -1 })]
    [DataRow(new[] { 1000000000, 1000000000 }, new int[] { })]
    [DataRow(new[] { 1, 2, 0, 0, 2, 1, 0, 1, 2 }, new int[] { })]
    [DataRow(new[] { 1, 2, 0, 0, 2, 1, 0, 1, 0, 2 }, new[] { -1, -1, 2, 1, -1, -1, 1, -1, 2, -1 })]
    [DataRow(new[] { 0, 0, 1, 2, 1, 2 }, new int[] { })]
    [DataRow(new[] { 7, 0, 0, 0, 7 }, new[] { -1, 7, 1, 1, -1 })]
    [DataRow(new[] { 2, 0, 1, 2 }, new[] { -1, 2, -1, -1 })]
    public void AvoidFlood_WithGivenRainfall_ReturnsDryingSchedule(int[] rains, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AvoidFlood(rains);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}