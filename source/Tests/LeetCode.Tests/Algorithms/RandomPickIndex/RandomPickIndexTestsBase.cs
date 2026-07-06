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

using LeetCode.Algorithms.RandomPickIndex;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.RandomPickIndex;

public abstract class RandomPickIndexTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void RandomPickIndex_WithGivenArrayAndPickQueries_ReturnsAnIndexOfTheTarget(RandomPickIndexScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Nums);

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

    protected abstract IRandomPickIndex GetSolution(int[] nums);

    private static IEnumerable<RandomPickIndexScenario[]> GetScenarios()
    {
        yield return [new RandomPickIndexScenario([1, 2, 3, 3, 3], [new PickOperation(3), new PickOperation(1)], [new PickOperation.Result([2, 3, 4]), new PickOperation.Result([0])])];

        yield return [new RandomPickIndexScenario([1, 1, 1, 1], [new PickOperation(1), new PickOperation(1)], [new PickOperation.Result([0, 1, 2, 3]), new PickOperation.Result([0, 1, 2, 3])])];

        yield return [new RandomPickIndexScenario([-1, -2, -1, -3, -1], [new PickOperation(-1)], [new PickOperation.Result([0, 2, 4])])];

        yield return [new RandomPickIndexScenario([5], [new PickOperation(5)], [new PickOperation.Result([0])])];

        yield return [new RandomPickIndexScenario([1, 2, 1, 2, 1], [new PickOperation(1), new PickOperation(2)], [new PickOperation.Result([0, 2, 4]), new PickOperation.Result([1, 3])])];

        yield return [new RandomPickIndexScenario([0, 0, 0, 0, 0], [new PickOperation(0)], [new PickOperation.Result([0, 1, 2, 3, 4])])];

        yield return [new RandomPickIndexScenario([7, 8, 7, 8, 7, 8], [new PickOperation(8)], [new PickOperation.Result([1, 3, 5])])];

        yield return [new RandomPickIndexScenario([100, 200, 100, 300, 100], [new PickOperation(100)], [new PickOperation.Result([0, 2, 4])])];

        yield return [new RandomPickIndexScenario([-5, -5, 5, 5], [new PickOperation(-5), new PickOperation(5)], [new PickOperation.Result([0, 1]), new PickOperation.Result([2, 3])])];

        yield return [new RandomPickIndexScenario([1, 2, 3, 4, 5], [new PickOperation(3)], [new PickOperation.Result([2])])];

        yield return [new RandomPickIndexScenario([2, 2, 2, 2, 2, 2, 2], [new PickOperation(2)], [new PickOperation.Result([0, 1, 2, 3, 4, 5, 6])])];

        yield return [new RandomPickIndexScenario([1, 3, 1, 3, 1, 3, 1], [new PickOperation(1), new PickOperation(3)], [new PickOperation.Result([0, 2, 4, 6]), new PickOperation.Result([1, 3, 5])])];

        yield return [new RandomPickIndexScenario([9, 9, 9], [new PickOperation(9), new PickOperation(9), new PickOperation(9)], [new PickOperation.Result([0, 1, 2]), new PickOperation.Result([0, 1, 2]), new PickOperation.Result([0, 1, 2])])];

        yield return [new RandomPickIndexScenario([-10, 10, -10, 10], [new PickOperation(-10)], [new PickOperation.Result([0, 2])])];

        yield return [new RandomPickIndexScenario([1, 1, 2, 2, 3, 3], [new PickOperation(1), new PickOperation(2), new PickOperation(3)], [new PickOperation.Result([0, 1]), new PickOperation.Result([2, 3]), new PickOperation.Result([4, 5])])];

        yield return [new RandomPickIndexScenario([4], [new PickOperation(4)], [new PickOperation.Result([0])])];

        yield return [new RandomPickIndexScenario([1, 2, 3, 2, 1], [new PickOperation(1), new PickOperation(2), new PickOperation(3)], [new PickOperation.Result([0, 4]), new PickOperation.Result([1, 3]), new PickOperation.Result([2])])];

        yield return [new RandomPickIndexScenario([6, 6, 6, 6], [new PickOperation(6)], [new PickOperation.Result([0, 1, 2, 3])])];

        yield return [new RandomPickIndexScenario([0, 1, 0, 1, 0, 1, 0], [new PickOperation(0), new PickOperation(1)], [new PickOperation.Result([0, 2, 4, 6]), new PickOperation.Result([1, 3, 5])])];

        yield return [new RandomPickIndexScenario([3, 3, 3, 3, 3, 3, 3, 3], [new PickOperation(3)], [new PickOperation.Result([0, 1, 2, 3, 4, 5, 6, 7])])];
    }

    public sealed class RandomPickIndexScenario : IScenario<IRandomPickIndex>
    {
        public RandomPickIndexScenario(int[] nums, IOperation<IRandomPickIndex>[] operations, IOperationResult[] operationResults)
        {
            Nums = nums;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int[] Nums { get; }

        public IOperation<IRandomPickIndex>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class PickOperation : IOperation<IRandomPickIndex>
    {
        private readonly int _target;

        public PickOperation(int target)
        {
            _target = target;
        }

        public IOperationResult Execute(IRandomPickIndex randomPickIndex)
        {
            var index = randomPickIndex.Pick(_target);

            return new Result([index]);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int[] _validOptions;

            public Result(int[] validOptions)
            {
                _validOptions = validOptions;
            }

            public bool Equals(Result? other)
            {
                return other is not null && other._validOptions.Any(o => _validOptions.Contains(o));
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }
    }
}