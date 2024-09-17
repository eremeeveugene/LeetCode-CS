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

using LeetCode.Algorithms.ContainsDuplicate;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ContainsDuplicate;

public abstract class ContainsDuplicateTestsBase<T> where T : IContainsDuplicate, new()
{
    [TestMethod]
    [DataRow("[1, 2, 3, 1]", true)]
    [DataRow("[1, 2, 3, 4]", false)]
    [DataRow("[1, 1, 1, 3, 3, 4, 3, 2, 4, 2]", true)]
    public void ContainsDuplicate_GivenArray_ReturnsTrueIfDuplicatesExist(string numsJsonArray, bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ContainsDuplicate(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}