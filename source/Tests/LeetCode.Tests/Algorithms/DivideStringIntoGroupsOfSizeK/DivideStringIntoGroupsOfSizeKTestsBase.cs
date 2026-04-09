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

using LeetCode.Algorithms.DivideStringIntoGroupsOfSizeK;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DivideStringIntoGroupsOfSizeK;

public abstract class DivideStringIntoGroupsOfSizeKTestsBase<T>
    where T : IDivideStringIntoGroupsOfSizeK, new()
{
    [TestMethod]
    [DataRow("abcdefghi", 3, 'x', "[\"abc\",\"def\",\"ghi\"]")]
    [DataRow("abcdefghij", 3, 'x', "[\"abc\",\"def\",\"ghi\",\"jxx\"]")]
    public void DivideString_WithLengthMultipleOfK_ReturnsGroupsWithoutPadding(string s, int k, char fill,
        string expectedResultJson)
    {
        // Arrange
        var expectedResult = JsonHelper.Parse<string[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.DivideString(s, k, fill);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}