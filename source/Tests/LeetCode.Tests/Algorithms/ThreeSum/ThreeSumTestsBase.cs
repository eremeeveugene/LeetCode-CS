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

using LeetCode.Algorithms.ThreeSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ThreeSum;

public abstract class ThreeSumTestsBase<T> where T : IThreeSum, new()
{
    [TestMethod]
    [DataRow("[-1, 0, 1, 2, -1, -4]", "[[-1, -1, 2], [-1, 0, 1]]")]
    [DataRow("[ 0, 1, 1]", "[]")]
    [DataRow("[0, 0, 0]", "[[0, 0, 0]]")]
    [DataRow("[-3, -2, 1, 1, 2]", "[[-3, 1, 2], [-2, 1, 1]]")]
    [DataRow("[3, 0, -2, -1, 1, 2]", "[[-2, -1, 3],[-2, 0, 2],[-1, 0, 1]]")]
    public void ThreeSum_WithIntArray_ReturnsTripletsThatSumToZero(string numsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToJaggedArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ThreeSum(nums);

        Assert.AreEqual(expectedResult.Length, actualResult.Count);
    }
}