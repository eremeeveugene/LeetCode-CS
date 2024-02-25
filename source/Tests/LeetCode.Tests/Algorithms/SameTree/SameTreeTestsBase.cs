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

using LeetCode.Algorithms.SameTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SameTree;

public abstract class SameTreeTestsBase<T> where T : ISameTree, new()
{
    [TestMethod]
    [DataRow("[1,2,3]", "[1,2,3]", true)]
    [DataRow("[1,2]", "[1,null,2]", false)]
    [DataRow("[1,2,1]", "[1,1,2]", false)]
    public void IsSameTree_GivenTwoBinaryTreesFromJsonArrays_ReturnsExpectedBoolean(string jsonArrayP,
        string jsonArrayQ, bool expectedResult)
    {
        // Arrange
        IList<int?> pArray = JsonConvertHelper<int?>.JsonArrayToList(jsonArrayP);
        var p = TreeNode.BuildTree(pArray);

        IList<int?> qArray = JsonConvertHelper<int?>.JsonArrayToList(jsonArrayQ);
        var q = TreeNode.BuildTree(qArray);

        var solution = new T();

        // Act
        var actualResult = solution.IsSameTree(p, q);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}