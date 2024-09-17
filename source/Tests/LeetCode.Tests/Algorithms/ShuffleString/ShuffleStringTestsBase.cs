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

using LeetCode.Algorithms.ShuffleString;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ShuffleString;

public abstract class ShuffleStringTestsBase<T> where T : IShuffleString, new()
{
    [TestMethod]
    [DataRow("codeleet", "[4,5,6,7,0,2,1,3]", "leetcode")]
    [DataRow("abc", "[0,1,2]", "abc")]
    public void RestoreString_WhenGivenStringAndIndicesArray_RearrangesToExpectedString(string s,
        string indicesJsonArray, string expectedResult)
    {
        // Arrange
        var indices = JsonHelper<int>.DeserializeToArray(indicesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RestoreString(s, indices);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}