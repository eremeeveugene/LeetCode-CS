// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.AddTwoNumbers;
using LeetCode.Core.Extensions;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Algorithms.AddTwoNumbers;

[TestClass]
public class AddTwoNumbersInPlaceCarryTests
{
    [TestMethod]
    [DataRow(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
    [DataRow(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    [DataRow(new[] { 9 }, new[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 })]
    public void AddTwoNumbersInPlaceCarry_GetResult_ShouldAddTwoLinkedListsCorrectly(int[] array1, int[] array2,
        int[] expectedResultArray)
    {
        // Arrange
        var list1 = array1.ToListNode();
        var list2 = array2.ToListNode();
        var expectedResult = expectedResultArray.ToListNode();

        // Act
        var actualResult = AddTwoNumbersInPlaceCarry.GetResult(list1, list2);

        // Assert
        AssertExtensions.AreListNodesEqual(expectedResult, actualResult);
    }
}