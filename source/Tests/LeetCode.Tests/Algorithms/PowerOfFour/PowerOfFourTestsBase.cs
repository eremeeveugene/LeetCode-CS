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

using LeetCode.Algorithms.PowerOfFour;

namespace LeetCode.Tests.Algorithms.PowerOfFour;

public abstract class PowerOfFourTestsBase<T> where T : IPowerOfFour, new()
{
    [TestMethod]
    [DataRow(-1, false)]
    [DataRow(0, false)]
    [DataRow(1, true)]
    [DataRow(3, false)]
    [DataRow(4, true)]
    [DataRow(5, false)]
    [DataRow(8, false)]
    [DataRow(16, true)]
    [DataRow(32, false)]
    [DataRow(64, true)]
    public void IsPowerOfFour_GivenNumber_ReturnsExpectedBoolean(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPowerOfFour(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}