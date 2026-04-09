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

using LeetCode.Algorithms.ShortestSubarrayToBeRemovedToMakeArraySorted;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ShortestSubarrayToBeRemovedToMakeArraySorted;

public abstract class ShortestSubarrayToBeRemovedToMakeArraySortedTestsBase<T>
    where T : IShortestSubarrayToBeRemovedToMakeArraySorted, new()
{
    [TestMethod]
    [DataRow("[1,2,3,10,4,2,3,5]", 3)]
    [DataRow("[5,4,3,2,1]", 4)]
    [DataRow("[1,2,3]", 0)]
    public void FindLengthOfShortestSubarray_GivenArray_ReturnsLengthOfShortestToBeRemoved(string arrJson,
        int expectedResult)
    {
        // Arrange
        var arr = JsonHelper.Parse<int[]>(arrJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindLengthOfShortestSubarray(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}