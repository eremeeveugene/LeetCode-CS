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

using LeetCode.Algorithms.RelativeRanks;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RelativeRanks;

public abstract class RelativeRanksTestsBase<T> where T : IRelativeRanks, new()
{
    [TestMethod]
    [DataRow("[5,4,3,2,1]", "[\"Gold Medal\",\"Silver Medal\",\"Bronze Medal\",\"4\",\"5\"]")]
    [DataRow("[10,3,8,9,4]", "[\"Gold Medal\",\"5\",\"Bronze Medal\",\"Silver Medal\",\"4\"]")]
    public void FindRelativeRanks_GivenScores_ReturnsCorrespondingMedalsAndPositions(string scoreJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var score = JsonHelper<int>.DeserializeToArray(scoreJsonArray);
        var expectedResult = JsonHelper<string>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindRelativeRanks(score);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}