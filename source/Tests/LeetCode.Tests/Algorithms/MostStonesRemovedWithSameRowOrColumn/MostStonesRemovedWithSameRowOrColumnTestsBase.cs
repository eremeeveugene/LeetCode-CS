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

using LeetCode.Algorithms.MostStonesRemovedWithSameRowOrColumn;

namespace LeetCode.Tests.Algorithms.MostStonesRemovedWithSameRowOrColumn;

public abstract class MostStonesRemovedWithSameRowOrColumnTestsBase<T>
    where T : IMostStonesRemovedWithSameRowOrColumn, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RemoveStones_WithGridOfStones_ReturnsMaxRemovableStones(int[][] stones, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveStones(stones);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 0 } }, 0];

        yield return [new[] { new[] { 0, 0 }, new[] { 2, 2 }, new[] { 10000, 2 } }, 1];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 2 }, new[] { 1, 1 }, new[] { 2, 0 }, new[] { 2, 2 } }, 3];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 2, 2 } }, 5];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 0 }, new[] { 2, 0 }, new[] { 1, 1 }, new[] { 1, 2 }, new[] { 2, 2 } }, 5];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 4 }, new[] { 1, 5 }, new[] { 2, 4 }, new[] { 2, 6 } }, 5];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 1, 4 }, new[] { 1, 5 }, new[] { 2, 4 }, new[] { 2, 6 } }, 6];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 2 }, new[] { 2, 0 }, new[] { 2, 3 }, new[] { 3, 0 }, new[] { 3, 4 } }, 7];

        yield return [new[] { new[] { 0, 5 }, new[] { 1, 5 }, new[] { 2, 5 }, new[] { 3, 5 }, new[] { 0, 4 }, new[] { 0, 6 }, new[] { 1, 3 }, new[] { 1, 7 }, new[] { 2, 2 }, new[] { 2, 8 }, new[] { 3, 1 }, new[] { 3, 9 } }, 11];
    }
}