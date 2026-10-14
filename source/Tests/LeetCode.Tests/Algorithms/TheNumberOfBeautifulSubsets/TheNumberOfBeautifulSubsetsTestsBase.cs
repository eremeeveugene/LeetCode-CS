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
    [DataRow(new[] { 1000, 999, 998, 997, 996, 995, 994, 993, 992, 991, 1000, 999, 998, 997, 996, 995, 994, 993, 992, 991 }, 2, 9408)]
    [DataRow(new[] { 1000, 999, 998, 997, 996, 995, 994, 993, 992, 991, 990, 989, 988, 987, 986, 985, 984, 983, 982, 981 }, 2, 20735)]
    [DataRow(new[] { 1, 1 }, 1, 3)]
    [DataRow(new[] { 1, 2 }, 1, 2)]
    [DataRow(new[] { 1, 2, 3 }, 1, 4)]
    [DataRow(new[] { 5, 5, 5 }, 3, 7)]
    [DataRow(new[] { 1, 4, 7, 10 }, 3, 7)]
    [DataRow(new[] { 1000, 1000 }, 1000, 3)]
    [DataRow(new[] { 1, 1000 }, 999, 2)]
    [DataRow(new[] { 2, 2, 2, 2 }, 2, 15)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1, 54)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60 }, 10, 20)]
    [DataRow(new[] { 1, 3, 5, 7, 9, 11, 13, 15 }, 2, 54)]
    [DataRow(new[] { 4, 2, 5, 9, 10, 3 }, 1, 23)]
    [DataRow(new[] { 9, 11, 7, 8, 7, 4, 10, 16, 18, 20, 8, 5, 18, 17, 1, 9, 1, 16 }, 2, 14079)]
    [DataRow(new[] { 7, 17, 13, 6, 11, 11, 4, 3, 18, 9, 18, 16, 7, 8, 7, 3, 3, 7 }, 5, 29567)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }, 1, 6764)]
    [DataRow(new[] { 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 }, 1000, 262143)]
    [DataRow(new[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52 }, 3, 6764)]
    public void BeautifulSubsets_WithIntegerArrayAndDifferenceConstraint_ReturnsCountOfValidNonEmptySubsets(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.BeautifulSubsets(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}