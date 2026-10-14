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

using LeetCode.Algorithms.MinimumNumberOfMovesToSeatEveryone;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfMovesToSeatEveryone;

public abstract class MinimumNumberOfMovesToSeatEveryoneTestsBase<T> where T : IMinimumNumberOfMovesToSeatEveryone, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1, 5 }, new[] { 2, 7, 4 }, 4)]
    [DataRow(new[] { 4, 1, 5, 9 }, new[] { 1, 3, 2, 6 }, 7)]
    [DataRow(new[] { 2, 2, 6, 6 }, new[] { 1, 3, 2, 6 }, 4)]
    [DataRow(new[] { 1 }, new[] { 1 }, 0)]
    [DataRow(new[] { 1 }, new[] { 100 }, 99)]
    [DataRow(new[] { 100 }, new[] { 1 }, 99)]
    [DataRow(new[] { 2, 2 }, new[] { 2, 2 }, 0)]
    [DataRow(new[] { 1, 2 }, new[] { 2, 1 }, 0)]
    [DataRow(new[] { 1, 1 }, new[] { 5, 5 }, 8)]
    [DataRow(new[] { 3, 20 }, new[] { 5, 1 }, 17)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, 9)]
    [DataRow(new[] { 6, 5, 4 }, new[] { 3, 2, 1 }, 9)]
    [DataRow(new[] { 10, 10, 10 }, new[] { 1, 5, 9 }, 15)]
    [DataRow(new[] { 1, 100, 50 }, new[] { 50, 1, 100 }, 0)]
    [DataRow(new[] { 7, 3, 9, 1 }, new[] { 2, 8, 4, 6 }, 4)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, new[] { 1, 2, 3, 4, 5 }, 10)]
    [DataRow(new[] { 1, 3, 5, 7, 9, 11 }, new[] { 2, 4, 6, 8, 10, 12 }, 6)]
    [DataRow(new[] { 12, 7, 1, 30, 4 }, new[] { 9, 9, 9, 2, 25 }, 16)]
    [DataRow(new[] { 100, 100, 1, 1 }, new[] { 50, 50, 50, 50 }, 198)]
    [DataRow(new[] { 4, 1, 8, 2, 9, 6, 3 }, new[] { 7, 5, 1, 9, 2, 8, 4 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }, new[] { 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 0)]
    public void MinMovesToSeat_WithSeatAndStudentPositions_ReturnsMinimumTotalMovesToAssignSeats(int[] seats, int[] students, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinMovesToSeat(seats, students);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}