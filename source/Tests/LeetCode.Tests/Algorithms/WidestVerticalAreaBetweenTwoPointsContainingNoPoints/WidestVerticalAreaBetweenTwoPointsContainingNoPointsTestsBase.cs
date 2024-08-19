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

using LeetCode.Algorithms.WidestVerticalAreaBetweenTwoPointsContainingNoPoints;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.WidestVerticalAreaBetweenTwoPointsContainingNoPoints;

public abstract class WidestVerticalAreaBetweenTwoPointsContainingNoPointsTestsBase<T>
    where T : IWidestVerticalAreaBetweenTwoPointsContainingNoPoints, new()
{
    [TestMethod]
    [DataRow("[[8, 7], [9, 9], [7, 4], [9, 7]]", 1)]
    [DataRow("[[3,1],[9,0],[1,0],[1,4],[5,3],[8,8]]", 3)]
    public void MaxWidthOfVerticalArea_WithJsonPoints_ReturnsMaxWidth(string jsonPoints, int expectedResult)
    {
        // Arrange
        var points = JsonHelper<int>.DeserializeToJaggedArray(jsonPoints);

        var solution = new T();

        // Act
        var actualResult = solution.MaxWidthOfVerticalArea(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}