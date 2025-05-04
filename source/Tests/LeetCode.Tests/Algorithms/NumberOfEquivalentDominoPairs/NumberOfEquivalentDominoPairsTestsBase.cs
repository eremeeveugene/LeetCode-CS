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

using LeetCode.Algorithms.NumberOfEquivalentDominoPairs;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NumberOfEquivalentDominoPairs;

public abstract class NumberOfEquivalentDominoPairsTestsBase<T> where T : INumberOfEquivalentDominoPairs, new()
{
    [TestMethod]
    [DataRow("[[1,2],[2,1],[3,4],[5,6]]", 1)]
    [DataRow("[[1,2],[1,2],[1,1],[1,2],[2,2]]", 3)]
    [DataRow("[[1,1],[2,2],[1,1],[1,2],[1,2],[1,1]]", 4)]
    public void NumEquivDominoPairs_WithDominoPairsArray_ReturnsCorrectEquivalentPairCount(string dominoesJsonArray,
        int expectedResult)
    {
        // Arrange
        var dominoes = JsonHelper<int>.DeserializeToJaggedArray(dominoesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.NumEquivDominoPairs(dominoes);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}