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

using LeetCode.Algorithms.DesignFrontMiddleBackQueue;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignFrontMiddleBackQueue;

public abstract class DesignFrontMiddleBackQueueTestsBase<T> where T : IDesignFrontMiddleBackQueue, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignFrontMiddleBackQueue_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        IScenario<IDesignFrontMiddleBackQueue> scenario)
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
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<IScenario<IDesignFrontMiddleBackQueue>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [
                    new PushFrontOperation(1),
                    new PushBackOperation(2),
                    new PushMiddleOperation(3),
                    new PushMiddleOperation(4),
                    new PopFrontOperation(),
                    new PopMiddleOperation(),
                    new PopMiddleOperation(),
                    new PopBackOperation(),
                    new PopFrontOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopFrontOperation.Result(1),
                    new PopMiddleOperation.Result(3),
                    new PopMiddleOperation.Result(4),
                    new PopBackOperation.Result(2),
                    new PopFrontOperation.Result(-1)
                ])
        ];

        yield return [new Scenario<IDesignFrontMiddleBackQueue>([new PopFrontOperation()], [new PopFrontOperation.Result(-1)])];

        yield return [new Scenario<IDesignFrontMiddleBackQueue>([new PopMiddleOperation()], [new PopMiddleOperation.Result(-1)])];

        yield return [new Scenario<IDesignFrontMiddleBackQueue>([new PopBackOperation()], [new PopBackOperation.Result(-1)])];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushFrontOperation(5), new PopFrontOperation()],
                [VoidOperationResult.Instance, new PopFrontOperation.Result(5)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushBackOperation(7), new PopBackOperation()],
                [VoidOperationResult.Instance, new PopBackOperation.Result(7)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushMiddleOperation(3), new PopMiddleOperation()],
                [VoidOperationResult.Instance, new PopMiddleOperation.Result(3)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushFrontOperation(1), new PushFrontOperation(2), new PopFrontOperation(), new PopFrontOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new PopFrontOperation.Result(2), new PopFrontOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushBackOperation(1), new PushBackOperation(2), new PopBackOperation(), new PopBackOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new PopBackOperation.Result(2), new PopBackOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushFrontOperation(1), new PushBackOperation(2), new PopMiddleOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new PopMiddleOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushFrontOperation(1), new PushBackOperation(2), new PushFrontOperation(3), new PopMiddleOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PopMiddleOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushMiddleOperation(1), new PushMiddleOperation(2), new PopFrontOperation(), new PopFrontOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new PopFrontOperation.Result(2), new PopFrontOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [
                    new PushFrontOperation(1),
                    new PushFrontOperation(2),
                    new PushFrontOperation(3),
                    new PopMiddleOperation(),
                    new PopMiddleOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopMiddleOperation.Result(2),
                    new PopMiddleOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [
                    new PushBackOperation(1), new PushBackOperation(2), new PushBackOperation(3), new PopMiddleOperation(), new PopMiddleOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopMiddleOperation.Result(2),
                    new PopMiddleOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushFrontOperation(5), new PushMiddleOperation(10), new PopFrontOperation(), new PopFrontOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new PopFrontOperation.Result(10), new PopFrontOperation.Result(5)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [
                    new PushFrontOperation(1),
                    new PushBackOperation(3),
                    new PushMiddleOperation(2),
                    new PopFrontOperation(),
                    new PopMiddleOperation(),
                    new PopBackOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopFrontOperation.Result(1),
                    new PopMiddleOperation.Result(2),
                    new PopBackOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushBackOperation(2), new PushFrontOperation(1), new PopMiddleOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new PopMiddleOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [
                    new PushFrontOperation(1),
                    new PushFrontOperation(2),
                    new PushFrontOperation(3),
                    new PushFrontOperation(4),
                    new PopFrontOperation(),
                    new PopBackOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopFrontOperation.Result(4),
                    new PopBackOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [
                    new PushMiddleOperation(1),
                    new PushMiddleOperation(2),
                    new PushMiddleOperation(3),
                    new PopMiddleOperation(),
                    new PopMiddleOperation(),
                    new PopMiddleOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopMiddleOperation.Result(3),
                    new PopMiddleOperation.Result(2),
                    new PopMiddleOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushFrontOperation(10), new PushBackOperation(20), new PopBackOperation(), new PopFrontOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new PopBackOperation.Result(20), new PopFrontOperation.Result(10)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushMiddleOperation(1), new PushFrontOperation(2), new PushBackOperation(3), new PopMiddleOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PopMiddleOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [
                    new PushFrontOperation(1), new PushFrontOperation(2), new PushBackOperation(3), new PopMiddleOperation(), new PopBackOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopMiddleOperation.Result(1),
                    new PopBackOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [
                    new PushBackOperation(5), new PushMiddleOperation(10), new PushFrontOperation(15), new PopFrontOperation(), new PopBackOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopFrontOperation.Result(15),
                    new PopBackOperation.Result(5)
                ])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PopFrontOperation(), new PopBackOperation(), new PopMiddleOperation()],
                [new PopFrontOperation.Result(-1), new PopBackOperation.Result(-1), new PopMiddleOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignFrontMiddleBackQueue>(
                [new PushFrontOperation(1), new PushBackOperation(2), new PushMiddleOperation(3), new PopFrontOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PopFrontOperation.Result(1)])
        ];
    }

    private sealed class PushFrontOperation : IOperation<IDesignFrontMiddleBackQueue>
    {
        private readonly int _value;

        public PushFrontOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignFrontMiddleBackQueue solution)
        {
            solution.PushFront(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class PushMiddleOperation : IOperation<IDesignFrontMiddleBackQueue>
    {
        private readonly int _value;

        public PushMiddleOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignFrontMiddleBackQueue solution)
        {
            solution.PushMiddle(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class PushBackOperation : IOperation<IDesignFrontMiddleBackQueue>
    {
        private readonly int _value;

        public PushBackOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignFrontMiddleBackQueue solution)
        {
            solution.PushBack(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class PopFrontOperation : IOperation<IDesignFrontMiddleBackQueue>
    {
        public IOperationResult Execute(IDesignFrontMiddleBackQueue solution)
        {
            var result = solution.PopFront();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _value;

            public Result(int value)
            {
                _value = value;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _value == other._value;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_value);
            }
        }
    }

    private sealed class PopMiddleOperation : IOperation<IDesignFrontMiddleBackQueue>
    {
        public IOperationResult Execute(IDesignFrontMiddleBackQueue solution)
        {
            var result = solution.PopMiddle();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _value;

            public Result(int value)
            {
                _value = value;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _value == other._value;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_value);
            }
        }
    }

    private sealed class PopBackOperation : IOperation<IDesignFrontMiddleBackQueue>
    {
        public IOperationResult Execute(IDesignFrontMiddleBackQueue solution)
        {
            var result = solution.PopBack();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _value;

            public Result(int value)
            {
                _value = value;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _value == other._value;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_value);
            }
        }
    }
}