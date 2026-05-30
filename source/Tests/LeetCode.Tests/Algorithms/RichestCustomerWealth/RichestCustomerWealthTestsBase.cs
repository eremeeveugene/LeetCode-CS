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

using LeetCode.Algorithms.RichestCustomerWealth;

namespace LeetCode.Tests.Algorithms.RichestCustomerWealth;

public abstract class RichestCustomerWealthTestsBase<T> where T : IRichestCustomerWealth, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaximumWealth_WithJsonAccounts_ReturnsMaximumWealth(int[][] accounts, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumWealth(accounts);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } }, 6];

        yield return [new[] { new[] { 1, 5 }, new[] { 7, 3 }, new[] { 3, 5 } }, 10];

        yield return [new[] { new[] { 2, 8, 7 }, new[] { 7, 1, 3 }, new[] { 1, 9, 5 } }, 17];
    }
}