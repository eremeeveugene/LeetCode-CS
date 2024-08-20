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

using LeetCode.Algorithms.ConvertSortedArrayToBinarySearchTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ConvertSortedArrayToBinarySearchTree;

public abstract class ConvertSortedArrayToBinarySearchTreeTestsBase<T>
    where T : IConvertSortedArrayToBinarySearchTree, new()
{
    [TestMethod]
    [DataRow("[-10, -3, 0, 5, 9]", "[0,-10,5,null,-3,null,9]")]
    [DataRow("[1, 3]", "[1,null,3]")]
    public void SortedArrayToBST_WithArrayInput_ReturnsBalancedBST(string numsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var expectedResultArray = JsonHelper<int?>.DeserializeToList(expectedResultJsonArray);
        var expectedResult = TreeNode.BuildTree(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.SortedArrayToBST(nums);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}