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

using LeetCode.Algorithms.RecoverTreeFromPreorderTraversal;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RecoverTreeFromPreorderTraversal;

public abstract class RecoverTreeFromPreorderTraversalTestsBase<T> where T : IRecoverTreeFromPreorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RecoverFromPreorder_WithTraversalString_ConstructsBinaryTree(string traversal, int?[] expectedResultArray)
    {
        // Arrange
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RecoverFromPreorder(traversal);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return ["1-2--3--4-5--6--7", new int?[] { 1, 2, 5, 3, 4, 6, 7 }];

        yield return ["1-2--3---4-5--6---7", new int?[] { 1, 2, 5, 3, null, 6, null, 4, null, 7 }];

        yield return ["1-401--349---90--88", new int?[] { 1, 401, null, 349, 88, 90 }];

        yield return ["1", new int?[] { 1 }];

        yield return ["5", new int?[] { 5 }];

        yield return ["1000000000", new int?[] { 1000000000 }];

        yield return ["1-2", new int?[] { 1, 2 }];

        yield return ["1-2-3", new int?[] { 1, 2, 3 }];

        yield return ["1-2--3", new int?[] { 1, 2, null, 3 }];

        yield return ["1-2--3---4", new int?[] { 1, 2, null, 3, null, 4 }];

        yield return ["1-2--3--4", new int?[] { 1, 2, null, 3, 4 }];

        yield return ["1-2-3--4", new int?[] { 1, 2, 3, null, null, 4 }];

        yield return ["10-20--30-40--50--60", new int?[] { 10, 20, 40, 30, null, 50, 60 }];

        yield return ["7-8--9---10----11", new int?[] { 7, 8, null, 9, null, 10, null, 11 }];

        yield return ["3-1--0-5--4--6", new int?[] { 3, 1, 5, 0, null, 4, 6 }];

        yield return ["2-1-3", new int?[] { 2, 1, 3 }];

        yield return ["100-200--300---400-500--600---700", new int?[] { 100, 200, 500, 300, null, 600, null, 400, null, 700 }];

        yield return ["1-2--3--4---5---6-7", new int?[] { 1, 2, 7, 3, 4, null, null, null, null, 5, 6 }];

        yield return ["8-4--2---1---3--6-12--10", new int?[] { 8, 4, 12, 2, 6, 10, null, 1, 3 }];

        yield return ["999999999-1000000000-1", new int?[] { 999999999, 1000000000, 1 }];

        yield return ["1-2--3---4----5-----6------7", new int?[] { 1, 2, null, 3, null, 4, null, 5, null, 6, null, 7 }];

        yield return [CreateMaxDepthTraversal(), CreateMaxDepthExpected()];
    }

    private static string CreateMaxDepthTraversal()
    {
        var builder = new System.Text.StringBuilder();

        builder.Append('1');

        for (var depth = 1; depth < 1000; depth++)
        {
            builder.Append('-', depth);
            builder.Append(depth + 1);
        }

        return builder.ToString();
    }

    private static int?[] CreateMaxDepthExpected()
    {
        var expected = new int?[(2 * 1000) - 2];

        expected[0] = 1;

        for (var i = 1; i < 1000; i++)
        {
            expected[(2 * i) - 1] = i + 1;
        }

        return expected;
    }
}