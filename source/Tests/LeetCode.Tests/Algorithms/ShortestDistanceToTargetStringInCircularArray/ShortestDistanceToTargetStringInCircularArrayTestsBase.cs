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

using LeetCode.Algorithms.ShortestDistanceToTargetStringInCircularArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ShortestDistanceToTargetStringInCircularArray;

public abstract class ShortestDistanceToTargetStringInCircularArrayTestsBase<T>
    where T : IShortestDistanceToTargetStringInCircularArray, new()
{
    [TestMethod]
    [DataRow("[\"hello\",\"i\",\"am\",\"leetcode\",\"hello\"]", "hello", 1, 1)]
    [DataRow("[\"a\",\"b\",\"leetcode\"]", "leetcode", 0, 1)]
    [DataRow("[\"i\",\"eat\",\"leetcode\"]", "ate", 0, -1)]
    public void ClosetTarget_WithWordsArrayTargetAndStartIndex_ReturnsShortestDistanceToTargetString(
        string wordsJson, string target, int startIndex, int expectedResult)
    {
        // Arrange
        var words = JsonHelper.Parse<string[]>(wordsJson);

        var solution = new T();

        // Act
        var actualResult = solution.ClosetTarget(words, target, startIndex);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}