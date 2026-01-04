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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheNumberOfWaysToPlacePeople1;

public abstract class FindTheNumberOfWaysToPlacePeople1TestsBase<T> where T : IFindTheNumberOfWaysToPlacePeople1, new()
{
    [TestMethod]
    [DataRow("[[1,1],[2,2],[3,3]]", 0)]
    [DataRow("[[3,1],[1,3],[1,1]]", 2)]
    [DataRow("[[6,2],[4,4],[2,6]]", 2)]
    [DataRow("[[6,2],[4,4],[2,6],[4,8]]", 3)]
    [DataRow("[[6,2],[4,4],[2,6],[4,8],[1,4]]", 4)]
    [DataRow("[[6,2],[4,4],[2,6],[4,8],[1,4],[2,2]]", 7)]
    public void NumberOfPairs_With2DPointsArray_ReturnsCountOfValidPairs(string pointsJson,
        int expectedResult)
    {
        // Arrange
        var points = JsonHelper<int[][]>.Parse(pointsJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumberOfPairs(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}