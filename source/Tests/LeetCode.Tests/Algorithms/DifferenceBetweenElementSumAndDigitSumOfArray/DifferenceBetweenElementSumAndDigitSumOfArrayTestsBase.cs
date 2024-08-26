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

using LeetCode.Algorithms.DifferenceBetweenElementSumAndDigitSumOfArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DifferenceBetweenElementSumAndDigitSumOfArray;

public abstract class DifferenceBetweenElementSumAndDigitSumOfArrayTestsBase<T>
    where T : IDifferenceBetweenElementSumAndDigitSumOfArray, new()
{
    [TestMethod]
    [DataRow("[1, 15, 6, 3]", 9)]
    [DataRow("[1, 2, 3, 4]", 0)]
    public void DifferenceOfSum_GivenArray_ReturnsExpectedDifference(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.DifferenceOfSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}