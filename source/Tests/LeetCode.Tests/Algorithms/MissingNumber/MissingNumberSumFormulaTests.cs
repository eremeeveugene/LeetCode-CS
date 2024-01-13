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

using LeetCode.Algorithms.MissingNumber;

namespace LeetCode.Tests.Algorithms.MissingNumber;

[TestClass]
public class MissingNumberSumFormulaTests
{
    [TestMethod]
    [DataRow(new[] { 3, 0, 1 }, 2)]
    [DataRow(new[] { 0, 1 }, 2)]
    [DataRow(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    public void MissingNumberSumFormula_GetResult_WithNumberArray_ReturnsMissingNumber(int[] nums, int expectedResult)
    {
        // Act
        var actualResult = MissingNumberSumFormula.GetResult(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}