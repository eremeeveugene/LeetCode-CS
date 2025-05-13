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

using LeetCode.Algorithms.FindAllNumbersDisappearedInArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindAllNumbersDisappearedInArray;

public abstract class FindAllNumbersDisappearedInArrayTestsBase<T> where T : IFindAllNumbersDisappearedInArray, new()
{
    [TestMethod]
    [DataRow("[4,3,2,7,8,2,3,1]", "[5,6]")]
    [DataRow("[1,1]", "[2]")]
    public void FindDisappearedNumbers_WithInputArrayContainingDuplicates_ReturnsMissingNumbers(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindDisappearedNumbers(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}