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

using LeetCode.Algorithms.ShiftingLetters2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ShiftingLetters2;

public abstract class ShiftingLetters2TestsBase<T> where T : IShiftingLetters2, new()
{
    [TestMethod]
    [DataRow("abc", "[[0,1,0],[1,2,1],[0,2,1]]", "ace")]
    [DataRow("dztz", "[[0,0,0],[1,1,1]]", "catz")]
    [DataRow("xuwdbdqik", "[[4,8,0],[4,4,0],[2,4,0],[2,4,0],[6,7,1],[2,2,1],[0,2,1],[8,8,0],[1,3,1]]", "ywxcxcqii")]
    public void ShiftingLetters_WithStringAndShiftArray_ReturnsShiftedString(string s, string shiftsJson,
        string expectedResult)
    {
        // Arrange
        var shifts = JsonHelper<int[][]>.Parse(shiftsJson);

        var solution = new T();

        // Act
        var actualResult = solution.ShiftingLetters(s, shifts);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}