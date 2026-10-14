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

using LeetCode.Algorithms.TheTwoSneakyNumbersOfDigitville;

namespace LeetCode.Tests.Algorithms.TheTwoSneakyNumbersOfDigitville;

public abstract class TheTwoSneakyNumbersOfDigitvilleTestsBase<T> where T : ITheTwoSneakyNumbersOfDigitville, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 1, 0 }, new[] { 0, 1 })]
    [DataRow(new[] { 0, 3, 2, 1, 3, 2 }, new[] { 2, 3 })]
    [DataRow(new[] { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 }, new[] { 4, 5 })]
    [DataRow(new[] { 0, 1, 0, 1 }, new[] { 0, 1 })]
    [DataRow(new[] { 2, 0, 2, 1, 0 }, new[] { 0, 2 })]
    [DataRow(new[] { 2, 1, 1, 2, 0 }, new[] { 1, 2 })]
    [DataRow(new[] { 3, 1, 0, 3, 2, 0 }, new[] { 0, 3 })]
    [DataRow(new[] { 2, 1, 2, 0, 3, 4, 4 }, new[] { 2, 4 })]
    [DataRow(new[] { 5, 1, 3, 0, 4, 2, 5, 1 }, new[] { 1, 5 })]
    [DataRow(new[] { 1, 2, 0, 3, 6, 0, 4, 6, 5 }, new[] { 0, 6 })]
    [DataRow(new[] { 2, 4, 7, 6, 3, 4, 5, 1, 3, 0 }, new[] { 3, 4 })]
    [DataRow(new[] { 9, 0, 8, 0, 5, 6, 7, 1, 9, 4, 3, 2 }, new[] { 0, 9 })]
    [DataRow(new[] { 3, 5, 1, 0, 5, 2, 4, 7, 11, 7, 9, 6, 8, 10 }, new[] { 5, 7 })]
    [DataRow(new[] { 3, 16, 19, 13, 4, 19, 5, 12, 10, 2, 11, 15, 1, 7, 18, 0, 6, 14, 1, 8, 17, 9 }, new[] { 1, 19 })]
    [DataRow(new[] { 0, 24, 1, 16, 19, 23, 11, 20, 18, 7, 25, 4, 28, 29, 15, 10, 2, 26, 8, 13, 6, 16, 22, 17, 15, 14, 9, 12, 21, 3, 5, 27 }, new[] { 15, 16 })]
    [DataRow(new[] { 26, 32, 29, 48, 15, 4, 36, 42, 31, 40, 28, 0, 24, 30, 27, 14, 11, 22, 47, 2, 12, 18, 19, 45, 16, 21, 34, 10, 20, 49, 25, 0, 46, 7, 1, 33, 49, 41, 38, 35, 39, 37, 13, 3, 44, 23, 8, 9, 6, 43, 17, 5 }, new[] { 0, 49 })]
    [DataRow(new[] { 10, 23, 40, 28, 0, 38, 2, 29, 59, 15, 17, 1, 50, 3, 46, 18, 64, 52, 74, 44, 73, 56, 26, 66, 7, 53, 68, 67, 41, 54, 45, 63, 72, 71, 43, 33, 37, 21, 19, 39, 60, 6, 25, 51, 35, 42, 24, 57, 27, 58, 31, 12, 14, 61, 55, 20, 62, 65, 36, 34, 13, 30, 47, 70, 9, 49, 5, 8, 11, 69, 22, 32, 33, 66, 16, 48, 4 }, new[] { 33, 66 })]
    [DataRow(new[] { 72, 93, 90, 61, 26, 4, 19, 50, 52, 20, 81, 25, 57, 0, 59, 24, 98, 38, 95, 17, 35, 46, 53, 15, 63, 23, 86, 79, 98, 0, 29, 40, 77, 41, 71, 12, 73, 43, 32, 6, 37, 30, 1, 27, 94, 11, 8, 16, 68, 5, 22, 85, 18, 75, 31, 80, 10, 92, 58, 64, 28, 7, 82, 89, 44, 14, 34, 47, 42, 83, 9, 2, 74, 65, 91, 36, 39, 76, 3, 33, 97, 96, 70, 84, 49, 21, 48, 62, 60, 45, 69, 56, 87, 13, 51, 88, 54, 78, 67, 66, 55 }, new[] { 0, 98 })]
    [DataRow(new[] { 18, 32, 95, 79, 22, 72, 10, 86, 23, 39, 9, 70, 45, 51, 0, 20, 2, 16, 50, 17, 8, 96, 34, 28, 65, 58, 55, 60, 0, 56, 4, 26, 30, 25, 97, 37, 73, 44, 41, 7, 48, 77, 19, 80, 88, 91, 87, 53, 43, 78, 67, 13, 93, 27, 62, 54, 82, 38, 83, 76, 35, 98, 1, 5, 3, 74, 71, 99, 85, 42, 33, 40, 64, 36, 29, 63, 15, 21, 47, 12, 59, 75, 52, 49, 92, 89, 99, 14, 31, 61, 84, 90, 57, 81, 46, 24, 66, 11, 68, 69, 94, 6 }, new[] { 0, 99 })]
    [DataRow(new[] { 40, 77, 90, 10, 85, 51, 84, 60, 46, 51, 36, 97, 63, 45, 2, 93, 35, 11, 18, 73, 79, 48, 80, 78, 70, 12, 29, 98, 41, 30, 62, 54, 64, 24, 25, 67, 99, 44, 38, 21, 5, 65, 9, 33, 69, 72, 53, 68, 17, 89, 57, 26, 19, 81, 58, 92, 87, 7, 94, 76, 42, 8, 6, 74, 91, 31, 59, 75, 82, 86, 13, 39, 15, 16, 50, 27, 49, 55, 3, 4, 23, 61, 71, 0, 83, 22, 43, 95, 52, 28, 56, 34, 50, 20, 1, 32, 66, 47, 88, 14, 37, 96 }, new[] { 50, 51 })]
    public void GetSneakyNumbers_GivenArrayOfNumbers_ReturnsSneakyNumbers(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetSneakyNumbers(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }
}