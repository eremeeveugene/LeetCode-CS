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

using LeetCode.Algorithms.MinimumNumberOfOperationsToMoveAllBallsToEachBox;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfOperationsToMoveAllBallsToEachBox;

public abstract class MinimumNumberOfOperationsToMoveAllBallsToEachBoxTestsBase<T>
    where T : IMinimumNumberOfOperationsToMoveAllBallsToEachBox, new()
{
    [TestMethod]
    [DataRow("110", "[1,1,3]")]
    [DataRow("001011", "[11,8,5,4,3,4]")]
    public void MinOperations_WithBinaryString_ReturnsOperationsCountArray(string s, string expectedResultJson)
    {
        // Arrange
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(s);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}