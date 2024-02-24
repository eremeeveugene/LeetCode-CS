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

using LeetCode.Algorithms.MinimumNumberGame;

namespace LeetCode.Tests.Algorithms.MinimumNumberGame;

public abstract class MinimumNumberGameTestsBase<T> where T : IMinimumNumberGame, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 4, 2, 3 }, new[] { 3, 2, 5, 4 })]
    [DataRow(new[] { 2, 5 }, new[] { 5, 2 })]
    public void NumberGame_GivenCostArray_ReturnsExpectedRearrangedArray(int[] cost, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberGame(cost);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}