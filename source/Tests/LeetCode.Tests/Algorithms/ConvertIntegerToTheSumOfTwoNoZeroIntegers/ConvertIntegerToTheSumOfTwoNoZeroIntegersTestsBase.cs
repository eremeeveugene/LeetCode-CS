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

using LeetCode.Algorithms.ConvertIntegerToTheSumOfTwoNoZeroIntegers;

namespace LeetCode.Tests.Algorithms.ConvertIntegerToTheSumOfTwoNoZeroIntegers;

public abstract class ConvertIntegerToTheSumOfTwoNoZeroIntegersTestsBase<T>
    where T : IConvertIntegerToTheSumOfTwoNoZeroIntegers, new()
{
    [TestMethod]
    [DataRow(2, new[] { 1, 1 })]
    [DataRow(11, new[] { 2, 9 })]
    [DataRow(69, new[] { 1, 68 })]
    [DataRow(699, new[] { 1, 698 })]
    [DataRow(700, new[] { 1, 699 })]
    [DataRow(701, new[] { 2, 699 })]
    [DataRow(1010, new[] { 11, 999 })]
    public void GetNoZeroIntegers_WithPositiveIntegerN_ReturnsTwoNoZeroIntegersThatSumToN(int n,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetNoZeroIntegers(n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}