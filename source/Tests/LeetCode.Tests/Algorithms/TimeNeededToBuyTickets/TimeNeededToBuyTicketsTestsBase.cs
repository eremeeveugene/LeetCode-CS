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

using LeetCode.Algorithms.TimeNeededToBuyTickets;

namespace LeetCode.Tests.Algorithms.TimeNeededToBuyTickets;

public abstract class TimeNeededToBuyTicketsTestsBase<T> where T : ITimeNeededToBuyTickets, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 2 }, 2, 6)]
    [DataRow(new[] { 5, 1, 1, 1 }, 0, 8)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 8, 81)]
    [DataRow(new[] { 84, 49, 5, 24, 70, 77, 87, 8 }, 3, 154)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 4, 51)]
    [DataRow(new[] { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 4, 95)]
    [DataRow(new[] { 15, 66, 3, 47, 71, 27, 54, 43, 97, 34, 94, 33, 54, 26, 15, 52, 20, 71, 88, 42, 50, 6, 66, 88, 36, 99, 27, 82, 7, 72 }, 18, 1457)]
    [DataRow(new[] { 1 }, 0, 1)]
    [DataRow(new[] { 5 }, 0, 5)]
    [DataRow(new[] { 2, 2 }, 0, 3)]
    [DataRow(new[] { 2, 2 }, 1, 4)]
    [DataRow(new[] { 1, 1, 1 }, 1, 2)]
    [DataRow(new[] { 3, 1, 2 }, 0, 6)]
    [DataRow(new[] { 3, 1, 2 }, 2, 5)]
    [DataRow(new[] { 1, 5, 1 }, 1, 7)]
    [DataRow(new[] { 4, 3, 2, 1 }, 3, 4)]
    [DataRow(new[] { 1, 2, 3, 4 }, 0, 1)]
    [DataRow(new[] { 100, 100 }, 1, 200)]
    [DataRow(new[] { 5, 5, 5, 5 }, 2, 19)]
    [DataRow(new[] { 2, 6, 3, 4, 5 }, 2, 12)]
    [DataRow(new[] { 10, 1, 10, 1, 10 }, 4, 32)]
    [DataRow(new[] { 7, 7, 7 }, 0, 19)]
    [DynamicData(nameof(GetLargeTestData))]
    public void TimeRequiredToBuy_WithTicketsArrayAndTargetIndex_ReturnsTotalTimeForKthPersonToFinish(int[] tickets, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TimeRequiredToBuy(tickets, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [BuildTickets(100, 0), 99, 10000];

        yield return [BuildTickets(100, 0), 0, 9901];

        yield return [BuildTickets(100, 7), 50, 3797];
    }

    private static int[] BuildTickets(int length, int multiplier)
    {
        var tickets = new int[length];

        for (var i = 0; i < length; i++)
        {
            tickets[i] = multiplier == 0 ? length : (i * multiplier % length) + 1;
        }

        return tickets;
    }
}