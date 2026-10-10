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

using LeetCode.Algorithms.MaximumProductOfSplittedBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MaximumProductOfSplittedBinaryTree;

public abstract class MaximumProductOfSplittedBinaryTreeTestsBase<T> where T : IMaximumProductOfSplittedBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxProduct_WithBinaryTree_ReturnsMaximumProductOfSubtreeSums(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxProduct(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, 2, 3, 4, 5, 6 }, 110];

        yield return [new int?[] { 1, null, 2, 3, 4, null, null, 5, 6 }, 90];
        yield return [new int?[] { 1, 2 }, 2];
        yield return [new int?[] { 1, null, 2 }, 2];
        yield return [new int?[] { 5, 5, 5 }, 50];
        yield return [new int?[] { 10000, 10000 }, 100000000];
        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 192];
        yield return [new int?[] { 3, 1, null, 4, null, null, 2 }, 24];
        yield return [new int?[] { 2, 3, 9, 10, 7, 8, 6, 5, 4, 11, 1 }, 1025];
        yield return [new int?[] { 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000 }, 599999965];
        yield return [new int?[] { 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000 }, 999999839];
        yield return [new int?[] { 1, 10000, null, 10000, null, 10000, null, 10000, null, 10000 }, 600030000];
        yield return [new int?[] { 5924, null, 7688, 7873 }, 107167276];
        yield return [new int?[] { 3645, 166, 4949, 4860 }, 43193444];
        yield return [new int?[] { 334, null, 2523, 449, 9930, null, null, null, 7615 }, 100792140];
        yield return [new int?[] { 6933, 8467, null, 2823, 9219, null, 4801, 9483, 4634, null, null, 722 }, 553911392];
        yield return [new int?[] { 230, 7784, 2015, 2359, 8180, 6656, 7443, null, null, null, null, null, null, 1281, null, 373, null, 3806 }, 400262422];
        yield return [new int?[] { 3915, 1903, 8609, 633, null, 4005, 1705, null, null, 6363, 2413, null, null, null, 6669, 4385, 7610, null, null, 6636 }, 711329288];
        yield return [new int?[] { 2854, 3420, 6685, 8756, 6990, 360, 7999, 9659, null, 9380, 8233, 4833, null, 4992, 8176, null, null, 4997, 1249, null, null, 2028, null, null, 7242, null, null, 7737, null, 3958, null, null, null, null, null, null, null, 3427 }, 80240863];
        yield return [new int?[] { 6718, 6280, 4244, null, 6737, 2012, 3171, null, null, null, 9752, 713, null, 5795, 7228, 8464, 349, 2404, 7095, 6132, null, null, null, null, null, null, null, 1313, 278, 5633, null, null, 6286, 9060, 3469, 3155, 3484, null, 6832, null, null, null, null, null, 897, null, 9725, null, null, 6650, null, 6757, 5597, null, null, null, null, 5716 }, 546926693];
    }
}