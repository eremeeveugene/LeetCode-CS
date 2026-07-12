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

using LeetCode.Algorithms.FindElementsInContaminatedBinaryTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.FindElementsInContaminatedBinaryTree;

public abstract class FindElementsInContaminatedBinaryTreeTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void FindElementsInContaminatedBinaryTree_WithVariousTreeStructures_ReturnsIfElementsFound(ContaminatedBinaryTreeScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Root);

        // Act
        var operations = scenario.Operations;
        var operationsLength = operations.Length;

        var actualResult = new IOperationResult[operationsLength];

        for (var i = 0; i < operationsLength; i++)
        {
            var operation = operations[i];

            actualResult[i] = operation.Execute(solution);
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IFindElementsInContaminatedBinaryTree GetSolution(TreeNode root);

    private static IEnumerable<ContaminatedBinaryTreeScenario[]> GetScenarios()
    {
        yield return
        [
            new ContaminatedBinaryTreeScenario(
                TreeNode.ToTreeNodeOrThrow([-1, null, -1]),
                [new FindOperation(1), new FindOperation(2)],
                [new FindOperation.Result(false), new FindOperation.Result(true)])
        ];

        yield return
        [
            new ContaminatedBinaryTreeScenario(
                TreeNode.ToTreeNodeOrThrow([-1, -1, -1, -1, -1]),
                [new FindOperation(1), new FindOperation(3), new FindOperation(5)],
                [new FindOperation.Result(true), new FindOperation.Result(true), new FindOperation.Result(false)])
        ];

        yield return
        [
            new ContaminatedBinaryTreeScenario(
                TreeNode.ToTreeNodeOrThrow([-1, null, -1, -1, null, -1]),
                [new FindOperation(2), new FindOperation(3), new FindOperation(4), new FindOperation(5)],
                [
                    new FindOperation.Result(true),
                    new FindOperation.Result(false),
                    new FindOperation.Result(false),
                    new FindOperation.Result(true)
                ])
        ];
    }

    public sealed class ContaminatedBinaryTreeScenario : IScenario<IFindElementsInContaminatedBinaryTree>
    {
        public ContaminatedBinaryTreeScenario(
            TreeNode root,
            IOperation<IFindElementsInContaminatedBinaryTree>[] operations,
            IOperationResult[] operationResults)
        {
            Root = root;
            Operations = operations;
            OperationResults = operationResults;
        }

        public TreeNode Root { get; }

        public IOperation<IFindElementsInContaminatedBinaryTree>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class FindOperation : IOperation<IFindElementsInContaminatedBinaryTree>
    {
        private readonly int _target;

        public FindOperation(int target)
        {
            _target = target;
        }

        public IOperationResult Execute(IFindElementsInContaminatedBinaryTree findElementsInContaminatedBinaryTree)
        {
            var found = findElementsInContaminatedBinaryTree.Find(_target);

            return new Result(found);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _found;

            public Result(bool found)
            {
                _found = found;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _found == other._found;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_found);
            }
        }
    }
}