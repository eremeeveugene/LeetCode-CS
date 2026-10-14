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

using LeetCode.Algorithms.TransformedArray;

namespace LeetCode.Tests.Algorithms.TransformedArray;

public abstract class TransformedArrayTestsBase<T> where T : ITransformedArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, -2, 1, 1 }, new[] { 1, 1, 1, 3 })]
    [DataRow(new[] { -1, 4, -1 }, new[] { -1, -1, 4 })]
    [DataRow(new[] { -10 }, new[] { -10 })]
    [DataRow(new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 5 }, new[] { 5 })]
    [DataRow(new[] { 1, 2 }, new[] { 2, 2 })]
    [DataRow(new[] { -1, -2 }, new[] { -2, -2 })]
    [DataRow(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { -1, -1, -1 }, new[] { -1, -1, -1 })]
    [DataRow(new[] { 2, 3, 4 }, new[] { 4, 3, 2 })]
    [DataRow(new[] { -2, -3, -4 }, new[] { -3, -3, -3 })]
    [DataRow(new[] { 100, -100, 100, -100 }, new[] { 100, -100, 100, -100 })]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, new[] { 1, 4, 2, 5, 1, 2, 3, 9 })]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5 }, new[] { 0, 2, 4, 0, 2, 4 })]
    [DataRow(new[] { -5, -4, -3, -2, -1, 0 }, new[] { -4, -2, 0, -4, -2, 0 })]
    [DataRow(new[] { 10, -10, 20, -20, 30 }, new[] { 10, -10, 20, -20, 30 })]
    [DataRow(new[] { 1, -1, 1, -1 }, new[] { -1, 1, -1, 1 })]
    [DataRow(new[] { 100 }, new[] { 100 })]
    [DataRow(new[] { -100 }, new[] { -100 })]
    [DataRow(new[] { -100, -47, 6, 59, -89, -36, 17, 70, -78, -25, 28, 81, -67, -14, 39, 92, -56, -3, 50, -98, -45, 8, 61, -87, -34, 19, 72, -76, -23, 30, 83, -65, -12, 41, 94, -54, -1, 52, -96, -43, 10, 63, -85, -32, 21, 74, -74, -21, 32, 85, -63, -10, 43, 96, -52, 1, 54, -94, -41, 12, 65, -83, -30, 23, 76, -72, -19, 34, 87, -61, -8, 45, 98, -50, 3, 56, -92, -39, 14, 67, -81, -28, 25, 78, -70, -17, 36, 89, -59, -6, 47, 100, -48, 5, 58, -90, -37, 16, 69, -79 }, new[] { -100, -52, -78, -30, 92, -61, -87, -39, 83, -70, -96, -48, 74, -79, 96, 70, 65, 39, 87, 8, 56, 30, 78, -1, 47, 21, 69, -10, -36, 12, -14, -19, -45, 3, -23, -28, -54, -6, -85, -37, -63, -89, -94, 81, -72, -98, 98, 72, -81, 94, 89, 63, -90, 85, 6, 54, 28, 23, -3, 45, 19, 14, -12, 36, 10, 5, -21, -47, 1, -78, -30, -56, -8, -87, -39, -65, -70, -96, -48, -74, -79, 96, 70, -83, 39, 87, 61, -92, 30, 78, 52, 100, 21, 69, 43, -36, 12, -14, 34, -45 })]
    public void ConstructTransformedArray_WithInputArray_ReturnsTransformedArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ConstructTransformedArray(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}