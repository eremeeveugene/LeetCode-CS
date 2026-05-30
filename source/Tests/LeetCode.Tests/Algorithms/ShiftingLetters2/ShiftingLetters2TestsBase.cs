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

using LeetCode.Algorithms.ShiftingLetters2;

namespace LeetCode.Tests.Algorithms.ShiftingLetters2;

public abstract class ShiftingLetters2TestsBase<T> where T : IShiftingLetters2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ShiftingLetters_WithStringAndShiftArray_ReturnsShiftedString(string s, int[][] shifts, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ShiftingLetters(s, shifts);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return ["abc", new[] { new[] { 0, 1, 0 }, new[] { 1, 2, 1 }, new[] { 0, 2, 1 } }, "ace"];

        yield return ["dztz", new[] { new[] { 0, 0, 0 }, new[] { 1, 1, 1 } }, "catz"];

        yield return ["xuwdbdqik", new[] { new[] { 4, 8, 0 }, new[] { 4, 4, 0 }, new[] { 2, 4, 0 }, new[] { 2, 4, 0 }, new[] { 6, 7, 1 }, new[] { 2, 2, 1 }, new[] { 0, 2, 1 }, new[] { 8, 8, 0 }, new[] { 1, 3, 1 } }, "ywxcxcqii"];
    }
}