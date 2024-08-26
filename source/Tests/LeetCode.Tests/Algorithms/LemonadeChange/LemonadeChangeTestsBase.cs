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

using LeetCode.Algorithms.LemonadeChange;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LemonadeChange;

public abstract class LemonadeChangeTestsBase<T> where T : ILemonadeChange, new()
{
    [TestMethod]
    [DataRow("[10]", false)]
    [DataRow("[5, 5, 5, 10, 20]", true)]
    [DataRow("[5, 5, 10, 10, 20]", false)]
    [DataRow("[5, 5, 10, 5, 5, 10, 20, 5, 10, 20, 20, 10, 5, 10, 20, 20, 5, 5, 10, 20, 10]", false)]
    [DataRow(
        "[5, 5, 10, 5, 5, 10, 20, 5, 10, 20, 20, 10, 5, 10, 20, 20, 5, 5, 10, 20, 10, 5, 10, 5, 5, 10, 20, 5, 10, 20, 20, 10, 5, 10, 20, 20, 5, 5, 10, 20, 10, 5, 10, 5, 10, 5, 10, 5, 20, 20, 20, 10, 10, 5]",
        false)]
    public void LemonadeChange_WithGivenBills_ReturnsIfChangeCanBeProvided(string billsJsonArray, bool expectedResult)
    {
        // Arrange
        var bills = JsonHelper<int>.DeserializeToArray(billsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.LemonadeChange(bills);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}