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

using LeetCode.Algorithms.BuildArrayFromPermutation;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BuildArrayFromPermutation;

public abstract class BuildArrayFromPermutationTestsBase<T> where T : IBuildArrayFromPermutation, new()
{
    [TestMethod]
    [DataRow("[0, 2, 1, 5, 3, 4]", "[0, 1, 2, 4, 5, 3]")]
    [DataRow("[5, 0, 1, 2, 3, 4]", "[4, 5, 0, 1, 2, 3]")]
    public void BuildArray_WithInputPermutation_ReturnsExpectedPermutationArray(string numsJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.BuildArray(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}