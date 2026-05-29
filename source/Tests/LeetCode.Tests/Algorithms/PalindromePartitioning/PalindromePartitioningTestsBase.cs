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

using LeetCode.Algorithms.PalindromePartitioning;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.PalindromePartitioning;

public abstract class PalindromePartitioningTestsBase<T> where T : IPalindromePartitioning, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Partition_GivenString_ReturnsAllPossiblePalindromicPartitions(string s, IList<IList<string>> expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Partition(s);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return ["a", new IList<string>[] { new[] { "a" } }];

        yield return ["aab", new IList<string>[] { new[] { "a", "a", "b" }, new[] { "aa", "b" } }];
    }
}
