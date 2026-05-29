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

using LeetCode.Algorithms.PartitionLabels;

namespace LeetCode.Tests.Algorithms.PartitionLabels;

public abstract class PartitionLabelsTestsBase<T> where T : IPartitionLabels, new()
{
    [TestMethod]
    [DataRow("ababcbacadefegdehijhklij", new[] { 9, 7, 8 })]
    [DataRow("eccbbbbdec", new[] { 10 })]
    public void PartitionLabels_GivenString_ReturnsPartitionSizesWhereEachLetterAppearsOnce(string s,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PartitionLabels(s).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}
