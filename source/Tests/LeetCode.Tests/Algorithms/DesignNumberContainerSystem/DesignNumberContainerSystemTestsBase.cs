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

using LeetCode.Algorithms.DesignNumberContainerSystem;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignNumberContainerSystem;

public abstract class DesignNumberContainerSystemTestsBase<T> where T : IDesignNumberContainerSystem, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignNumberContainerSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        IScenario<IDesignNumberContainerSystem> scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = new T();

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

    private static IEnumerable<IScenario<IDesignNumberContainerSystem>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [
                    new FindOperation(10),
                    new ChangeOperation(2, 10),
                    new ChangeOperation(1, 10),
                    new ChangeOperation(3, 10),
                    new ChangeOperation(5, 10),
                    new FindOperation(10),
                    new ChangeOperation(1, 20),
                    new FindOperation(10)
                ],
                [
                    new FindOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new FindOperation.Result(1),
                    VoidOperationResult.Instance,
                    new FindOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new FindOperation(1), new FindOperation(0)],
                [new FindOperation.Result(-1), new FindOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(1, 10), new FindOperation(10), new ChangeOperation(1, 20), new FindOperation(10), new FindOperation(20)],
                [
                    VoidOperationResult.Instance,
                    new FindOperation.Result(1),
                    VoidOperationResult.Instance,
                    new FindOperation.Result(-1),
                    new FindOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(5, 10), new ChangeOperation(2, 10), new ChangeOperation(8, 10), new FindOperation(10)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new FindOperation.Result(2)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(1, 1), new FindOperation(1)],
                [VoidOperationResult.Instance, new FindOperation.Result(1)])
        ];

        yield return [new Scenario<IDesignNumberContainerSystem>([new FindOperation(5)], [new FindOperation.Result(-1)])];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(3, 7), new FindOperation(7), new FindOperation(8)],
                [VoidOperationResult.Instance, new FindOperation.Result(3), new FindOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(1, 5), new ChangeOperation(2, 5), new ChangeOperation(3, 5), new FindOperation(5)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new FindOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(1, 10), new ChangeOperation(1, 20), new FindOperation(10), new FindOperation(20)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new FindOperation.Result(-1), new FindOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(10, 1), new ChangeOperation(5, 1), new FindOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new FindOperation.Result(5)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(1, 1), new ChangeOperation(2, 2), new FindOperation(1), new FindOperation(2), new FindOperation(3)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new FindOperation.Result(1),
                    new FindOperation.Result(2),
                    new FindOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(1, 5), new ChangeOperation(1, 5), new FindOperation(5)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new FindOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(3, 9), new ChangeOperation(1, 9), new ChangeOperation(2, 9), new FindOperation(9)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new FindOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new FindOperation(0), new FindOperation(100)],
                [new FindOperation.Result(-1), new FindOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(4, 2), new ChangeOperation(4, 3), new FindOperation(2), new FindOperation(3)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new FindOperation.Result(-1), new FindOperation.Result(4)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(1, 1), new ChangeOperation(2, 1), new ChangeOperation(1, 2), new FindOperation(1), new FindOperation(2)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new FindOperation.Result(2),
                    new FindOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(100, 99), new FindOperation(99), new FindOperation(100)],
                [VoidOperationResult.Instance, new FindOperation.Result(100), new FindOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [new ChangeOperation(5, 5), new ChangeOperation(5, 5), new FindOperation(5)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new FindOperation.Result(5)])
        ];

        yield return
        [
            new Scenario<IDesignNumberContainerSystem>(
                [
                    new ChangeOperation(1, 10), new ChangeOperation(2, 10), new ChangeOperation(2, 20), new FindOperation(10), new FindOperation(20)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new FindOperation.Result(1),
                    new FindOperation.Result(2)
                ])
        ];
    }

    private sealed class ChangeOperation : IOperation<IDesignNumberContainerSystem>
    {
        private readonly int _index;
        private readonly int _number;

        public ChangeOperation(int index, int number)
        {
            _index = index;
            _number = number;
        }

        public IOperationResult Execute(IDesignNumberContainerSystem designNumberContainerSystem)
        {
            designNumberContainerSystem.Change(_index, _number);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class FindOperation : IOperation<IDesignNumberContainerSystem>
    {
        private readonly int _number;

        public FindOperation(int number)
        {
            _number = number;
        }

        public IOperationResult Execute(IDesignNumberContainerSystem designNumberContainerSystem)
        {
            var index = designNumberContainerSystem.Find(_number);

            return new Result(index);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _index;

            public Result(int index)
            {
                _index = index;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _index == other._index;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_index);
            }
        }
    }
}