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

using LeetCode.Algorithms.DeleteColumnsToMakeSorted;

namespace LeetCode.Tests.Algorithms.DeleteColumnsToMakeSorted;

public abstract class DeleteColumnsToMakeSortedTestsBase<T> where T : IDeleteColumnsToMakeSorted, new()
{
    [TestMethod]
    [DataRow(new[] { "a", "b" }, 0)]
    [DataRow(new[] { "cba", "daf", "ghi" }, 1)]
    [DataRow(new[] { "zyx", "wvu", "tsr" }, 3)]
    [DataRow(new[] { "a" }, 0)]
    [DataRow(new[] { "abc" }, 0)]
    [DataRow(new[] { "zzz", "zzz" }, 0)]
    [DataRow(new[] { "ab", "ba" }, 1)]
    [DataRow(new[] { "abc", "abc", "abc" }, 0)]
    [DataRow(new[] { "a", "b", "c", "d" }, 0)]
    [DataRow(new[] { "d", "c", "b", "a" }, 1)]
    [DataRow(new[] { "az", "by", "cx" }, 1)]
    [DataRow(new[] { "aaa", "aab", "aac" }, 0)]
    [DataRow(new[] { "b", "a" }, 1)]
    [DataRow(new[] { "cadbab", "acdbda", "babdcb", "dbabdb" }, 6)]
    [DataRow(new[] { "a", "b", "b" }, 0)]
    [DataRow(new[] { "cc", "bb", "bb" }, 2)]
    [DataRow(new[] { "acd", "bbc", "acc", "aca", "ccc" }, 3)]
    [DataRow(new[] { "cbddba", "cacdad", "cdadab", "babdcc", "cdacca" }, 6)]
    [DataRow(new[] { "b", "c", "c", "b", "c" }, 1)]
    [DataRow(new[] { "acccba", "bcdbaa", "dabccd", "dbaadc" }, 5)]
    [DataRow(new[] { "bd", "ab", "dc" }, 2)]
    [DataRow(new[] { "d", "c", "b" }, 1)]
    [DataRow(new[] { "bddcd", "ccddb", "adbdc", "badcc", "acacc" }, 5)]
    public void MinDeletionSize_WithStringArrayInput_ReturnsNumberOfColumnsToDelete(string[] strs, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinDeletionSize(strs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}