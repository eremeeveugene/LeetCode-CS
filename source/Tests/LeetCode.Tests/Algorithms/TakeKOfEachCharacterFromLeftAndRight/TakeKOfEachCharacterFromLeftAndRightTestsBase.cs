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

using LeetCode.Algorithms.TakeKOfEachCharacterFromLeftAndRight;

namespace LeetCode.Tests.Algorithms.TakeKOfEachCharacterFromLeftAndRight;

public abstract class TakeKOfEachCharacterFromLeftAndRightTestsBase<T> where T : ITakeKOfEachCharacterFromLeftAndRight, new()
{
    [TestMethod]
    [DataRow("aabaaaacaabc", 2, 8)]
    [DataRow("a", 1, -1)]
    [DataRow("abc", 1, 3)]
    [DataRow("abc", 0, 0)]
    [DataRow("a", 0, 0)]
    [DataRow("aaa", 1, -1)]
    [DataRow("abcabc", 2, 6)]
    [DataRow("aabbcc", 2, 6)]
    [DataRow("cba", 1, 3)]
    [DataRow("aaabbbccc", 3, 9)]
    [DataRow("aaabbbccc", 1, 5)]
    [DataRow("ccbbaa", 2, 6)]
    [DataRow("abababab", 1, -1)]
    [DataRow("bbbbbbbbbc", 0, 0)]
    [DataRow("abccba", 2, 6)]
    [DataRow("acbbcaabca", 2, 6)]
    [DataRow("aaaabbbbcccc", 4, 12)]
    [DataRow("abcabcabc", 3, 9)]
    [DataRow("cccccbbbbbaaaaa", 5, 15)]
    [DataRow("abc", 2, -1)]
    [DataRow("bcbccccabacaaa", 2, 6)]
    [DataRow("abcacaacabba", 3, 10)]
    [DataRow("aaccbaa", 0, 0)]
    [DataRow("aaaab", 2, -1)]
    [DataRow("cccaacab", 2, -1)]
    [DataRow("bbaab", 0, 0)]
    [DynamicData(nameof(GetLargeTestData))]
    public void TakeCharacters_WithTargetCountFromEnds_ReturnsMinimumMinutesToCollectKOfEachCharacterOrMinusOne(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TakeCharacters(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [BuildBlocks(33333, 33333, 33334), 33333, 99999];

        yield return [BuildBlocks(33333, 33333, 33334), 1000, 35333];

        yield return [BuildBlocks(33333, 33333, 33334), 0, 0];

        yield return [BuildBlocks(100000, 0, 0), 1, -1];

        yield return [BuildRepeated(33333), 10000, 30000];

        yield return [BuildRepeated(33333), 33333, 99999];

        yield return [BuildBlocks(1, 99998, 1), 1, 3];
    }

    private static string BuildBlocks(int aCount, int bCount, int cCount)
    {
        return new string('a', aCount) + new string('b', bCount) + new string('c', cCount);
    }

    private static string BuildRepeated(int repeatCount)
    {
        var characters = new char[repeatCount * 3];

        for (var i = 0; i < repeatCount; i++)
        {
            characters[i * 3] = 'a';
            characters[(i * 3) + 1] = 'b';
            characters[(i * 3) + 2] = 'c';
        }

        return new string(characters);
    }
}