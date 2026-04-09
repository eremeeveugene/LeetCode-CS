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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindMissingAndRepeatedValues;

public abstract class FindMissingAndRepeatedValuesTestsBase<T> where T : IFindMissingAndRepeatedValues, new()
{
    [TestMethod]
    [DataRow("[[1,3],[2,2]]", "[2,4]")]
    [DataRow("[[9,1,7],[8,9,2],[3,4,6]]", "[9,5]")]
    public void FindMissingAndRepeatedValues_GivenGrid_ReturnsMissingAndRepeatedNumbers(string gridJson,
        string expectedResultJson)
    {
        // Arrange
        var grid = JsonHelper.Parse<int[][]>(gridJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindMissingAndRepeatedValues(grid);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}