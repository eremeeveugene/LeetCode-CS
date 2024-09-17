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

using LeetCode.Algorithms.RunningSumOf1dArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RunningSumOf1dArray;

public abstract class RunningSumOf1dArrayTestsBase<T> where T : IRunningSumOf1dArray, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4]", "[1,3,6,10]")]
    [DataRow("[1,1,1,1,1]", "[1,2,3,4,5]")]
    [DataRow("[3,1,2,10,1]", "[3,4,6,16,17]")]
    public void RunningSum_GivenArrays_ReturnsCumulativeSumsPerElement(string numsJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RunningSum(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}