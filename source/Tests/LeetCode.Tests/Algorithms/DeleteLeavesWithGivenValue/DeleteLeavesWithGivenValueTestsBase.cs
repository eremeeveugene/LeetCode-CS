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

using LeetCode.Algorithms.DeleteLeavesWithGivenValue;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteLeavesWithGivenValue;

public abstract class DeleteLeavesWithGivenValueTestsBase<T> where T : IDeleteLeavesWithGivenValue, new()
{
    [TestMethod]
    [DataRow("[1]", 1, "[]")]
    [DataRow("[1,2,3,2,null,2,4]", 2, "[1,null,3,null,4]")]
    [DataRow("[1,3,3,3,2]", 3, "[1,3,null,null,2]")]
    [DataRow("[1,2,null,2,null,2]", 2, "[1]")]
    [DataRow("[1,2,2,3,null,null,3,4,null,null,4,5,null,null,5,5,null,null,5,5,null,null,5,5,null,null,5]", 5,
        "[1,2,2,3,null,null,3,4,null,null,4]")]
    public void RemoveLeafNodes_GivenTarget_RemovesAllLeafNodesWithTargetValue(string rootJsonArray, int target,
        string expectedResultJsonArray)
    {
        // Arrange
        IList<int?> rootArray = JsonConvertHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        IList<int?> expectedResultArray = JsonConvertHelper<int?>.JsonArrayToList(expectedResultJsonArray);
        var expectedResult = TreeNode.BuildTree(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveLeafNodes(root, target);

        // Assert
        TreeNodeAssertExtensions.AreEqual(expectedResult, actualResult);
    }
}