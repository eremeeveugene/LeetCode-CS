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

using LeetCode.Algorithms.FaultyKeyboard;

namespace LeetCode.Tests.Algorithms.FaultyKeyboard;

public abstract class FaultyKeyboardTestsBase<T> where T : IFaultyKeyboard, new()
{
    [TestMethod]
    [DataRow("string", "rtsng")]
    [DataRow("poiinter", "ponter")]
    public void FinalString_WithGivenString_ReturnsTransformedString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FinalString(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}