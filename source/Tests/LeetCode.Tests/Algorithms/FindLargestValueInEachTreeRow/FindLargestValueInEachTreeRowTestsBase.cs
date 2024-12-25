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

using LeetCode.Algorithms.FindLargestValueInEachTreeRow;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindLargestValueInEachTreeRow;

public abstract class FindLargestValueInEachTreeRowTestsBase<T> where T : IFindLargestValueInEachTreeRow, new()
{
    [TestMethod]
    [DataRow("[]", "[]")]
    [DataRow("[1,2,3]", "[1,3]")]
    [DataRow("[1,3,2,5,3,null,9]", "[1,3,9]")]
    public void LargestValues_WithTreeRoot_ReturnsListOfRowMaxima(string rootJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.DeserializeToArray(rootJsonArray);
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.LargestValues(root);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}