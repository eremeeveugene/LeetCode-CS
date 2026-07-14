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