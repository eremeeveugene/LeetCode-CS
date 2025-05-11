// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumNumberGame;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumNumberGame;

public abstract class MinimumNumberGameTestsBase<T> where T : IMinimumNumberGame, new()
{
    [TestMethod]
    [DataRow("[5, 4, 2, 3]", "[3, 2, 5, 4]")]
    [DataRow("[2, 5]", "[5, 2]")]
    public void NumberGame_WithEvenLengthArray_ReturnsArrayConstructedFromAlternatingMinSelections(string costJson,
        string expectedResultJson)
    {
        // Arrange
        var cost = JsonHelper<int[]>.Parse(costJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumberGame(cost);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}