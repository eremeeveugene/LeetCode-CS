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

using LeetCode.Algorithms.FindTheNumberOfWaysToPlacePeople1;

namespace LeetCode.Tests.Algorithms.FindTheNumberOfWaysToPlacePeople1;

public abstract class FindTheNumberOfWaysToPlacePeople1TestsBase<T> where T : IFindTheNumberOfWaysToPlacePeople1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void NumberOfPairs_With2DPointsArray_ReturnsCountOfValidPairs(int[][] points, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfPairs(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 0];

        yield return [new[] { new[] { 3, 1 }, new[] { 1, 3 }, new[] { 1, 1 } }, 2];

        yield return [new[] { new[] { 6, 2 }, new[] { 4, 4 }, new[] { 2, 6 } }, 2];

        yield return [new[] { new[] { 6, 2 }, new[] { 4, 4 }, new[] { 2, 6 }, new[] { 4, 8 } }, 3];

        yield return [new[] { new[] { 6, 2 }, new[] { 4, 4 }, new[] { 2, 6 }, new[] { 4, 8 }, new[] { 1, 4 } }, 4];

        yield return [new[] { new[] { 6, 2 }, new[] { 4, 4 }, new[] { 2, 6 }, new[] { 4, 8 }, new[] { 1, 4 }, new[] { 2, 2 } }, 7];

        yield return [new[] { new[] { 4, 6 }, new[] { 3, 6 } }, 1];

        yield return [new[] { new[] { 3, 4 }, new[] { 6, 4 } }, 1];

        yield return [new[] { new[] { 5, 4 }, new[] { 4, 3 }, new[] { 1, 6 } }, 2];

        yield return [new[] { new[] { 3, 2 }, new[] { 1, 0 }, new[] { 4, 6 } }, 0];

        yield return [new[] { new[] { 5, 1 }, new[] { 4, 3 }, new[] { 3, 5 }, new[] { 5, 4 } }, 4];

        yield return [new[] { new[] { 0, 0 }, new[] { 6, 3 }, new[] { 1, 1 }, new[] { 4, 0 } }, 2];

        yield return [new[] { new[] { 5, 0 }, new[] { 3, 0 }, new[] { 5, 2 }, new[] { 3, 5 }, new[] { 4, 1 } }, 6];

        yield return [new[] { new[] { 1, 4 }, new[] { 2, 0 }, new[] { 5, 2 }, new[] { 2, 6 }, new[] { 0, 4 } }, 5];

        yield return [new[] { new[] { 0, 3 }, new[] { 5, 0 }, new[] { 0, 6 }, new[] { 1, 1 }, new[] { 3, 5 }, new[] { 3, 0 } }, 6];

        yield return [new[] { new[] { 6, 5 }, new[] { 3, 6 }, new[] { 2, 0 }, new[] { 0, 2 }, new[] { 0, 1 }, new[] { 2, 2 } }, 5];

        yield return [new[] { new[] { 4, 1 }, new[] { 6, 1 }, new[] { 6, 3 }, new[] { 3, 4 }, new[] { 1, 5 }, new[] { 3, 5 }, new[] { 3, 0 } }, 7];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 3 }, new[] { 6, 4 }, new[] { 0, 1 }, new[] { 1, 1 }, new[] { 5, 4 }, new[] { 3, 2 }, new[] { 0, 6 } }, 8];

        yield return [new[] { new[] { 1, 4 }, new[] { 0, 4 }, new[] { 3, 6 }, new[] { 6, 3 }, new[] { 4, 1 }, new[] { 4, 3 }, new[] { 2, 2 }, new[] { 5, 1 } }, 8];

        yield return [new[] { new[] { 0, 4 }, new[] { 4, 0 }, new[] { 5, 4 }, new[] { 2, 1 }, new[] { 3, 3 }, new[] { 3, 0 }, new[] { 1, 5 }, new[] { 0, 0 }, new[] { 5, 1 } }, 14];
    }
}