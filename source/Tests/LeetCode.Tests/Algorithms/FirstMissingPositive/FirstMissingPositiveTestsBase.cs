// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FirstMissingPositive;

namespace LeetCode.Tests.Algorithms.FirstMissingPositive;

public abstract class FirstMissingPositiveTestsBase<T> where T : IFirstMissingPositive, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 0 }, 3)]
    [DataRow(new[] { 3, 4, -1, 1 }, 2)]
    [DataRow(new[] { 7, 8, 9, 11, 12 }, 1)]
    public void FirstMissingPositive_GivenArray_ReturnsFirstMissingPositiveInteger(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FirstMissingPositive(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}