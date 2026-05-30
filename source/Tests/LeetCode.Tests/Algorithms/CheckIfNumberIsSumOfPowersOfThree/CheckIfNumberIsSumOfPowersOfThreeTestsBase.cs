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

using LeetCode.Algorithms.CheckIfNumberIsSumOfPowersOfThree;

namespace LeetCode.Tests.Algorithms.CheckIfNumberIsSumOfPowersOfThree;

public abstract class CheckIfNumberIsSumOfPowersOfThreeTestsBase<T> where T : ICheckIfNumberIsSumOfPowersOfThree, new()
{
    [TestMethod]
    [DataRow(12, true)]
    [DataRow(21, false)]
    [DataRow(91, true)]
    public void CheckPowersOfThree_WithGivenNumber_ReturnsWhetherItCanBeExpressedAsPowersOfThree(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckPowersOfThree(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}