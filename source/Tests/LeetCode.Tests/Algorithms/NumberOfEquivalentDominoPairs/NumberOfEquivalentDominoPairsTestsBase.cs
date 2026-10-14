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
    public void NumEquivDominoPairs_WithDominoList_ReturnsCountOfEquivalentPairs(int[][] dominoes, int expectedResult)
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

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 1];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 0];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 1 } }, 1];

        yield return [new[] { new[] { 9, 9 }, new[] { 9, 9 }, new[] { 9, 9 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 } }, 6];

        yield return [new[] { new[] { 1, 9 }, new[] { 9, 1 }, new[] { 1, 9 } }, 3];

        yield return [new[] { new[] { 1, 1 } }, 0];

        yield return [new[] { new[] { 5, 6 }, new[] { 6, 5 }, new[] { 5, 5 }, new[] { 6, 6 }, new[] { 5, 6 } }, 3];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 1, 5 }, new[] { 1, 6 }, new[] { 1, 7 }, new[] { 1, 8 }, new[] { 1, 9 }, new[] { 2, 1 }, new[] { 2, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 2, 5 }, new[] { 2, 6 }, new[] { 2, 7 }, new[] { 2, 8 }, new[] { 2, 9 }, new[] { 3, 1 }, new[] { 3, 2 }, new[] { 3, 3 }, new[] { 3, 4 }, new[] { 3, 5 }, new[] { 3, 6 }, new[] { 3, 7 }, new[] { 3, 8 }, new[] { 3, 9 }, new[] { 4, 1 }, new[] { 4, 2 }, new[] { 4, 3 }, new[] { 4, 4 }, new[] { 4, 5 }, new[] { 4, 6 }, new[] { 4, 7 }, new[] { 4, 8 }, new[] { 4, 9 }, new[] { 5, 1 }, new[] { 5, 2 }, new[] { 5, 3 }, new[] { 5, 4 }, new[] { 5, 5 }, new[] { 5, 6 }, new[] { 5, 7 }, new[] { 5, 8 }, new[] { 5, 9 }, new[] { 6, 1 }, new[] { 6, 2 }, new[] { 6, 3 }, new[] { 6, 4 }, new[] { 6, 5 }, new[] { 6, 6 }, new[] { 6, 7 }, new[] { 6, 8 }, new[] { 6, 9 }, new[] { 7, 1 }, new[] { 7, 2 }, new[] { 7, 3 }, new[] { 7, 4 }, new[] { 7, 5 }, new[] { 7, 6 }, new[] { 7, 7 }, new[] { 7, 8 }, new[] { 7, 9 }, new[] { 8, 1 }, new[] { 8, 2 }, new[] { 8, 3 }, new[] { 8, 4 }, new[] { 8, 5 }, new[] { 8, 6 }, new[] { 8, 7 }, new[] { 8, 8 }, new[] { 8, 9 }, new[] { 9, 1 }, new[] { 9, 2 }, new[] { 9, 3 }, new[] { 9, 4 }, new[] { 9, 5 }, new[] { 9, 6 }, new[] { 9, 7 }, new[] { 9, 8 }, new[] { 9, 9 } }, 36];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 } }, 45];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 2, 1 } }, 4950];

        yield return [new[] { new[] { 8, 5 }, new[] { 9, 6 }, new[] { 3, 7 }, new[] { 1, 6 }, new[] { 8, 5 }, new[] { 8, 4 }, new[] { 9, 1 }, new[] { 3, 8 } }, 1];

        yield return [new[] { new[] { 6, 3 }, new[] { 6, 4 }, new[] { 1, 4 }, new[] { 2, 9 }, new[] { 6, 7 }, new[] { 2, 1 }, new[] { 1, 9 }, new[] { 4, 2 }, new[] { 7, 8 }, new[] { 2, 7 }, new[] { 3, 9 }, new[] { 6, 9 }, new[] { 3, 1 }, new[] { 9, 3 }, new[] { 9, 2 } }, 2];

        yield return [new[] { new[] { 7, 7 }, new[] { 8, 8 }, new[] { 7, 9 }, new[] { 1, 2 }, new[] { 4, 5 }, new[] { 6, 6 }, new[] { 7, 5 }, new[] { 2, 5 }, new[] { 4, 6 }, new[] { 6, 6 }, new[] { 9, 9 }, new[] { 3, 1 }, new[] { 7, 7 }, new[] { 1, 9 }, new[] { 1, 4 }, new[] { 7, 1 }, new[] { 7, 4 }, new[] { 2, 9 }, new[] { 4, 3 }, new[] { 2, 5 }, new[] { 1, 7 }, new[] { 5, 8 }, new[] { 6, 1 }, new[] { 9, 8 }, new[] { 6, 4 }, new[] { 6, 5 }, new[] { 8, 8 }, new[] { 8, 4 }, new[] { 3, 8 }, new[] { 9, 6 } }, 6];

        yield return [new[] { new[] { 3, 4 }, new[] { 4, 1 }, new[] { 5, 6 }, new[] { 3, 4 }, new[] { 1, 9 }, new[] { 1, 4 }, new[] { 2, 6 }, new[] { 9, 9 }, new[] { 3, 1 }, new[] { 6, 5 }, new[] { 2, 4 }, new[] { 9, 9 }, new[] { 8, 8 }, new[] { 6, 5 }, new[] { 8, 3 }, new[] { 8, 5 }, new[] { 1, 5 }, new[] { 6, 9 }, new[] { 8, 4 }, new[] { 5, 9 }, new[] { 5, 1 }, new[] { 1, 1 }, new[] { 3, 9 }, new[] { 5, 7 }, new[] { 3, 4 }, new[] { 4, 7 }, new[] { 8, 1 }, new[] { 9, 5 }, new[] { 1, 7 }, new[] { 7, 2 }, new[] { 7, 4 }, new[] { 9, 6 }, new[] { 6, 7 }, new[] { 3, 1 }, new[] { 3, 1 }, new[] { 1, 2 }, new[] { 7, 9 }, new[] { 4, 7 }, new[] { 2, 6 }, new[] { 4, 5 }, new[] { 5, 9 }, new[] { 8, 2 }, new[] { 4, 9 }, new[] { 7, 4 }, new[] { 2, 7 }, new[] { 6, 6 }, new[] { 2, 6 }, new[] { 3, 2 }, new[] { 5, 5 }, new[] { 3, 7 }, new[] { 6, 3 }, new[] { 1, 4 }, new[] { 8, 8 }, new[] { 8, 3 }, new[] { 1, 6 }, new[] { 8, 4 }, new[] { 6, 2 }, new[] { 4, 1 }, new[] { 6, 6 }, new[] { 5, 4 }, new[] { 7, 5 }, new[] { 4, 9 }, new[] { 3, 9 }, new[] { 6, 3 }, new[] { 9, 8 }, new[] { 7, 9 }, new[] { 4, 8 }, new[] { 8, 1 }, new[] { 4, 7 }, new[] { 9, 7 }, new[] { 9, 8 }, new[] { 1, 2 }, new[] { 9, 5 }, new[] { 6, 1 }, new[] { 6, 8 }, new[] { 6, 5 }, new[] { 3, 3 }, new[] { 8, 4 }, new[] { 9, 3 }, new[] { 5, 8 }, new[] { 1, 7 }, new[] { 6, 5 }, new[] { 7, 5 }, new[] { 7, 6 }, new[] { 3, 3 }, new[] { 5, 1 }, new[] { 7, 7 }, new[] { 7, 5 }, new[] { 6, 7 }, new[] { 7, 8 }, new[] { 7, 7 }, new[] { 3, 3 }, new[] { 4, 5 }, new[] { 2, 5 }, new[] { 9, 1 }, new[] { 6, 5 }, new[] { 3, 5 }, new[] { 4, 1 }, new[] { 9, 5 }, new[] { 1, 1 } }, 104];

        yield return [new[] { new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 }, new[] { 9, 8 } }, 4950];

        yield return [new[] { new[] { 3, 4 }, new[] { 4, 3 }, new[] { 4, 4 }, new[] { 3, 3 }, new[] { 3, 4 }, new[] { 5, 5 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 }, new[] { 9, 1 } }, 0];
    }
}