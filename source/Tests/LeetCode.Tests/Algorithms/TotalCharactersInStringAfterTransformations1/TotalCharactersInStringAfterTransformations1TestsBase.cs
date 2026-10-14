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

using LeetCode.Algorithms.TotalCharactersInStringAfterTransformations1;

namespace LeetCode.Tests.Algorithms.TotalCharactersInStringAfterTransformations1;

public abstract class TotalCharactersInStringAfterTransformations1TestsBase<T> where T : ITotalCharactersInStringAfterTransformations1, new()
{
    [TestMethod]
    [DataRow("abcyy", 2, 7)]
    [DataRow("azbk", 1, 5)]
    [DataRow("z", 100, 16)]
    [DataRow("a", 1, 1)]
    [DataRow("a", 25, 1)]
    [DataRow("a", 26, 2)]
    [DataRow("z", 1, 2)]
    [DataRow("z", 2, 2)]
    [DataRow("abc", 1, 3)]
    [DataRow("zzz", 1, 6)]
    [DataRow("xyz", 3, 6)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 1, 27)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 26, 53)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 100, 396)]
    [DataRow("az", 50, 6)]
    [DataRow("aaaaaaaaaa", 30, 20)]
    [DataRow("yyyyy", 5, 10)]
    [DataRow("leetcode", 1000, 279226797)]
    [DataRow("zebra", 777, 408726291)]
    [DataRow("b", 99999, 413966020)]
    [DynamicData(nameof(GetLargeTestData))]
    public void LengthAfterTransformations_WithStringAndTransformationCount_ReturnsFinalStringLengthAfterTransformations(
        string input,
        int transformationsCount,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LengthAfterTransformations(input, transformationsCount);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [BuildString(100000, 0), 100000, 601710228];

        yield return [BuildString(100000, 25), 100000, 323225804];

        yield return [BuildString(100000, 26), 100000, 926463126];

        yield return [BuildString(100000, 26), 1, 103846];
    }

    private static string BuildString(int length, int distinctCount)
    {
        var characters = new char[length];

        for (var i = 0; i < length; i++)
        {
            characters[i] = (char)('a' + (distinctCount == 26 ? i % 26 : distinctCount));
        }

        return new string(characters);
    }
}