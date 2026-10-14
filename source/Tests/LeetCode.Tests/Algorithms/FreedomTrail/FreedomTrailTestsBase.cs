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
    [DataRow("a", "a", 1)]
    [DataRow("ab", "b", 2)]
    [DataRow("ab", "ba", 4)]
    [DataRow("abc", "cba", 6)]
    [DataRow("aaa", "aaaa", 4)]
    [DataRow("abcabc", "cab", 6)]
    [DataRow("zzzz", "zz", 2)]
    [DataRow("abcdefghij", "jihgfedcba", 20)]
    [DataRow("abcdefghij", "acegi", 13)]
    [DataRow("xyxyxy", "yxyxyx", 12)]
    [DataRow("godding", "dig", 9)]
    [DataRow("qwertyuiop", "poiuytrewq", 20)]
    [DataRow("aabbcc", "cbaabc", 14)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "zyxabc", 14)]
    public void FindRotateSteps_WithRingAndKey_ReturnsMinimumStepsToSpellKeyUsingRotationsAndPresses(string ring, string key, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindRotateSteps(ring, key);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}