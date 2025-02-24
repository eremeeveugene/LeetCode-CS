// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CheckIfDigitsAreEqualInStringAfterOperations1;

namespace LeetCode.Tests.Algorithms.CheckIfDigitsAreEqualInStringAfterOperations1;

public abstract class CheckIfDigitsAreEqualInStringAfterOperations1TestsBase<T>
    where T : ICheckIfDigitsAreEqualInStringAfterOperations1, new()
{
    [TestMethod]
    [DataRow("323", true)]
    [DataRow("3902", true)]
    [DataRow("34789", false)]
    public void HasSameDigits_WithStringInput_ReturnsWhetherAllDigitsAreTheSame(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HasSameDigits(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}