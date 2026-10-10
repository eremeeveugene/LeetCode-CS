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

using LeetCode.Algorithms.SmallestStringStartingFromLeaf;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SmallestStringStartingFromLeaf;

public abstract class SmallestStringStartingFromLeafTestsBase<T> where T : ISmallestStringStartingFromLeaf, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SmallestFromLeaf_WithDifferentTreeConfigurations_ReturnsSmallestLexicographicalStringFromLeaf(
        int?[] rootArray,
        string? expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.SmallestFromLeaf(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 0, 1, 2, 3, 4, 3, 4 }, "dba"];

        yield return [new int?[] { 25, 1, 3, 1, 3, 0, 2 }, "adz"];

        yield return [new int?[] { 2, 2, 1, null, 1, 0, null, 0 }, "abc"];
        yield return [new int?[] { 0 }, "a"];
        yield return [new int?[] { 25 }, "z"];
        yield return [new int?[] { 0, 0 }, "aa"];
        yield return [new int?[] { 1, 0, 2 }, "ab"];
        yield return [new int?[] { 3, 1 }, "bd"];
        yield return [new int?[] { 2, null, 1 }, "bc"];
        yield return [new int?[] { 0, 1, null, 2 }, "cba"];
        yield return [new int?[] { 25, 25, 25, 25 }, "zz"];
        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "fcb"];
        yield return [new int?[] { 0, 0, 0, 0, 0, 0, 0 }, "aaa"];
        yield return [new int?[] { 4, 2, null, 1, null, 0 }, "abce"];
        yield return [new int?[] { 23, 22, 20, 12, null, 8, 11, 7, 14, null, 12, null, null, 18, null, null, null, null, null, null, 6, 7, 7 }, "hgshmwx"];
        yield return [new int?[] { 1, 1, 1, 1, 0, null, null, null, null, 1, null, 1, 1, 1, 0, 1, null, null, 2, null, 0, 1, null, 0, 0, null, null, 1, 0, 1, null, null, null, null, null, null, null, null, 1 }, "aabbabb"];
        yield return [new int?[] { 5, 24, null, 11, null, 20, 3, null, null, 19, 16 }, "qdlyf"];
        yield return [new int?[] { 2, 1, 2, null, 0, 1, null, null, null, 2, null, 1 }, "abc"];
        yield return [new int?[] { 5, 14, 4, 5, 11, 17, null, 21, 4, null, null, null, null, 2, 7, 5, 18, null, null, 14, 14, 11, null, null, 24, null, null, null, null, null, null, 10, 10, 3, null, null, null, 19 }, "cvfof"];
        yield return [new int?[] { 0, 0, 1, 1, 2, 1, 2, null, null, 0, null, 0, 2, null, 0, null, null, null, null, 1, 0, null, 0, 1, null, null, 1, null, null, null, 1, 0 }, "aacba"];
    }
}