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

using LeetCode.Algorithms.SumOfLeftLeaves;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SumOfLeftLeaves;

public abstract class SumOfLeftLeavesTestsBase<T> where T : ISumOfLeftLeaves, new()
{
    [TestMethod]
    [DataRow("[1]", 0)]
    [DataRow("[3,9,20,null,null,15,7]", 24)]
    [DataRow("[0,2,4,1,null,3,-1,5,1,null,6,null,8]", 5)]
    [DataRow("[1,2,3,4,5]", 4)]
    [DataRow("[-9,-3,2,null,4,4,0,-6,null,-5]", -11)]
    public void SumOfLeftLeaves_GivenTreeRoot_ReturnsSumOfLeftLeafValues(string jsonArrayRoot, int expectedResult)
    {
        // Arrange
        IList<int?> arrayRoot = JsonConvertHelper<int?>.JsonArrayToList(jsonArrayRoot);
        var root = TreeNode.BuildTree(arrayRoot);

        var solution = new T();

        // Act
        var actualResult = solution.SumOfLeftLeaves(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}