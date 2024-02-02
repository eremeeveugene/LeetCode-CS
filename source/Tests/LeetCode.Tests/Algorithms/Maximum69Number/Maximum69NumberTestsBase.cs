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

using LeetCode.Algorithms.Maximum69Number;

namespace LeetCode.Tests.Algorithms.Maximum69Number;

public abstract class Maximum69NumberTestsBase<T> where T : IMaximum69Number, new()
{
    [TestMethod]
    [DataRow(6, 9)]
    [DataRow(9, 9)]
    [DataRow(66, 96)]
    [DataRow(69, 99)]
    [DataRow(96, 99)]
    [DataRow(99, 99)]
    [DataRow(666, 966)]
    [DataRow(966, 996)]
    [DataRow(996, 999)]
    [DataRow(699, 999)]
    [DataRow(999, 999)]
    [DataRow(6666, 9666)]
    [DataRow(6966, 9966)]
    [DataRow(6996, 9996)]
    [DataRow(6999, 9999)]
    [DataRow(9666, 9966)]
    [DataRow(9669, 9969)]
    [DataRow(9966, 9996)]
    [DataRow(9996, 9999)]
    [DataRow(9999, 9999)]
    public void Maximum69Number_WithVariousNumInputs_ReturnsMaximizedValue(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Maximum69Number(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}