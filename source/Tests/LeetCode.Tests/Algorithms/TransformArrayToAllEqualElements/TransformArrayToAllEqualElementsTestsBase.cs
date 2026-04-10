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

using LeetCode.Algorithms.TransformArrayToAllEqualElements;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TransformArrayToAllEqualElements;

public abstract class TransformArrayToAllEqualElementsTestsBase<T> where T : ITransformArrayToAllEqualElements, new()
{
    [TestMethod]
    [DataRow("[1,-1,1,-1,1]", 3, true)]
    [DataRow("[-1,-1,-1,1,1,1]", 5, false)]
    [DataRow("[1,-1,1]", 2, true)]
    public void CanMakeEqual_WithNumsArray_ReturnsTrueIfAllElementsCanBeMadeEqual(string numsJson, int k,
        bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CanMakeEqual(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}