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

using LeetCode.Algorithms.KthLargestElementInStream;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.KthLargestElementInStream;

public abstract class KthLargestElementInStreamTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void KthLargestElementInStream_WithMixedOperations_ProcessesOperationsAccordingToSpecification(KthLargestScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.K, scenario.Nums);

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

    protected abstract IKthLargestElementInStream GetSolution(int k, int[] nums);

    private static IEnumerable<KthLargestScenario[]> GetScenarios()
    {
        yield return
        [
            new KthLargestScenario(
                3,
                [4, 5, 8, 2],
                [new AddOperation(3), new AddOperation(5), new AddOperation(10), new AddOperation(9), new AddOperation(4)],
                [
                    new AddOperation.Result(4), new AddOperation.Result(5), new AddOperation.Result(5), new AddOperation.Result(8),
                    new AddOperation.Result(8)
                ])
        ];

        yield return
        [
            new KthLargestScenario(
                4,
                [7, 7, 7, 7, 8, 3],
                [new AddOperation(2), new AddOperation(10), new AddOperation(9), new AddOperation(9)],
                [new AddOperation.Result(7), new AddOperation.Result(7), new AddOperation.Result(7), new AddOperation.Result(8)])
        ];

        yield return
        [
            new KthLargestScenario(
                1,
                [1],
                [new AddOperation(2), new AddOperation(3), new AddOperation(1)],
                [new AddOperation.Result(2), new AddOperation.Result(3), new AddOperation.Result(3)])
        ];

        yield return
        [
            new KthLargestScenario(
                2,
                [5, 10],
                [new AddOperation(1), new AddOperation(2), new AddOperation(20)],
                [new AddOperation.Result(5), new AddOperation.Result(5), new AddOperation.Result(10)])
        ];

        yield return
        [
            new KthLargestScenario(
                1,
                [],
                [new AddOperation(3), new AddOperation(5), new AddOperation(2)],
                [new AddOperation.Result(3), new AddOperation.Result(5), new AddOperation.Result(5)])
        ];
    }

    public sealed class KthLargestScenario : IScenario<IKthLargestElementInStream>
    {
        public KthLargestScenario(int k, int[] nums, IOperation<IKthLargestElementInStream>[] operations, IOperationResult[] operationResults)
        {
            K = k;
            Nums = nums;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int K { get; }
        public int[] Nums { get; }

        public IOperation<IKthLargestElementInStream>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class AddOperation : IOperation<IKthLargestElementInStream>
    {
        private readonly int _value;

        public AddOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IKthLargestElementInStream kthLargestElementInStream)
        {
            var result = kthLargestElementInStream.Add(_value);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _kthLargest;

            public Result(int kthLargest)
            {
                _kthLargest = kthLargest;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _kthLargest == other._kthLargest;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_kthLargest);
            }
        }
    }
}