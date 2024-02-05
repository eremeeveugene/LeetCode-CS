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

using LeetCode.Algorithms.RichestCustomerWealth;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RichestCustomerWealth;

public abstract class RichestCustomerWealthTestsBase<T> where T : IRichestCustomerWealth, new()
{
    [TestMethod]
    [DataRow("[[1,2,3],[3,2,1]]", 6)]
    [DataRow("[[1,5],[7,3],[3,5]]", 10)]
    [DataRow("[[2,8,7],[7,1,3],[1,9,5]]", 17)]
    public void MaximumWealth_WithJsonAccounts_ReturnsMaximumWealth(string jsonAccounts, int expectedResult)
    {
        // Arrange
        var accounts = JsonConvertHelper<int>.JsonArrayToJaggedArray(jsonAccounts);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumWealth(accounts);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}