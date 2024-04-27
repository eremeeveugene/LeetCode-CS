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

using LeetCode.Algorithms.FreedomTrail;

namespace LeetCode.Tests.Algorithms.FreedomTrail;

public abstract class FreedomTrailTestsBase<T> where T : IFreedomTrail, new()
{
    [TestMethod]
    [DataRow("abcde", "ade", 6)]
    [DataRow("godding", "gd", 4)]
    [DataRow("edcba", "abcde", 10)]
    [DataRow("fgtng", "tnggf", 10)]
    [DataRow("godding", "godding", 13)]
    [DataRow("caotmcaataijjxi", "oatjiioicitatajtijciocjcaaxaaatmctxamacaamjjx", 137)]
    public void FindRotateSteps_WithRingAndKey_ReturnsExpectedSteps(string ring, string key, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindRotateSteps(ring, key);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}