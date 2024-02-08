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

using LeetCode.Algorithms.FinalValueOfVariableAfterPerformingOperations;

namespace LeetCode.Tests.Algorithms.FinalValueOfVariableAfterPerformingOperations;

public abstract class FinalValueOfVariableAfterPerformingOperationsTestsBase<T>
    where T : IFinalValueOfVariableAfterPerformingOperations, new()
{
    [TestMethod]
    [DataRow(new[] { "--X", "X++", "X++" }, 1)]
    [DataRow(new[] { "++X", "++X", "X++" }, 3)]
    [DataRow(new[] { "X++", "++X", "--X", "X--" }, 0)]
    public void FinalValueAfterOperations_GivenOperationsArray_ReturnsExpectedFinalValue(string[] sentences,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FinalValueAfterOperations(sentences);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}