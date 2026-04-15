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

using LeetCode.Algorithms.CheckIfBinaryStringHasAtMostOneSegmentOfOnes;

namespace LeetCode.Tests.Algorithms.CheckIfBinaryStringHasAtMostOneSegmentOfOnes;

public abstract class CheckIfBinaryStringHasAtMostOneSegmentOfOnesTestsBase<T>
    where T : ICheckIfBinaryStringHasAtMostOneSegmentOfOnes, new()
{
    [TestMethod]
    [DataRow("1", true)]
    [DataRow("0", true)]
    [DataRow("11", true)]
    [DataRow("10", true)]
    [DataRow("01", true)]
    [DataRow("111111", true)]
    [DataRow("000000", true)]
    [DataRow("111000", true)]
    [DataRow("000111", true)]
    [DataRow("101", false)]
    [DataRow("1001", false)]
    [DataRow("110", true)]
    [DataRow("110011", false)]
    [DataRow("10001", false)]
    [DataRow("10111", false)]
    [DataRow("1110111", false)]
    public void CheckOnesSegment_WithBinaryString_ReturnsTrueIfAtMostOneContiguousSegmentOfOnes(
        string s,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckOnesSegment(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}