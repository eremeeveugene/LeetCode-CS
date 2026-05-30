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

using LeetCode.Algorithms.SumOfUniqueElements;

namespace LeetCode.Tests.Algorithms.SumOfUniqueElements;

public abstract class SumOfUniqueElementsTestsBase<T> where T : ISumOfUniqueElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 2 }, 4)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 15)]
    public void SumOfUnique_WithIntegerArray_ReturnsSumOfUniqueElements(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOfUnique(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}