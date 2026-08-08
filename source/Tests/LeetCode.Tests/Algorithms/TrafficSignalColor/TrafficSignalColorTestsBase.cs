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

using LeetCode.Algorithms.TrafficSignalColor;

namespace LeetCode.Tests.Algorithms.TrafficSignalColor;

public abstract class TrafficSignalColorTestsBase<T> where T : ITrafficSignalColor, new()
{
    [TestMethod]
    [DataRow(60, "Red")]
    [DataRow(5, "Invalid")]
    [DataRow(0, "Green")]
    [DataRow(30, "Orange")]
    [DataRow(90, "Red")]
    [DataRow(91, "Invalid")]
    [DataRow(31, "Red")]
    [DataRow(29, "Invalid")]
    [DataRow(1, "Invalid")]
    [DataRow(1000, "Invalid")]
    [DataRow(100, "Invalid")]
    [DataRow(45, "Red")]
    [DataRow(89, "Red")]
    [DataRow(2, "Invalid")]
    [DataRow(50, "Red")]
    [DataRow(75, "Red")]
    [DataRow(15, "Invalid")]
    [DataRow(999, "Invalid")]
    [DataRow(500, "Invalid")]
    [DataRow(3, "Invalid")]
    public void TrafficSignal_WithTimer_ReturnsSignalState(int timer, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TrafficSignal(timer);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}