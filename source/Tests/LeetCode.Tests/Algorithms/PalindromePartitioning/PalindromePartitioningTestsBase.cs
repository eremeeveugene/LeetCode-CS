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

using LeetCode.Algorithms.PalindromePartitioning;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.PalindromePartitioning;

public abstract class PalindromePartitioningTestsBase<T> where T : IPalindromePartitioning, new()
{
    [TestMethod]
    [DataRow("a", "[[\"a\"]]")]
    [DataRow("aab", "[[\"a\",\"a\",\"b\"],[\"aa\",\"b\"]]")]
    public void Partition_GivenString_ReturnsAllPossiblePalindromicPartitions(string s, string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonHelper<string>.JsonArrayToJaggedList(expectedResultJsonArray);

        // Act
        var actualResult = solution.Partition(s);

        // Assert
        AssertExtensions.AssertJaggedArrayEqual(expectedResult, actualResult);
    }
}