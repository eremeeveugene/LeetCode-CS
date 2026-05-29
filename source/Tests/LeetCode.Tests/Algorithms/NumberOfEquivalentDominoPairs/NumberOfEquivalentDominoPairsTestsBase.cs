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

using LeetCode.Algorithms.NumberOfEquivalentDominoPairs;

namespace LeetCode.Tests.Algorithms.NumberOfEquivalentDominoPairs;

public abstract class NumberOfEquivalentDominoPairsTestsBase<T> where T : INumberOfEquivalentDominoPairs, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void NumEquivDominoPairs_WithDominoList_ReturnsCountOfEquivalentPairs(int[][] dominoes,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumEquivDominoPairs(dominoes);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 3, 4 }, new[] { 5, 6 } }, 1];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 1 }, new[] { 1, 2 }, new[] { 2, 2 } }, 3];

        yield return [new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 1, 1 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 1 } }, 4];
    }
}
