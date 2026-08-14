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

using LeetCode.Algorithms.RearrangeStringToAvoidCharacterPair;

namespace LeetCode.Tests.Algorithms.RearrangeStringToAvoidCharacterPair;

public abstract class RearrangeStringToAvoidCharacterPairTestsBase<T> where T : IRearrangeStringToAvoidCharacterPair, new()
{
    [TestMethod]
    [DataRow("aabc", 'a', 'c')]
    [DataRow("dcab", 'd', 'b')]
    [DataRow("axe", 'o', 'x')]
    [DataRow("a", 'a', 'b')]
    [DataRow("b", 'a', 'b')]
    [DataRow("ab", 'a', 'b')]
    [DataRow("ba", 'a', 'b')]
    [DataRow("aaaa", 'a', 'b')]
    [DataRow("bbbb", 'a', 'b')]
    [DataRow("abab", 'a', 'b')]
    [DataRow("baba", 'a', 'b')]
    [DataRow("xyz", 'x', 'y')]
    [DataRow("zyx", 'x', 'y')]
    [DataRow("ccccxxxx", 'x', 'c')]
    [DataRow("mnopqr", 'm', 'r')]
    [DataRow("aabbccxxyy", 'x', 'y')]
    [DataRow("qwertyuiop", 'q', 'p')]
    [DataRow("thequickbrownfox", 't', 'x')]
    [DataRow("zzzzzzzzzzzzzzzzzzzz", 'a', 'z')]
    [DataRow("m", 'm', 'n')]
    public void RearrangeString_WithSXAndY_ReturnsValidPermutationWithYBeforeX(string s, char x, char y)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RearrangeString(s, x, y);

        // Assert
        AssertIsPermutation(s, actualResult);
        AssertEveryYBeforeEveryX(actualResult, x, y);
    }

    private static void AssertIsPermutation(string s, string actualResult)
    {
        var expectedCharacters = s.ToCharArray();
        var actualCharacters = actualResult.ToCharArray();

        Array.Sort(expectedCharacters);
        Array.Sort(actualCharacters);

        Assert.AreSequenceEqual(expectedCharacters, actualCharacters);
    }

    private static void AssertEveryYBeforeEveryX(string actualResult, char x, char y)
    {
        var lastIndexOfY = actualResult.LastIndexOf(y);
        var firstIndexOfX = actualResult.IndexOf(x);

        if (lastIndexOfY == -1 || firstIndexOfX == -1)
        {
            return;
        }

        Assert.IsLessThan(firstIndexOfX, lastIndexOfY);
    }
}