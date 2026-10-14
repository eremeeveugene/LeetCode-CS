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

using LeetCode.Algorithms.TwoBestNonOverlappingEvents;

namespace LeetCode.Tests.Algorithms.TwoBestNonOverlappingEvents;

public abstract class TwoBestNonOverlappingEventsTestsBase<T> where T : ITwoBestNonOverlappingEvents, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxTwoEvents_WithEventStartEndAndValue_ReturnsMaximumValueFromNonOverlappingEvents(int[][] events, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxTwoEvents(events);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 3, 2 }, new[] { 4, 5, 2 }, new[] { 2, 4, 3 } }, 4];

        yield return [new[] { new[] { 1, 3, 2 }, new[] { 4, 5, 2 }, new[] { 1, 5, 5 } }, 5];

        yield return [new[] { new[] { 1, 5, 3 }, new[] { 1, 5, 1 }, new[] { 6, 6, 5 } }, 8];

        yield return [new[] { new[] { 1, 2, 5 }, new[] { 3, 4, 1 } }, 6];

        yield return [new[] { new[] { 2, 2, 5 }, new[] { 1, 3, 4 } }, 5];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 2, 2, 1 } }, 2];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 1];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 2, 3, 4 } }, 4];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 3, 4, 4 } }, 7];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 4 } }, 7];

        yield return [new[] { new[] { 1, 10, 100 }, new[] { 2, 3, 1 }, new[] { 4, 5, 1 } }, 100];

        yield return [new[] { new[] { 1, 3, 5 }, new[] { 4, 6, 5 }, new[] { 7, 9, 5 } }, 10];

        yield return [new[] { new[] { 1, 1000000000, 1000000 }, new[] { 1, 1, 1 } }, 1000000];

        yield return [new[] { new[] { 1, 5, 8 }, new[] { 6, 10, 7 }, new[] { 11, 15, 6 } }, 15];

        yield return [new[] { new[] { 10, 20, 3 }, new[] { 1, 5, 4 }, new[] { 6, 9, 5 }, new[] { 21, 30, 2 } }, 9];

        yield return [new[] { new[] { 1, 3, 2 }, new[] { 2, 5, 6 }, new[] { 4, 7, 3 }, new[] { 6, 9, 8 } }, 14];

        yield return [new[] { new[] { 5, 5, 5 }, new[] { 5, 5, 4 }, new[] { 6, 6, 1 } }, 6];

        yield return [new[] { new[] { 1, 4, 4 }, new[] { 4, 8, 8 }, new[] { 9, 12, 3 } }, 11];

        yield return [new[] { new[] { 23, 30, 4 }, new[] { 23, 25, 4 }, new[] { 7, 10, 6 }, new[] { 3, 7, 7 }, new[] { 16, 20, 14 } }, 21];

        yield return [new[] { new[] { 20, 21, 5 }, new[] { 22, 23, 17 }, new[] { 6, 12, 7 }, new[] { 16, 17, 19 }, new[] { 28, 37, 16 }, new[] { 21, 27, 8 }, new[] { 28, 38, 19 }, new[] { 14, 24, 13 } }, 38];

        yield return [BuildEvents(100000, 0), 2000];

        yield return [BuildEvents(100000, 1), 1000000];

        yield return [BuildEvents(100000, 2), 1999987];

        yield return [BuildEvents(100000, 3), 2000000];
    }

    private static int[][] BuildEvents(int count, int shape)
    {
        var events = new int[count][];

        for (var i = 0; i < count; i++)
        {
            switch (shape)
            {
                case 0:
                    events[i] = [(i * 10) + 1, (i * 10) + 5, (i * 7 % 1000) + 1];

                    break;
                case 1:
                    events[i] = [1, 1000000000, 1000000];

                    break;
                case 2:
                    events[i] = [1 + (i * 10000), 1 + (i * 10000) + 9999, (i * 13 % 1000000) + 1];

                    break;
                default:
                    events[i] = [count - i, count - i, 1000000 - (i % 1000)];

                    break;
            }
        }

        return events;
    }
}