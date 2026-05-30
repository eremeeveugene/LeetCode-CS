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

using LeetCode.Algorithms.FindingThreeDigitEvenNumbers;

namespace LeetCode.Tests.Algorithms.FindingThreeDigitEvenNumbers;

public abstract class FindingThreeDigitEvenNumbersTestsBase<T> where T : IFindingThreeDigitEvenNumbers, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 7, 5 }, new int[] { })]
    [DataRow(new[] { 2, 1, 3, 0 }, new[] { 102, 120, 130, 132, 210, 230, 302, 310, 312, 320 })]
    [DataRow(new[] { 2, 2, 8, 8, 2 }, new[] { 222, 228, 282, 288, 822, 828, 882 })]
    public void FindEvenNumbers_WithGivenDigits_ReturnsAllValidThreeDigitEvenNumbers(int[] digits, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindEvenNumbers(digits);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}