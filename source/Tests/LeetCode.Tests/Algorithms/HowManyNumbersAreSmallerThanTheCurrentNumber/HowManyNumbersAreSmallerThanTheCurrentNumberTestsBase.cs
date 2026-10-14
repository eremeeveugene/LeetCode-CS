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

using LeetCode.Algorithms.HowManyNumbersAreSmallerThanTheCurrentNumber;

namespace LeetCode.Tests.Algorithms.HowManyNumbersAreSmallerThanTheCurrentNumber;

public abstract class HowManyNumbersAreSmallerThanTheCurrentNumberTestsBase<T> where T : IHowManyNumbersAreSmallerThanTheCurrentNumber, new()
{
    [TestMethod]
    [DataRow(new[] { 8, 1, 2, 2, 3 }, new[] { 4, 0, 1, 1, 3 })]
    [DataRow(new[] { 6, 5, 4, 8 }, new[] { 2, 1, 0, 3 })]
    [DataRow(new[] { 7, 7, 7, 7 }, new[] { 0, 0, 0, 0 })]
    [DataRow(new[] { 0, 0 }, new[] { 0, 0 })]
    [DataRow(new[] { 1, 0 }, new[] { 1, 0 })]
    [DataRow(new[] { 0, 1 }, new[] { 0, 1 })]
    [DataRow(new[] { 5, 5 }, new[] { 0, 0 })]
    [DataRow(new[] { 100, 0 }, new[] { 1, 0 })]
    [DataRow(new[] { 0, 100 }, new[] { 0, 1 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 2, 1, 0 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 0, 1, 2 })]
    [DataRow(new[] { 2, 2, 1, 1 }, new[] { 2, 2, 0, 0 })]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5 }, new[] { 0, 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 5, 4, 3, 2, 1, 0 }, new[] { 5, 4, 3, 2, 1, 0 })]
    [DataRow(new[] { 9, 9, 9, 0 }, new[] { 1, 1, 1, 0 })]
    [DataRow(new[] { 4, 1, 4, 1, 4, 1 }, new[] { 3, 0, 3, 0, 3, 0 })]
    [DataRow(new[] { 100, 100, 99, 99, 98 }, new[] { 3, 3, 1, 1, 0 })]
    [DataRow(new[] { 10, 20, 10, 20, 30, 30, 0 }, new[] { 1, 3, 1, 3, 5, 5, 0 })]
    [DataRow(new[] { 5, 2, 6, 10, 0, 1, 8, 1 }, new[] { 4, 3, 5, 7, 0, 1, 6, 1 })]
    [DataRow(new[] { 5, 9, 0, 8, 3, 0, 1, 6, 6, 1, 3, 1, 8, 6, 0 }, new[] { 8, 14, 0, 12, 6, 0, 3, 9, 9, 3, 6, 3, 12, 9, 0 })]
    [DataRow(new[] { 9, 1, 3, 10, 10, 9, 0, 9, 9, 6, 0, 3, 0, 8, 2, 4, 6, 2, 8, 1, 9, 4, 8, 10, 2, 1, 9, 9, 10, 3 }, new[] { 19, 3, 9, 26, 26, 19, 0, 19, 19, 14, 0, 9, 0, 16, 6, 12, 14, 6, 16, 3, 19, 12, 16, 26, 6, 3, 19, 19, 26, 9 })]
    [DataRow(new[] { 47, 12, 70, 91, 8, 72, 7, 79, 26, 63, 87, 68, 54, 99, 40, 59, 74, 58, 46, 38, 31, 23, 89, 99, 31, 10, 73, 38, 67, 63, 43, 93, 57, 36, 77, 9, 15, 65, 53, 21, 96, 43, 19, 62, 53, 5, 85, 9, 97, 71 }, new[] { 21, 6, 34, 44, 2, 36, 1, 40, 11, 29, 42, 33, 24, 48, 17, 27, 38, 26, 20, 15, 12, 10, 43, 48, 12, 5, 37, 15, 32, 29, 18, 45, 25, 14, 39, 3, 7, 31, 22, 9, 46, 18, 8, 28, 22, 0, 41, 3, 47, 35 })]
    public void SmallerNumbersThanCurrent_WithIntArray_ReturnsCountsArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallerNumbersThanCurrent(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}