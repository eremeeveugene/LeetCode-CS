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

using LeetCode.Algorithms.RemoveDuplicatesFromSortedArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RemoveDuplicatesFromSortedArray;

public abstract class RemoveDuplicatesFromSortedArrayTestsBase<T> where T : IRemoveDuplicatesFromSortedArray, new()
{
    [TestMethod]
    [DataRow("[1,1,2]", 2, "[1,2]")]
    [DataRow("[0,0,1,1,1,2,2,3,3,4]", 5, "[0,1,2,3,4]")]
    public void RemoveDuplicates_GivenSortedArray_ReturnsCountOfUniqueElements(string numsJsonArray, int expectedResult,
        string expectedNumsJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedNums = JsonHelper<int>.DeserializeToArray(expectedNumsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveDuplicates(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        CollectionAssert.AreEquivalent(expectedNums, nums.Take(actualResult).ToArray());
    }
}