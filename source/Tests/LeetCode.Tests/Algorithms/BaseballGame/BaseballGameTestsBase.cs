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

using LeetCode.Algorithms.BaseballGame;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BaseballGame;

public abstract class BaseballGameTestsBase<T> where T : IBaseballGame, new()
{
    [TestMethod]
    [DataRow("[\"5\",\"2\",\"C\",\"D\",\"+\"]", 30)]
    [DataRow("[\"5\",\"-2\",\"4\",\"C\",\"D\",\"9\",\"+\",\"+\"]", 27)]
    public void CalPoints_WithOperationsArray_ReturnsTotalPoints(string operationsJsonArray, int expectedResult)
    {
        // Arrange
        var operations = JsonHelper<string>.DeserializeToArray(operationsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CalPoints(operations);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}