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

using LeetCode.Algorithms.MissingNumber;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MissingNumber;

public abstract class MissingNumberTestsBase<T> where T : IMissingNumber, new()
{
    [TestMethod]
    [DataRow("[]", 0)]
    [DataRow("[3,0,1]", 2)]
    [DataRow("[0,1]", 2)]
    [DataRow("[9,6,4,2,3,5,7,0,1]", 8)]
    public void MissingNumber_WithIntArray_ReturnsMissingNumber(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MissingNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}