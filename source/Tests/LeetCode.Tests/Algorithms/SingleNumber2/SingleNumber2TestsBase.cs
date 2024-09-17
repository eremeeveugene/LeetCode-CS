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

using LeetCode.Algorithms.SingleNumber2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SingleNumber2;

public abstract class SingleNumber2TestsBase<T> where T : ISingleNumber2, new()
{
    [TestMethod]
    [DataRow("[2,2,3,2]", 3)]
    [DataRow("[0,1,0,1,0,1,99]", 99)]
    public void SingleNumber_WithIntegerArray_ReturnsUniqueNumber(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SingleNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}