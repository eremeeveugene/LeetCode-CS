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

using LeetCode.Algorithms.FindUniqueBinaryString;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindUniqueBinaryString;

public abstract class FindUniqueBinaryStringTestsBase<T> where T : IFindUniqueBinaryString, new()
{
    [TestMethod]
    [DataRow("[\"01\",\"10\"]", "10")]
    [DataRow("[\"00\",\"01\"]", "10")]
    [DataRow("[\"111\",\"011\",\"001\"]", "000")]
    public void FindDifferentBinaryString_WithUniqueBinaryStrings_ReturnsMissingBinaryString(string numsJsonArray,
        string expectedResult)
    {
        // Arrange
        var nums = JsonHelper<string>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindDifferentBinaryString(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}