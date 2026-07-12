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
}