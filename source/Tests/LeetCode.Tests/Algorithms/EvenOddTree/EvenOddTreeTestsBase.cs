﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.EvenOddTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.EvenOddTree;

public abstract class EvenOddTreeTestsBase<T> where T : IEvenOddTree, new()
{
    [TestMethod]
    [DataRow("[]", false)]
    [DataRow("[1]", true)]
    [DataRow("[1,10,4,3,null,7,9,12,8,6,null,null,2]", true)]
    [DataRow("[5,4,2,3,3,7]", false)]
    [DataRow("[5,9,1,3,5,7]", false)]
    public void IsEvenOddTree_GivenVariousTreeStructures_ReturnsExpectedBoolean(string jsonArrayRoot,
        bool expectedResult)
    {
        // Arrange
        IList<int?> arrayRoot = JsonConvertHelper<int?>.JsonArrayToList(jsonArrayRoot);
        var root = TreeNode.BuildTree(arrayRoot);

        var solution = new T();

        // Act
        var actualResult = solution.IsEvenOddTree(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}