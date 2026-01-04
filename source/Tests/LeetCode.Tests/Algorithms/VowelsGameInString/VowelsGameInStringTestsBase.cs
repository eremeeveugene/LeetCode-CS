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

using LeetCode.Algorithms.VowelsGameInString;

namespace LeetCode.Tests.Algorithms.VowelsGameInString;

public abstract class VowelsGameInStringTestsBase<T> where T : IVowelsGameInString, new()
{
    [TestMethod]
    [DataRow("leetcoder", true)]
    [DataRow("bbcd", false)]
    public void DoesAliceWin_WithGivenString_ReturnsTrueIfAliceCanForceWin(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DoesAliceWin(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}