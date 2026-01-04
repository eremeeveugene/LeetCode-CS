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

using LeetCode.Algorithms.BestSightseeingPair;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BestSightseeingPair;

public abstract class BestSightseeingPairTestsBase<T> where T : IBestSightseeingPair, new()
{
    [TestMethod]
    [DataRow("[1,2]", 2)]
    [DataRow("[8,1,5,2,6]", 11)]
    public void MaxScoreSightseeingPair_WithValuesArray_ReturnsMaxScore(string valuesJson, int expectedResult)
    {
        // Arrange
        var values = JsonHelper<int[]>.Parse(valuesJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxScoreSightseeingPair(values);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}