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

using LeetCode.Algorithms.TheNumberOfBeautifulSubsets;

namespace LeetCode.Tests.Algorithms.TheNumberOfBeautifulSubsets;

public abstract class TheNumberOfBeautifulSubsetsTestsBase<T> where T : ITheNumberOfBeautifulSubsets, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1, 3 }, 3, 3)]
    [DataRow(new[] { 2, 4, 6 }, 2, 4)]
    [DataRow(new[] { 1000, 1 }, 999, 2)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12, 14, 15, 16, 17, 18, 100, 103, 106 }, 3, 4799)]
    [DataRow(new[] { 1000, 999, 998, 997, 996, 995, 994, 993, 992, 991 }, 1, 143)]
    [DataRow(
        new[] { 1000, 999, 998, 997, 996, 995, 994, 993, 992, 991, 1000, 999, 998, 997, 996, 995, 994, 993, 992, 991 },
        2, 9408)]
    [DataRow(
        new[] { 1000, 999, 998, 997, 996, 995, 994, 993, 992, 991, 990, 989, 988, 987, 986, 985, 984, 983, 982, 981 },
        2, 20735)]
    public void BeautifulSubsets_WithNumsAndK_ReturnsExpectedResult(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.BeautifulSubsets(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}