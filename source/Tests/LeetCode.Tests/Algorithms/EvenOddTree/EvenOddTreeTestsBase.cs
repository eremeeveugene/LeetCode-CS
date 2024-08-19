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
    [DataRow("[1,2,3,4,5,6,7]", false)]
    [DataRow("[1,10,4,3,null,7,9,12,8,6,null,null,3]", false)]
    [DataRow("[1,3,2,4,5,6,7,8,9,10,11,12,13,14,15]", false)]
    [DataRow("[1,10,4,3,2,7,9,12,8,6,null,null,2]", false)]
    [DataRow("[5,10,4,3,null,7,9,12,8,6,2,1]", false)]
    [DataRow("[5,10,4,3,null,7,9,12,8,6,2,0]", true)]
    [DataRow("[1,10,4,3,2,7,9,12,8,6,null,null,2]", false)]
    [DataRow("[1,3,2,6,4,6,4,12,8,6,null,null,2,1]", false)]
    public void IsEvenOddTree_GivenVariousTreeStructures_ReturnsExpectedBoolean(string rootJsonArray,
        bool expectedResult)
    {
        // Arrange
        var arrayRoot = JsonHelper<int?>.DeserializeToList(rootJsonArray);
        var root = TreeNode.BuildTree(arrayRoot);

        var solution = new T();

        // Act
        var actualResult = solution.IsEvenOddTree(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}