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

using LeetCode.Algorithms.DistributeMoneyToMaximumChildren;

namespace LeetCode.Tests.Algorithms.DistributeMoneyToMaximumChildren;

public abstract class DistributeMoneyToMaximumChildrenTestsBase<T> where T : IDistributeMoneyToMaximumChildren, new()
{
    [TestMethod]
    [DataRow(20, 3, 1)]
    [DataRow(16, 2, 2)]
    [DataRow(4, 2, 0)]
    [DataRow(12, 3, 1)]
    public void DistMoney_WithVariousMoneyAndChildrenValues_ReturnsExpectedResults(int money, int children,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DistMoney(money, children);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}