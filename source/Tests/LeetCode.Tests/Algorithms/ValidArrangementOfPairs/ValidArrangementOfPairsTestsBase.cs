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

using LeetCode.Algorithms.ValidArrangementOfPairs;

namespace LeetCode.Tests.Algorithms.ValidArrangementOfPairs;

public abstract class ValidArrangementOfPairsTestsBase<T> where T : IValidArrangementOfPairs, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ValidArrangement_WithDirectedEdgePairs_ReturnsValidArrangementOfPairs(int[][] pairs,
        int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ValidArrangement(pairs);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[]
            {
                new[] { 4, 5 }, new[] { 11, 9 }, new[] { 9, 4 }, new[] { 5, 2 }, new[] { 2, 6 }, new[] { 6, 7 },
                new[] { 7, 8 }, new[] { 8, 5 }, new[] { 5, 12 }, new[] { 12, 13 }, new[] { 13, 5 }, new[] { 5, 1 }
            },
            new[]
            {
                new[] { 11, 9 }, new[] { 9, 4 }, new[] { 4, 5 }, new[] { 5, 12 }, new[] { 12, 13 }, new[] { 13, 5 },
                new[] { 5, 2 }, new[] { 2, 6 }, new[] { 6, 7 }, new[] { 7, 8 }, new[] { 8, 5 }, new[] { 5, 1 }
            }
        ];
    }
}