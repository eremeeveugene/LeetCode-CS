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

using LeetCode.Algorithms.FindTheTownJudge;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheTownJudge;

public abstract class FindTheTownJudgeTestsBase<T> where T : IFindTheTownJudge, new()
{
    [TestMethod]
    [DataRow(1, "[]", 1)]
    [DataRow(2, "[]", -1)]
    [DataRow(2, "[[1,2]]", 2)]
    [DataRow(3, "[[1,3],[2,3]]", 3)]
    [DataRow(3, "[[1,3],[2,3],[3,1]]", -1)]
    public void FindJudge_WithDifferentTrustRelationships_ReturnsCorrectJudgeOrMinusOne(int n, string jsonTrust,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        var trust = JsonHelper<int>.DeserializeToJaggedArray(jsonTrust);

        // Act
        var actualResult = solution.FindJudge(n, trust);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}