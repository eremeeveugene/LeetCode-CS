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

using LeetCode.Algorithms.MergeTwoSortedLists;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.MergeTwoSortedLists;

public abstract class MergeTwoSortedListsTestsBase<T> where T : IMergeTwoSortedLists, new()
{
    [TestMethod]
    [DataRow("[]", "[]", "[]")]
    [DataRow("[]", "[0]", "[0]")]
    [DataRow("[0]", "[]", "[0]")]
    [DataRow("[1,2,4]", "[1,3,4]", "[1,1,2,3,4,4]")]
    [DataRow("[-9,3]", "[5,7]", "[-9,3,5,7]")]
    public void MergeTwoLists_WithTwoIntegerArrays_ReturnsMergedSortedLinkedList(string list1Json,
        string list2Json, string expectedResultJson)
    {
        // Arrange
        var list1Array = JsonHelper<int[]>.Parse(list1Json);
        var list1 = ListNode.ToListNode(list1Array);
        var list2Array = JsonHelper<int[]>.Parse(list2Json);
        var list2 = ListNode.ToListNode(list2Array);
        var expectedResultArray = JsonHelper<int[]>.Parse(expectedResultJson);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.MergeTwoLists(list1, list2);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}