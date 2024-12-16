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

using LeetCode.Algorithms.FinalArrayStateAfterKMultiplicationOperations;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FinalArrayStateAfterKMultiplicationOperations;

public abstract class FinalArrayStateAfterKMultiplicationOperationsTestsBase<T>
    where T : IFinalArrayStateAfterKMultiplicationOperations, new()
{
    [TestMethod]
    [DataRow("[2,1,3,5,6]", 5, 2, "[8,4,6,5,6]")]
    [DataRow("[1,2]", 3, 4, "[16,8]")]
    public void GetFinalState_WithArrayKAndMultiplier_ReturnsTransformedArray(string numsJsonArray, int k,
        int multiplier, string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.GetFinalState(nums, k, multiplier);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}