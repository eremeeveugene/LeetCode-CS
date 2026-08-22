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

using LeetCode.Algorithms.ElevatorRequests1;

namespace LeetCode.Tests.Algorithms.ElevatorRequests1;

public abstract class ElevatorRequests1TestsBase<T> where T : IElevatorRequests1, new()
{
    [TestMethod]
    [DataRow(1, new[] { 0 }, 0)]
    [DataRow(2, new[] { 0 }, 0)]
    [DataRow(2, new[] { 1 }, 1)]
    [DataRow(2, new[] { 0, 1 }, 1)]
    [DataRow(2, new[] { 1, 0 }, 2)]
    [DataRow(2, new[] { 1, 1 }, 1)]
    [DataRow(3, new[] { 2, 0, 0 }, 4)]
    [DataRow(3, new[] { 0, 2, 1 }, 3)]
    [DataRow(3, new[] { 1, 2, 0 }, 4)]
    [DataRow(5, new[] { 2, 1, 4, 3 }, 7)]
    [DataRow(5, new[] { 4 }, 4)]
    [DataRow(5, new[] { 4, 0 }, 8)]
    [DataRow(5, new[] { 0, 4, 0 }, 8)]
    [DataRow(5, new[] { 1, 1, 1 }, 1)]
    [DataRow(6, new[] { 5, 4, 3, 2, 1, 0 }, 10)]
    [DataRow(6, new[] { 0, 1, 2, 3, 4, 5 }, 5)]
    [DataRow(10, new[] { 9, 0, 9 }, 27)]
    [DataRow(10, new[] { 5, 5, 0, 0, 9 }, 19)]
    [DataRow(10, new[] { 1, 8, 2, 7, 3, 6, 4, 5 }, 29)]
    [DataRow(10, new[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 }, 45)]
    [DataRow(100, new[] { 99 }, 99)]
    [DataRow(100, new[] { 99, 0 }, 198)]
    [DataRow(100, new[] { 0, 99, 0, 99, 0 }, 396)]
    [DataRow(100, new[] { 50, 25, 75, 0, 99 }, 299)]
    [DataRow(7, new[] { 3, 6, 3, 0, 3, 6 }, 18)]
    [DataRow(4, new[] { 1, 3, 2, 0 }, 6)]
    [DataRow(4, new[] { 0, 0, 0 }, 0)]
    [DataRow(8, new[] { 7, 7, 7, 0 }, 14)]
    [DataRow(8, new[] { 2, 5, 1, 6, 0, 7 }, 27)]
    [DataRow(5, new[] { 2, 2, 4, 4, 1, 1 }, 7)]
    public void ElevatorRequests_WithGivenFloorRequests_ReturnsTotalTravelTime(int n, int[] requests, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ElevatorRequests(n, requests);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}