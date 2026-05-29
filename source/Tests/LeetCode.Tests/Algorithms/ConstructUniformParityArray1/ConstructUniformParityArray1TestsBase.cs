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

using LeetCode.Algorithms.ConstructUniformParityArray1;

namespace LeetCode.Tests.Algorithms.ConstructUniformParityArray1;

public abstract class ConstructUniformParityArray1TestsBase<T> where T : IConstructUniformParityArray1, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3 }, true)]
    [DataRow(new[] { 4, 6 }, true)]
    public void UniformArray_WithDistinctIntegerArray_ReturnsTrueIfUniformParityArrayCanBeConstructed(int[] nums,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.UniformArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}