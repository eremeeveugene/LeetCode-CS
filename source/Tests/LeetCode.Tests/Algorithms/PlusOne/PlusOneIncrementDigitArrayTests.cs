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

using LeetCode.Algorithms.PlusOne;

namespace LeetCode.Tests.Algorithms.PlusOne;

[TestClass]
public class PlusOneIncrementDigitArrayTests
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [DataRow(new[] { 9 }, new[] { 1, 0 })]
    [DataRow(new[] { 9, 9 }, new[] { 1, 0, 0 })]
    [DataRow(new[] { 8, 9, 9, 9 }, new[] { 9, 0, 0, 0 })]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 })]
    [DataRow(
        new[]
        {
            7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7,
            4, 0, 0, 6
        },
        new[]
        {
            7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7,
            4, 0, 0, 7
        })]
    public void PlusOneIncrementArrayFormattedNumberWithCarryHandling_GetResult_ShouldIncrementAndMatchExpectedResult(
        int[] digits, int[] expectedResult)
    {
        // Act
        int[] actualResult = PlusOneIncrementDigitArray.GetResult(digits);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}