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

using LeetCode.Algorithms.ValidArrangementOfPairs;

namespace LeetCode.Tests.Algorithms.ValidArrangementOfPairs;

public abstract class ValidArrangementOfPairsTestsBase<T> where T : IValidArrangementOfPairs, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ValidArrangement_WithDirectedEdgePairs_ReturnsValidArrangementOfPairs(int[][] pairs, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ValidArrangement(pairs);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 4, 5 }, new[] { 11, 9 }, new[] { 9, 4 }, new[] { 5, 2 }, new[] { 2, 6 }, new[] { 6, 7 }, new[] { 7, 8 }, new[] { 8, 5 }, new[] { 5, 12 }, new[] { 12, 13 }, new[] { 13, 5 }, new[] { 5, 1 } }, new[] { new[] { 11, 9 }, new[] { 9, 4 }, new[] { 4, 5 }, new[] { 5, 12 }, new[] { 12, 13 }, new[] { 13, 5 }, new[] { 5, 2 }, new[] { 2, 6 }, new[] { 6, 7 }, new[] { 7, 8 }, new[] { 8, 5 }, new[] { 5, 1 } }];

        // Single pair
        yield return [new[] { new[] { 1, 2 } }, new[] { new[] { 1, 2 } }];

        // Two pairs forming a chain: 1->2, 2->3
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 } }];

        // Three pairs in a chain: 1->2, 2->3, 3->4
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }];

        // Cycle with clear start (Eulerian circuit starting at lowest out-degree surplus): 1->2, 2->3, 3->1
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 1 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 1 } }];

        // Two pairs with repeated node: 5->6, 6->7
        yield return [new[] { new[] { 5, 6 }, new[] { 6, 7 } }, new[] { new[] { 5, 6 }, new[] { 6, 7 } }];

        // Pairs with same start and end
        yield return [new[] { new[] { 3, 3 } }, new[] { new[] { 3, 3 } }];

        // Chain of 4 pairs: 0->1, 1->2, 2->3, 3->4
        yield return [new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }];

        // Chain of 5 pairs: 10->20, 20->30, 30->40, 40->50, 50->60
        yield return [new[] { new[] { 10, 20 }, new[] { 20, 30 }, new[] { 30, 40 }, new[] { 40, 50 }, new[] { 50, 60 } }, new[] { new[] { 10, 20 }, new[] { 20, 30 }, new[] { 30, 40 }, new[] { 40, 50 }, new[] { 50, 60 } }];

        // Two pairs, reverse order input: 2->3 given first but 1->2 must come first
        yield return [new[] { new[] { 2, 3 }, new[] { 1, 2 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 } }];

        // Three pairs with reversed input: 3->4 first, 1->2 second, 2->3 third
        yield return [new[] { new[] { 3, 4 }, new[] { 1, 2 }, new[] { 2, 3 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }];

        // Longer chain with reversed input: 4->5 first, 3->4 second, 2->3 third, 1->2 fourth
        yield return [new[] { new[] { 4, 5 }, new[] { 3, 4 }, new[] { 2, 3 }, new[] { 1, 2 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }];

        // Chain of 8 pairs: 1->2, 2->3, 3->4, 4->5, 5->6, 6->7, 7->8, 8->9
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 6, 7 }, new[] { 7, 8 }, new[] { 8, 9 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 6, 7 }, new[] { 7, 8 }, new[] { 8, 9 } }];

        // Chain of 3 pairs starting at negative: -3->-2, -2->-1, -1->0
        yield return [new[] { new[] { -3, -2 }, new[] { -2, -1 }, new[] { -1, 0 } }, new[] { new[] { -3, -2 }, new[] { -2, -1 }, new[] { -1, 0 } }];

        // Larger chain: 100->200, 200->300, 300->400, 400->500, 500->600, 600->700
        yield return [new[] { new[] { 100, 200 }, new[] { 200, 300 }, new[] { 300, 400 }, new[] { 400, 500 }, new[] { 500, 600 }, new[] { 600, 700 } }, new[] { new[] { 100, 200 }, new[] { 200, 300 }, new[] { 300, 400 }, new[] { 400, 500 }, new[] { 500, 600 }, new[] { 600, 700 } }];

        // Chain reversed in input: 6->7, 5->6, 4->5, 3->4, 2->3, 1->2
        yield return [new[] { new[] { 6, 7 }, new[] { 5, 6 }, new[] { 4, 5 }, new[] { 3, 4 }, new[] { 2, 3 }, new[] { 1, 2 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 6, 7 } }];

        // Cycle: 1->2, 2->3, 3->4, 4->1
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 1 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 1 } }];

        // Five-cycle: 1->2, 2->3, 3->4, 4->5, 5->1
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 1 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 1 } }];

        // LeetCode example 2: [[5,1],[4,5],[11,9],[9,4]]
        yield return [new[] { new[] { 5, 1 }, new[] { 4, 5 }, new[] { 11, 9 }, new[] { 9, 4 } }, new[] { new[] { 11, 9 }, new[] { 9, 4 }, new[] { 4, 5 }, new[] { 5, 1 } }];

        // LeetCode example 3: [[1,3],[3,2],[2,1]]
        yield return [new[] { new[] { 1, 3 }, new[] { 3, 2 }, new[] { 2, 1 } }, new[] { new[] { 1, 3 }, new[] { 3, 2 }, new[] { 2, 1 } }];
    }
}