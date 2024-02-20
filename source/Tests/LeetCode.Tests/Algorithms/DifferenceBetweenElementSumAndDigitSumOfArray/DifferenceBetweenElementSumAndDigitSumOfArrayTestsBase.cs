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

namespace LeetCode.Tests.Algorithms.DifferenceBetweenElementSumAndDigitSumOfArray;

public abstract class DifferenceBetweenElementSumAndDigitSumOfArrayTestsBase<T>
    where T : IDifferenceBetweenElementSumAndDigitSumOfArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 15, 6, 3 }, 9)]
    [DataRow(new[] { 1, 2, 3, 4 }, 0)]
    public void DifferenceOfSum_GivenArray_ReturnsExpectedDifference(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DifferenceOfSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}