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

using LeetCode.Algorithms.MinimumNumberOfArrowsToBurstBalloons;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfArrowsToBurstBalloons;

public abstract class MinimumNumberOfArrowsToBurstBalloonsTestsBase<T>
    where T : IMinimumNumberOfArrowsToBurstBalloons, new()
{
    [TestMethod]
    [DataRow("[[10,16],[2,8],[1,6],[7,12]]", 2)]
    [DataRow("[[1,2],[3,4],[5,6],[7,8]]", 4)]
    [DataRow("[[1,2],[2,3],[3,4],[4,5]]", 2)]
    [DataRow("[[3,9],[7,12],[3,8],[6,8],[9,10],[2,9],[0,9],[3,9],[0,6],[2,8]]", 2)]
    public void FindMinArrowShots_GivenDifferentPointCombinations_ReturnsMinimumArrowsRequired(string pointsJsonArray,
        int expectedResult)
    {
        // Arrange
        var points = JsonConvertHelper<int>.JsonArrayToJaggedArray(pointsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindMinArrowShots(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}