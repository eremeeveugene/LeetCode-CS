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

using LeetCode.Algorithms.PowerOfThree;

namespace LeetCode.Tests.Algorithms.PowerOfThree;

public abstract class PowerOfThreeTestsBase<T> where T : IPowerOfThree, new()
{
    [TestMethod]
    [DataRow(-1, false)]
    [DataRow(0, false)]
    [DataRow(1, true)]
    [DataRow(3, true)]
    [DataRow(5, false)]
    [DataRow(7, false)]
    [DataRow(9, true)]
    [DataRow(11, false)]
    [DataRow(13, false)]
    [DataRow(15, false)]
    [DataRow(27, true)]
    [DataRow(81, true)]
    [DataRow(243, true)]
    public void IsPowerOfThree_GivenInteger_ReturnsWhetherIntegerIsPowerOfThree(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPowerOfThree(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}