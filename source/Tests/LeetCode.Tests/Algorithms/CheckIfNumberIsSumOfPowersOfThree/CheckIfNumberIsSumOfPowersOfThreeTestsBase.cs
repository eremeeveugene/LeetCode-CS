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
    [DataRow(1, true)]
    [DataRow(3, true)]
    [DataRow(4, true)]
    [DataRow(9, true)]
    [DataRow(10, true)]
    [DataRow(13, true)]
    [DataRow(27, true)]
    [DataRow(40, true)]
    [DataRow(81, true)]
    [DataRow(243, true)]
    [DataRow(4782969, true)]
    [DataRow(2, false)]
    [DataRow(5, false)]
    [DataRow(6, false)]
    [DataRow(8, false)]
    [DataRow(14, false)]
    [DataRow(15, false)]
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