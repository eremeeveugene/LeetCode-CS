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

using LeetCode.Algorithms.TransformArrayByParity;

namespace LeetCode.Tests.Algorithms.TransformArrayByParity;

public abstract class TransformArrayByParityTestsBase<T> where T : ITransformArrayByParity, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 0, 0, 1, 1 })]
    [DataRow(new[] { 1, 5, 1, 4, 2 }, new[] { 0, 0, 1, 1, 1 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 2 }, new[] { 0 })]
    [DataRow(new[] { 1, 2 }, new[] { 0, 1 })]
    [DataRow(new[] { 2, 1 }, new[] { 0, 1 })]
    [DataRow(new[] { 2, 4, 6 }, new[] { 0, 0, 0 })]
    [DataRow(new[] { 1, 3, 5 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 0, 0, 0, 1, 1, 1 })]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, new[] { 0, 0, 0, 1, 1, 1 })]
    [DataRow(new[] { 100, 99 }, new[] { 0, 1 })]
    [DataRow(new[] { 99, 100 }, new[] { 0, 1 })]
    [DataRow(new[] { 1, 1, 2, 2 }, new[] { 0, 0, 1, 1 })]
    [DataRow(new[] { 2, 2, 1, 1 }, new[] { 0, 0, 1, 1 })]
    [DataRow(new[] { 7, 8, 9, 10, 11, 12, 13 }, new[] { 0, 0, 0, 1, 1, 1, 1 })]
    [DataRow(new[] { 50, 50, 51, 51, 50 }, new[] { 0, 0, 0, 1, 1 })]
    [DataRow(new[] { 3, 3, 3, 4 }, new[] { 0, 1, 1, 1 })]
    [DataRow(new[] { 4, 3, 3, 3 }, new[] { 0, 1, 1, 1 })]
    [DataRow(new[] { 100, 1, 100, 1, 100 }, new[] { 0, 0, 0, 1, 1 })]
    [DataRow(new[] { 1, 38, 75, 12, 49, 86, 23, 60, 97, 34, 71, 8, 45, 82, 19, 56, 93, 30, 67, 4, 41, 78, 15, 52, 89, 26, 63, 100, 37, 74, 11, 48, 85, 22, 59, 96, 33, 70, 7, 44, 81, 18, 55, 92, 29, 66, 3, 40, 77, 14, 51, 88, 25, 62, 99, 36, 73, 10, 47, 84, 21, 58, 95, 32, 69, 6, 43, 80, 17, 54, 91, 28, 65, 2, 39, 76, 13, 50, 87, 24, 61, 98, 35, 72, 9, 46, 83, 20, 57, 94, 31, 68, 5, 42, 79, 16, 53, 90, 27, 64 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })]
    public void TransformArray_WithGivenIntegerArray_ReturnsTransformedArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TransformArray(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}