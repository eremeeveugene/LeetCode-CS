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

using LeetCode.Algorithms.FindThePrefixCommonArrayOfTwoArrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindThePrefixCommonArrayOfTwoArrays;

public abstract class FindThePrefixCommonArrayOfTwoArraysTestsBase<T>
    where T : IFindThePrefixCommonArrayOfTwoArrays, new()
{
    [TestMethod]
    [DataRow("[2,3,1]", "[3,1,2]", "[0,1,3]")]
    [DataRow("[1,3,2,4]", "[3,1,2,4]", "[0,2,3,4]")]
    public void Test(string aJsonArray, string bJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var a = JsonHelper<int>.DeserializeToArray(aJsonArray);
        var b = JsonHelper<int>.DeserializeToArray(bJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindThePrefixCommonArray(a, b);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}