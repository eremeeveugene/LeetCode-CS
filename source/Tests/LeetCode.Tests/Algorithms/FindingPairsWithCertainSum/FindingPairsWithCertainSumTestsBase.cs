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

using LeetCode.Algorithms.FindingPairsWithCertainSum;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.FindingPairsWithCertainSum;

public abstract class FindingPairsWithCertainSumTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void FindingPairsWithCertainSum_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        FindingPairsWithCertainSumScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Nums1, scenario.Nums2);

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
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    protected abstract IFindingPairsWithCertainSum GetSolution(int[] nums1, int[] nums2);

    private static IEnumerable<FindingPairsWithCertainSumScenario[]> GetScenarios()
    {
        yield return
        [
            new FindingPairsWithCertainSumScenario(
                [1, 1, 2, 2, 2, 3],
                [1, 4, 5, 2, 5, 4],
                [
                    new CountOperation(7),
                    new AddOperation(3, 2),
                    new CountOperation(8),
                    new CountOperation(4),
                    new AddOperation(0, 1),
                    new AddOperation(1, 1),
                    new CountOperation(7)
                ],
                [
                    new CountOperation.Result(8),
                    VoidOperationResult.Instance,
                    new CountOperation.Result(2),
                    new CountOperation.Result(1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountOperation.Result(11)
                ])
        ];

        yield return
        [
            new FindingPairsWithCertainSumScenario(
                [1],
                [1],
                [
                    new CountOperation(2),
                    new CountOperation(3),
                    new AddOperation(0, 1),
                    new CountOperation(3),
                    new CountOperation(2)
                ],
                [
                    new CountOperation.Result(1),
                    new CountOperation.Result(0),
                    VoidOperationResult.Instance,
                    new CountOperation.Result(1),
                    new CountOperation.Result(0)
                ])
        ];

        yield return
        [
            new FindingPairsWithCertainSumScenario(
                [1, 2],
                [3, 3],
                [
                    new CountOperation(4),
                    new CountOperation(5),
                    new AddOperation(1, 2),
                    new CountOperation(4),
                    new CountOperation(7),
                    new CountOperation(6)
                ],
                [
                    new CountOperation.Result(2),
                    new CountOperation.Result(2),
                    VoidOperationResult.Instance,
                    new CountOperation.Result(1),
                    new CountOperation.Result(1),
                    new CountOperation.Result(1)
                ])
        ];
    }

    public sealed class FindingPairsWithCertainSumScenario : IScenario<IFindingPairsWithCertainSum>
    {
        public FindingPairsWithCertainSumScenario(
            int[] nums1,
            int[] nums2,
            IOperation<IFindingPairsWithCertainSum>[] operations,
            IOperationResult[] operationResults)
        {
            Nums1 = nums1;
            Nums2 = nums2;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int[] Nums1 { get; }

        public int[] Nums2 { get; }

        public IOperation<IFindingPairsWithCertainSum>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class AddOperation : IOperation<IFindingPairsWithCertainSum>
    {
        private readonly int _index;
        private readonly int _value;

        public AddOperation(int index, int value)
        {
            _index = index;
            _value = value;
        }

        public IOperationResult Execute(IFindingPairsWithCertainSum findingPairsWithCertainSum)
        {
            findingPairsWithCertainSum.Add(_index, _value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class CountOperation : IOperation<IFindingPairsWithCertainSum>
    {
        private readonly int _tot;

        public CountOperation(int tot)
        {
            _tot = tot;
        }

        public IOperationResult Execute(IFindingPairsWithCertainSum findingPairsWithCertainSum)
        {
            var count = findingPairsWithCertainSum.Count(_tot);

            return new Result(count);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _count;

            public Result(int count)
            {
                _count = count;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _count == other._count;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_count);
            }
        }
    }
}