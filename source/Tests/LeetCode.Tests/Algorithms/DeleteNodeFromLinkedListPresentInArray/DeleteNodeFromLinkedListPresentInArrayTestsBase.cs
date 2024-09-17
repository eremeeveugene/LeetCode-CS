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

using LeetCode.Algorithms.DeleteNodeFromLinkedListPresentInArray;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteNodeFromLinkedListPresentInArray;

public abstract class DeleteNodeFromLinkedListPresentInArrayTestsBase<T>
    where T : IDeleteNodeFromLinkedListPresentInArray, new()
{
    [TestMethod]
    [DataRow("[]", "[1,2,3,4,5]", "[1,2,3,4,5]")]
    [DataRow("[1,2,3]", "[1,2,3,4,5]", "[4,5]")]
    [DataRow("[1]", "[1,2,1,2,1,2]", "[2,2,2]")]
    [DataRow("[5]", "[1,2,3,4]", "[1,2,3,4]")]
    [DataRow("[312,514,872,995,1204,1567,2093,3057,4500,4999,5781,6352,7234,8345,9999]",
        "[234,312,405,514,672,872,995,1040,1204,1500,1567,2093,2500,3057,4000,4500,4999,5781,6000,6352,7000,7234,8000,8345,9000,9999]",
        "[234,405,672,1040,1500,2500,4000,6000,7000,8000,9000]")]
    public void ModifiedList_WithNumsAndHeadArray_ReturnsModifiedList(string numsJsonArray, string headJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray);
        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ModifiedList(nums, head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}