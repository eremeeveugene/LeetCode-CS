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

using LeetCode.Algorithms.PartitionArrayAccordingToGivenPivot;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.PartitionArrayAccordingToGivenPivot;

public abstract class PartitionArrayAccordingToGivenPivotTestsBase<T>
    where T : IPartitionArrayAccordingToGivenPivot, new()
{
    [TestMethod]
    [DataRow("[9,12,5,10,14,3,10]", 10, "[9,5,3,10,10,12,14]")]
    [DataRow("[-3,4,3,2]", 2, "[-3,2,4,3]")]
    public void PivotArray_WithUnsortedArrayAndPivot_ReturnsPartitionedArray(string numsJson, int pivot,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.PivotArray(nums, pivot);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}