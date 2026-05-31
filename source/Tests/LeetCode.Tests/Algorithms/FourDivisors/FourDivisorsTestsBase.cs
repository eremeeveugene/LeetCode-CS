// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FourDivisors;

namespace LeetCode.Tests.Algorithms.FourDivisors;

public abstract class FourDivisorsTestsBase<T> where T : IFourDivisors, new()
{
    [TestMethod]
    [DataRow(new[] { 21, 4, 7 }, 32)]
    [DataRow(new[] { 21, 21 }, 64)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 6 }, 12)]
    [DataRow(new[] { 10 }, 18)]
    [DataRow(new[] { 15 }, 24)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 4 }, 0)]
    [DataRow(new[] { 12 }, 0)]
    [DataRow(new[] { 9 }, 0)]
    [DataRow(new[] { 10, 15 }, 42)]
    [DataRow(new[] { 14 }, 24)]
    [DataRow(new[] { 35 }, 48)]
    [DataRow(new[] { 22 }, 36)]
    [DataRow(new[] { 6, 10, 15, 21 }, 86)]
    [DataRow(new[] { 100 }, 0)]
    [DataRow(new[] { 2, 3, 5, 7 }, 0)]
    [DataRow(new[] { 33 }, 48)]
    public void SumFourDivisors_WithInputNumsArray_ReturnsSumOfNumbersThatHaveFourDivisors(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumFourDivisors(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}