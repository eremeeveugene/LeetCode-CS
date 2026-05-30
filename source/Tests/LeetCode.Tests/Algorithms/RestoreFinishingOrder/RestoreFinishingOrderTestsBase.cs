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

using LeetCode.Algorithms.RestoreFinishingOrder;

namespace LeetCode.Tests.Algorithms.RestoreFinishingOrder;

public abstract class RestoreFinishingOrderTestsBase<T> where T : IRestoreFinishingOrder, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1, 2, 5, 4 }, new[] { 1, 3, 4 }, new[] { 3, 1, 4 })]
    [DataRow(new[] { 1, 4, 5, 3, 2 }, new[] { 2, 5 }, new[] { 5, 2 })]
    public void RecoverOrder_WithFriendIdsInOrderArray_ReturnsFriendsInFinishingOrder(int[] orders,
        int[] friends, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RecoverOrder(orders, friends);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}