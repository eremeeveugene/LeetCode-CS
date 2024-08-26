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

using LeetCode.Algorithms.KthDistinctStringInAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.KthDistinctStringInAnArray;

public abstract class KthDistinctStringInAnArrayTestsBase<T> where T : IKthDistinctStringInAnArray, new()
{
    [TestMethod]
    [DataRow("[\"d\", \"b\", \"c\", \"b\", \"c\", \"a\"]", 2, "a")]
    [DataRow("[\"aaa\", \"aa\", \"a\"]", 1, "aaa")]
    [DataRow("[\"a\", \"b\", \"a\"]", 3, "")]
    public void KthDistinct_GivenArrayAndK_ReturnsKthDistinctStringOrEmpty(string arrJsonArray, int k,
        string expectedResult)
    {
        // Arrange
        var arr = JsonHelper<string>.DeserializeToArray(arrJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.KthDistinct(arr, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}