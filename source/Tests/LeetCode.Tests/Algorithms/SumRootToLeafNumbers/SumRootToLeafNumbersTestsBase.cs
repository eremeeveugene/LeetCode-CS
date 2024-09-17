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

using LeetCode.Algorithms.SumRootToLeafNumbers;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SumRootToLeafNumbers;

public abstract class SumRootToLeafNumbersTestsBase<T> where T : ISumRootToLeafNumbers, new()
{
    [TestMethod]
    [DataRow("[1]", 1)]
    [DataRow("[1,2]", 12)]
    [DataRow("[1,2,3]", 25)]
    [DataRow("[4,9,0,5,1]", 1026)]
    public void SumNumbers_GivenTreeConstructedFromJsonRootArray_ReturnsExpectedSum(string jsonRootArray,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        var rootArray = JsonHelper<int?>.DeserializeToList(jsonRootArray);
        var root = TreeNode.BuildTree(rootArray);

        // Act
        var actualResult = solution.SumNumbers(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}