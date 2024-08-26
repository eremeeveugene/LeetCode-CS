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

using LeetCode.Algorithms.HandOfStraights;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.HandOfStraights;

public abstract class HandOfStraightsTestsBase<T> where T : IHandOfStraights, new()
{
    [TestMethod]
    [DataRow("[]", 1, true)]
    [DataRow("[1]", 1, true)]
    [DataRow("[1, 2, 3, 6, 2, 3, 4, 7, 8]", 3, true)]
    [DataRow("[1, 2, 3, 4, 5]", 4, false)]
    [DataRow("[8, 10, 12]", 3, false)]
    [DataRow("[8, 9, 10]", 3, true)]
    [DataRow("[8, 7, 4, 3, 2, 6, 3, 2, 1]", 3, true)]
    [DataRow("[1, 2, 3]", 1, true)]
    [DataRow("[1, 1, 1, 1]", 4, false)]
    [DataRow("[1, 1, 1, 1]", 3, false)]
    [DataRow("[1, 2, 3, 4, 5, 6, 7, 8, 9]", 3, true)]
    [DataRow("[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]", 5, true)]
    [DataRow("[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]", 4, false)]
    [DataRow("[3, 3, 2, 2, 1, 1]", 3, true)]
    [DataRow("[1, 2, 3, 5, 6, 7, 9, 10, 11]", 3, true)]
    public void IsNStraightHand_GivenHandAndGroupSize_ReturnsExpectedResult(string handJsonArray, int groupSize,
        bool expectedResult)
    {
        // Arrange
        var hand = JsonHelper<int>.DeserializeToArray(handJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.IsNStraightHand(hand, groupSize);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}