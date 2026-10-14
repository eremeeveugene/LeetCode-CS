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

using LeetCode.Algorithms.MinimumNumberGame;

namespace LeetCode.Tests.Algorithms.MinimumNumberGame;

public abstract class MinimumNumberGameTestsBase<T> where T : IMinimumNumberGame, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 4, 2, 3 }, new[] { 3, 2, 5, 4 })]
    [DataRow(new[] { 2, 5 }, new[] { 5, 2 })]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 2, 1 })]
    [DataRow(new[] { 2, 1 }, new[] { 2, 1 })]
    [DataRow(new[] { 100, 100 }, new[] { 100, 100 })]
    [DataRow(new[] { 1, 100 }, new[] { 100, 1 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 2, 1, 4, 3 })]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 2, 1, 4, 3 })]
    [DataRow(new[] { 7, 7, 7, 7 }, new[] { 7, 7, 7, 7 })]
    [DataRow(new[] { 1, 1, 2, 2 }, new[] { 1, 1, 2, 2 })]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60 }, new[] { 20, 10, 40, 30, 60, 50 })]
    [DataRow(new[] { 60, 50, 40, 30, 20, 10 }, new[] { 20, 10, 40, 30, 60, 50 })]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, new[] { 1, 1, 3, 2, 5, 4, 9, 6 })]
    [DataRow(new[] { 100, 99, 98, 97 }, new[] { 98, 97, 100, 99 })]
    [DataRow(new[] { 1, 3, 5, 7, 9, 11, 13, 15 }, new[] { 3, 1, 7, 5, 11, 9, 15, 13 })]
    [DataRow(new[] { 8, 8, 1, 1, 4, 4 }, new[] { 1, 1, 4, 4, 8, 8 })]
    [DataRow(new[] { 42, 17, 99, 3, 56, 28, 71, 14, 35, 89 }, new[] { 14, 3, 28, 17, 42, 35, 71, 56, 99, 89 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }, new[] { 2, 1, 4, 3, 6, 5, 8, 7, 10, 9, 12, 11, 14, 13, 16, 15, 18, 17, 20, 19, 22, 21, 24, 23, 26, 25, 28, 27, 30, 29, 32, 31, 34, 33, 36, 35, 38, 37, 40, 39, 42, 41, 44, 43, 46, 45, 48, 47, 50, 49, 52, 51, 54, 53, 56, 55, 58, 57, 60, 59, 62, 61, 64, 63, 66, 65, 68, 67, 70, 69, 72, 71, 74, 73, 76, 75, 78, 77, 80, 79, 82, 81, 84, 83, 86, 85, 88, 87, 90, 89, 92, 91, 94, 93, 96, 95, 98, 97, 100, 99 })]
    [DataRow(new[] { 9, 3 }, new[] { 9, 3 })]
    public void NumberGame_WithEvenLengthArray_ReturnsArrayConstructedFromAlternatingMinSelections(int[] cost, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberGame(cost);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}