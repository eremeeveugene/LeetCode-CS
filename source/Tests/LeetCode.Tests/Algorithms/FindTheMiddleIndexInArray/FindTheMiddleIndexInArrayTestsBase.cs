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

using LeetCode.Algorithms.FindTheMiddleIndexInArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheMiddleIndexInArray;

public abstract class FindTheMiddleIndexInArrayTestsBase<T> where T : IFindTheMiddleIndexInArray, new()
{
    [TestMethod]
    [DataRow("[2, 3, -1, 8, 4]", 3)]
    [DataRow("[1, -1, 4]", 2)]
    [DataRow("[2, 5]", -1)]
    public void FindMiddleIndex_GivenArray_ReturnsExpectedMiddleIndexOrMinusOne(string numsJsonArray,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindMiddleIndex(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}