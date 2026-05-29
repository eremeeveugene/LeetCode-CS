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

using LeetCode.Algorithms.FindMissingAndRepeatedValues;

namespace LeetCode.Tests.Algorithms.FindMissingAndRepeatedValues;

public abstract class FindMissingAndRepeatedValuesTestsBase<T> where T : IFindMissingAndRepeatedValues, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindMissingAndRepeatedValues_GivenGrid_ReturnsMissingAndRepeatedNumbers(int[][] grid,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMissingAndRepeatedValues(grid);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 3 }, new[] { 2, 2 } }, new[] { 2, 4 }];

        yield return [new[] { new[] { 9, 1, 7 }, new[] { 8, 9, 2 }, new[] { 3, 4, 6 } }, new[] { 9, 5 }];
    }
}