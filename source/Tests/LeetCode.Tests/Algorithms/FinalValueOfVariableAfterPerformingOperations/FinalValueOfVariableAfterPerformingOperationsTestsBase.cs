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

using LeetCode.Algorithms.FinalValueOfVariableAfterPerformingOperations;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FinalValueOfVariableAfterPerformingOperations;

public abstract class FinalValueOfVariableAfterPerformingOperationsTestsBase<T>
    where T : IFinalValueOfVariableAfterPerformingOperations, new()
{
    [TestMethod]
    [DataRow("[\"--X\", \"X++\", \"X++\"]", 1)]
    [DataRow("[\"++X\", \"++X\", \"X++\"]", 3)]
    [DataRow("[\"X++\", \"++X\", \"--X\", \"X--\"]", 0)]
    public void FinalValueAfterOperations_WithOperationStrings_ReturnsFinalValueOfVariable(string sentencesJson,
        int expectedResult)
    {
        // Arrange
        var sentences = JsonHelper.Parse<string[]>(sentencesJson);

        var solution = new T();

        // Act
        var actualResult = solution.FinalValueAfterOperations(sentences);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}