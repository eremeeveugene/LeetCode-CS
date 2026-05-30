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

using LeetCode.Algorithms.FindTheNumberOfWaysToPlacePeople2;

namespace LeetCode.Tests.Algorithms.FindTheNumberOfWaysToPlacePeople2;

public abstract class FindTheNumberOfWaysToPlacePeople2TestsBase<T> where T : IFindTheNumberOfWaysToPlacePeople2, new()
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
    }
}