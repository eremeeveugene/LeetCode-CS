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

using LeetCode.Algorithms.LargestNumber;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LargestNumber;

public abstract class LargestNumberTestsBase<T> where T : ILargestNumber, new()
{
    [TestMethod]
    [DataRow("[0,0,0]", "0")]
    [DataRow("[10,2]", "210")]
    [DataRow("[3,30,34,5,9]", "9534330")]
    [DataRow("[34323,3432]", "343234323")]
    [DataRow("[121,12]", "12121")]
    [DataRow("[121,12,120]", "12121120")]
    [DataRow("[1,11,111,1112]", "1112111111")]
    [DataRow("[999999,999999998,999999997]", "999999999999998999999997")]
    public void LargestNumber_WithArrayOfIntegers_ReturnsMaxConcatenatedNumber(string numsJsonArray,
        string expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.LargestNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}