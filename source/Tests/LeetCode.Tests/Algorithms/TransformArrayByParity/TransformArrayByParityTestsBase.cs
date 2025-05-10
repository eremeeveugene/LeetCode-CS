// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.TransformArrayByParity;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TransformArrayByParity;

public abstract class TransformArrayByParityTestsBase<T> where T : ITransformArrayByParity, new()
{
    [TestMethod]
    [DataRow("[4,3,2,1]", "[0,0,1,1]")]
    [DataRow("[1,5,1,4,2]", "[0,0,1,1,1]")]
    public void TransformArray_WithGivenIntegerArray_ReturnsTransformedArray(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJson);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.TransformArray(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}