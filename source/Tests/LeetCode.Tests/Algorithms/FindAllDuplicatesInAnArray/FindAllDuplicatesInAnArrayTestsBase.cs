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

using LeetCode.Algorithms.FindAllDuplicatesInAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindAllDuplicatesInAnArray;

public abstract class FindAllDuplicatesInAnArrayTestsBase<T> where T : IFindAllDuplicatesInAnArray, new()
{
    [TestMethod]
    [DataRow("[4, 3, 2, 7, 8, 2, 3, 1]", "[2, 3]")]
    [DataRow("[1, 1, 2]", "[1]")]
    [DataRow("[1]", "[]")]
    public void FindDuplicates_WithInputArray_ReturnsExpectedDuplicates(string numsJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindDuplicates(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}