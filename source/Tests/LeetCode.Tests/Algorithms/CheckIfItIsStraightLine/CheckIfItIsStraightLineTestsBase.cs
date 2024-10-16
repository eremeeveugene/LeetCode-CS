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

using LeetCode.Algorithms.CheckIfItIsStraightLine;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheckIfItIsStraightLine;

public abstract class CheckIfItIsStraightLineTestsBase<T> where T : ICheckIfItIsStraightLine, new()
{
    [TestMethod]
    [DataRow("[[0,1],[2,4],[3,3]]", false)]
    [DataRow("[[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]", true)]
    [DataRow("[[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]", false)]
    public void CheckStraightLine_WithGivenCoordinates_ReturnsIfPointsFormStraightLine(string coordinatesJsonArray,
        bool expectedResult)
    {
        // Arrange
        var coordinates = JsonHelper<int>.DeserializeToJaggedArray(coordinatesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CheckStraightLine(coordinates);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}