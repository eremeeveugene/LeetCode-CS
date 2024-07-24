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

using LeetCode.Algorithms.SortTheJumbledNumbers;

namespace LeetCode.Tests.Algorithms.SortTheJumbledNumbers;

public abstract class SortTheJumbledNumbersTestsBase<T> where T : ISortTheJumbledNumbers, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 789, 456, 123 }, new[] { 123, 456, 789 })]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
    [DataRow(new[] { 8, 9, 4, 0, 2, 1, 3, 5, 7, 6 }, new[] { 991, 338, 38 }, new[] { 338, 38, 991 })]
    public void SortJumbled_WithGivenMappingAndNumbers_ReturnsCorrectOrder(int[] mapping, int[] nums,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortJumbled(mapping, nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}