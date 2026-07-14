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