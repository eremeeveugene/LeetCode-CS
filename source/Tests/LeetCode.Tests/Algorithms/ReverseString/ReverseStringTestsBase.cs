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

using LeetCode.Algorithms.ReverseString;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ReverseString;

public abstract class ReverseStringTestsBase<T> where T : IReverseString, new()
{
    [TestMethod]
    [DataRow("[\"h\",\"e\",\"l\",\"l\",\"o\"]", "[\"o\",\"l\",\"l\",\"e\",\"h\"]")]
    [DataRow("[\"H\",\"a\",\"n\",\"n\",\"a\",\"h\"]", "[\"h\",\"a\",\"n\",\"n\",\"a\",\"H\"]")]
    public void ReverseString_WithCharArray_ReversesArrayInPlace(string sJson, string expectedResultJson)
    {
        // Arrange
        var s = JsonHelper.Parse<char[]>(sJson);
        var expectedResult = JsonHelper.Parse<char[]>(expectedResultJson);

        var solution = new T();

        // Act
        solution.ReverseString(s);

        // Assert
        CollectionAssert.AreEqual(expectedResult, s);
    }
}