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

using LeetCode.Algorithms.AddingSpacesToString;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.AddingSpacesToString;

public abstract class AddingSpacesToStringTestsBase<T> where T : IAddingSpacesToString, new()
{
    [TestMethod]
    [DataRow("LeetcodeHelpsMeLearn", "[8,13,15]", "Leetcode Helps Me Learn")]
    [DataRow("icodeinpython", "[1,5,7,9]", "i code in py thon")]
    [DataRow("spacing", "[0,1,2,3,4,5,6]", " s p a c i n g")]
    public void AddSpaces_WithInputStringAndSpaceIndices_ReturnsStringWithInsertedSpaces(string s, string spacesJson,
        string expectedResult)
    {
        // Arrange
        var spaces = JsonHelper<int[]>.Parse(spacesJson);

        var solution = new T();

        // Act
        var actualResult = solution.AddSpaces(s, spaces);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}