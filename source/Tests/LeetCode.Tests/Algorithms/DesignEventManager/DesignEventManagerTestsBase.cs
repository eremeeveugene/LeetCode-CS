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

using LeetCode.Algorithms.DesignEventManager;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignEventManager;

public abstract class DesignEventManagerTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignEventManager_WithMixedOperations_ProcessesOperationsAccordingToSpecification(EventManagerScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Events);

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

    protected abstract IDesignEventManager GetSolution(int[][] events);

    private static IEnumerable<EventManagerScenario[]> GetScenarios()
    {
        yield return
        [
            new EventManagerScenario(
                [[5, 7], [2, 7], [9, 4]],
                [new PollHighestOperation(), new UpdatePriorityOperation(9, 7), new PollHighestOperation(), new PollHighestOperation()],
                [
                    new PollHighestOperation.Result(2),
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(5),
                    new PollHighestOperation.Result(9)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[4, 1], [7, 2]],
                [new PollHighestOperation(), new PollHighestOperation(), new PollHighestOperation()],
                [new PollHighestOperation.Result(7), new PollHighestOperation.Result(4), new PollHighestOperation.Result(-1)])
        ];

        yield return
        [
            new EventManagerScenario(
                [[1, 1]],
                [new PollHighestOperation(), new PollHighestOperation()],
                [new PollHighestOperation.Result(1), new PollHighestOperation.Result(-1)])
        ];

        yield return
        [
            new EventManagerScenario(
                [[3, 5], [1, 5], [2, 5]],
                [new PollHighestOperation(), new PollHighestOperation(), new PollHighestOperation(), new PollHighestOperation()],
                [
                    new PollHighestOperation.Result(1),
                    new PollHighestOperation.Result(2),
                    new PollHighestOperation.Result(3),
                    new PollHighestOperation.Result(-1)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[10, 1], [20, 2], [30, 3]],
                [new UpdatePriorityOperation(10, 100), new PollHighestOperation(), new PollHighestOperation()],
                [VoidOperationResult.Instance, new PollHighestOperation.Result(10), new PollHighestOperation.Result(30)])
        ];

        yield return
        [
            new EventManagerScenario(
                [[1, 10], [2, 20]],
                [new UpdatePriorityOperation(2, 5), new PollHighestOperation(), new PollHighestOperation()],
                [VoidOperationResult.Instance, new PollHighestOperation.Result(1), new PollHighestOperation.Result(2)])
        ];

        yield return
        [
            new EventManagerScenario(
                [[1, 5], [2, 3]],
                [new UpdatePriorityOperation(1, 5), new PollHighestOperation(), new PollHighestOperation(), new PollHighestOperation()],
                [
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(1),
                    new PollHighestOperation.Result(2),
                    new PollHighestOperation.Result(-1)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[1, 1], [2, 2], [3, 3]],
                [
                    new UpdatePriorityOperation(1, 10),
                    new UpdatePriorityOperation(1, 2),
                    new PollHighestOperation(),
                    new PollHighestOperation(),
                    new PollHighestOperation(),
                    new PollHighestOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(3),
                    new PollHighestOperation.Result(1),
                    new PollHighestOperation.Result(2),
                    new PollHighestOperation.Result(-1)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[1000000000, 1000000000], [1, 1000000000]],
                [new PollHighestOperation(), new PollHighestOperation()],
                [new PollHighestOperation.Result(1), new PollHighestOperation.Result(1000000000)])
        ];

        yield return
        [
            new EventManagerScenario(
                [[1, 1000000000], [1000000000, 1]],
                [new PollHighestOperation(), new PollHighestOperation()],
                [new PollHighestOperation.Result(1), new PollHighestOperation.Result(1000000000)])
        ];

        yield return
        [
            new EventManagerScenario(
                [[8, 4], [3, 2]],
                [new UpdatePriorityOperation(3, 4), new PollHighestOperation(), new PollHighestOperation()],
                [VoidOperationResult.Instance, new PollHighestOperation.Result(3), new PollHighestOperation.Result(8)])
        ];

        yield return
        [
            new EventManagerScenario(
                [[3, 4], [8, 2]],
                [new UpdatePriorityOperation(8, 4), new PollHighestOperation(), new PollHighestOperation()],
                [VoidOperationResult.Instance, new PollHighestOperation.Result(3), new PollHighestOperation.Result(8)])
        ];

        yield return
        [
            new EventManagerScenario(
                [[7, 7]],
                [new PollHighestOperation(), new PollHighestOperation(), new PollHighestOperation()],
                [new PollHighestOperation.Result(7), new PollHighestOperation.Result(-1), new PollHighestOperation.Result(-1)])
        ];

        yield return
        [
            new EventManagerScenario(
                [[1, 3], [2, 2], [3, 1]],
                [
                    new PollHighestOperation(),
                    new UpdatePriorityOperation(3, 5),
                    new PollHighestOperation(),
                    new PollHighestOperation(),
                    new PollHighestOperation()
                ],
                [
                    new PollHighestOperation.Result(1),
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(3),
                    new PollHighestOperation.Result(2),
                    new PollHighestOperation.Result(-1)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[1, 5], [2, 4]],
                [new UpdatePriorityOperation(1, 1), new UpdatePriorityOperation(1, 6), new PollHighestOperation(), new PollHighestOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(1),
                    new PollHighestOperation.Result(2)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[42, 1]],
                [
                    new UpdatePriorityOperation(42, 2),
                    new UpdatePriorityOperation(42, 3),
                    new UpdatePriorityOperation(42, 1),
                    new PollHighestOperation(),
                    new PollHighestOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(42),
                    new PollHighestOperation.Result(-1)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[5, 1], [4, 2], [3, 3], [2, 4], [1, 5]],
                [
                    new PollHighestOperation(),
                    new PollHighestOperation(),
                    new PollHighestOperation(),
                    new PollHighestOperation(),
                    new PollHighestOperation()
                ],
                [
                    new PollHighestOperation.Result(1),
                    new PollHighestOperation.Result(2),
                    new PollHighestOperation.Result(3),
                    new PollHighestOperation.Result(4),
                    new PollHighestOperation.Result(5)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[5, 1], [4, 2], [3, 3]],
                [
                    new UpdatePriorityOperation(5, 9),
                    new UpdatePriorityOperation(4, 9),
                    new UpdatePriorityOperation(3, 9),
                    new PollHighestOperation(),
                    new PollHighestOperation(),
                    new PollHighestOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(3),
                    new PollHighestOperation.Result(4),
                    new PollHighestOperation.Result(5)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[10, 10], [20, 20], [30, 30]],
                [
                    new PollHighestOperation(),
                    new UpdatePriorityOperation(10, 25),
                    new PollHighestOperation(),
                    new UpdatePriorityOperation(20, 1),
                    new PollHighestOperation(),
                    new PollHighestOperation()
                ],
                [
                    new PollHighestOperation.Result(30),
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(10),
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(20),
                    new PollHighestOperation.Result(-1)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[6, 3], [2, 3], [4, 3]],
                [new UpdatePriorityOperation(2, 1), new PollHighestOperation(), new PollHighestOperation(), new PollHighestOperation()],
                [
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(4),
                    new PollHighestOperation.Result(6),
                    new PollHighestOperation.Result(2)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[100, 50], [200, 50], [300, 60]],
                [new UpdatePriorityOperation(300, 50), new PollHighestOperation(), new PollHighestOperation(), new PollHighestOperation()],
                [
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(100),
                    new PollHighestOperation.Result(200),
                    new PollHighestOperation.Result(300)
                ])
        ];

        yield return
        [
            new EventManagerScenario(
                [[1, 2], [2, 1]],
                [
                    new UpdatePriorityOperation(1, 1),
                    new PollHighestOperation(),
                    new UpdatePriorityOperation(2, 3),
                    new PollHighestOperation(),
                    new PollHighestOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(1),
                    VoidOperationResult.Instance,
                    new PollHighestOperation.Result(2),
                    new PollHighestOperation.Result(-1)
                ])
        ];
    }

    public sealed class EventManagerScenario : IScenario<IDesignEventManager>
    {
        public EventManagerScenario(int[][] events, IOperation<IDesignEventManager>[] operations, IOperationResult[] operationResults)
        {
            Events = events;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int[][] Events { get; }

        public IOperation<IDesignEventManager>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class UpdatePriorityOperation : IOperation<IDesignEventManager>
    {
        private readonly int _eventId;
        private readonly int _newPriority;

        public UpdatePriorityOperation(int eventId, int newPriority)
        {
            _eventId = eventId;
            _newPriority = newPriority;
        }

        public IOperationResult Execute(IDesignEventManager designEventManager)
        {
            designEventManager.UpdatePriority(_eventId, _newPriority);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class PollHighestOperation : IOperation<IDesignEventManager>
    {
        public IOperationResult Execute(IDesignEventManager designEventManager)
        {
            var eventId = designEventManager.PollHighest();

            return new Result(eventId);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _eventId;

            public Result(int eventId)
            {
                _eventId = eventId;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _eventId == other._eventId;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_eventId);
            }
        }
    }
}