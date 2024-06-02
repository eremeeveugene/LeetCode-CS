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

using LeetCode.Algorithms.AddOneRowToTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.AddOneRowToTree;

public abstract class AddOneRowToTreeTestsBase<T> where T : IAddOneRowToTree, new()
{
    [TestMethod]
    [DataRow("[]", 0, 0, "[]")]
    [DataRow("[4,2,6,3,1,5]", 1, 2, "[4,1,1,2,null,null,6,3,1,5]")]
    [DataRow("[4,2,null,3,1]", 1, 3, "[4,2,null,1,1,3,null,null,1]")]
    [DataRow("[1,2,3,4,null,null,4,null,null,8,null,null,9]", 100, 1,
        "[100,1,null,2,3,4,null,null,4,null,null,8,null,null,9]")]
    [DataRow("[1,2,3,4,null,null,4,null,null,8,null,null,9]", 100, 2,
        "[1,100,100,2,null,null,3,4,null,null,4,null,null,8,null,null,9]")]
    [DataRow("[1,2,3,4,null,null,4,null,null,8,null,null,9]", 100, 3,
        "[1,2,3,100,100,100,100,4,null,null,null,null,null,null,4,null,null,8,null,null,9]")]
    [DataRow("[1,2,3,4,null,null,4,null,null,8,null,null,9]", 100, 4,
        "[1,2,3,4,null,null,4,100,100,100,100,null,null,null,null,8,null,null,null,null,9]")]
    [DataRow("[1,2,3,4,null,null,4,null,null,8,null,null,9]", 100, 5,
        "[1,2,3,4,null,null,4,null,null,8,null,100,100,null,null,null,9]")]
    [DataRow("[1,2,3,4,null,null,4,null,null,8,null,null,9]", 100, 6,
        "[1,2,3,4,null,null,4,null,null,8,null,null,9,100,100]")]
    [DataRow("[5,3,null,4,null,8,null,9]", 100, 1, "[100,5,null,3,null,4,null,8,null,9]")]
    [DataRow("[5,3,null,4,null,8,null,9]", 100, 2, "[5,100,100,3,null,null,null,4,null,8,null,9]")]
    [DataRow("[5,3,null,4,null,8,null,9]", 100, 3, "[5,3,null,100,100,4,null,null,null,8,null,9]")]
    [DataRow("[5,3,null,4,null,8,null,9]", 100, 4, "[5,3,null,4,null,100,100,8,null,null,null,9]")]
    [DataRow("[5,3,null,4,null,8,null,9]", 100, 5, "[5,3,null,4,null,8,null,100,100,9]")]
    [DataRow("[5,3,null,4,null,8,null,9]", 100, 6, "[5,3,null,4,null,8,null,9,null,100,100]")]
    public void AddOneRow_AddsRowToBinaryTreeAtSpecifiedDepthAndValue_VerifiesTreeStructure(string rootJsonArray,
        int val, int depth, string expectedResultJsonArray)
    {
        // Arrange
        var rootArray = JsonConvertHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        var expectedResultArray = JsonConvertHelper<int?>.JsonArrayToList(expectedResultJsonArray);
        var expectedResult = TreeNode.BuildTree(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.AddOneRow(root, val, depth);

        // Assert
        TreeNodeAssertExtensions.AreEqual(expectedResult, actualResult);
    }
}