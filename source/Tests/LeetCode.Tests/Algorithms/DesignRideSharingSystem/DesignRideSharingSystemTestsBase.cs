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

using LeetCode.Algorithms.DesignRideSharingSystem;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignRideSharingSystem;

public abstract class DesignRideSharingSystemTestsBase<T> where T : IDesignRideSharingSystem, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignRideSharingSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IDesignRideSharingSystem> scenario)
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

    private static IEnumerable<IScenario<IDesignRideSharingSystem>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(3),
                    new AddDriverOperation(2),
                    new AddRiderOperation(1),
                    new MatchDriverWithRiderOperation(),
                    new AddDriverOperation(5),
                    new CancelRiderOperation(3),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([2, 3]),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 1]),
                    new MatchDriverWithRiderOperation.Result([-1, -1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(8),
                    new AddDriverOperation(8),
                    new AddDriverOperation(6),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(2),
                    new CancelRiderOperation(2),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([8, 8]),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>([new MatchDriverWithRiderOperation()], [new MatchDriverWithRiderOperation.Result([-1, -1])])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new MatchDriverWithRiderOperation(), new MatchDriverWithRiderOperation(), new MatchDriverWithRiderOperation()],
                [
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    new MatchDriverWithRiderOperation.Result([-1, -1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new AddRiderOperation(1), new MatchDriverWithRiderOperation()],
                [VoidOperationResult.Instance, new MatchDriverWithRiderOperation.Result([-1, -1])])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new AddDriverOperation(1), new MatchDriverWithRiderOperation()],
                [VoidOperationResult.Instance, new MatchDriverWithRiderOperation.Result([-1, -1])])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new AddRiderOperation(1), new AddDriverOperation(2), new MatchDriverWithRiderOperation(), new MatchDriverWithRiderOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([2, 1]),
                    new MatchDriverWithRiderOperation.Result([-1, -1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new AddDriverOperation(2), new AddRiderOperation(1), new MatchDriverWithRiderOperation(), new MatchDriverWithRiderOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([2, 1]),
                    new MatchDriverWithRiderOperation.Result([-1, -1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new AddRiderOperation(1), new MatchDriverWithRiderOperation(), new AddDriverOperation(2), new MatchDriverWithRiderOperation()],
                [
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([2, 1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new AddDriverOperation(2), new MatchDriverWithRiderOperation(), new AddRiderOperation(1), new MatchDriverWithRiderOperation()],
                [
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([2, 1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(3),
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new AddDriverOperation(9),
                    new AddDriverOperation(7),
                    new AddDriverOperation(8),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([9, 3]),
                    new MatchDriverWithRiderOperation.Result([7, 1]),
                    new MatchDriverWithRiderOperation.Result([8, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddDriverOperation(9),
                    new AddDriverOperation(7),
                    new AddDriverOperation(8),
                    new AddRiderOperation(3),
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([9, 3]),
                    new MatchDriverWithRiderOperation.Result([7, 1]),
                    new MatchDriverWithRiderOperation.Result([8, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new AddDriverOperation(5),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation(),
                    new AddDriverOperation(6),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 1]),
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([6, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddDriverOperation(5),
                    new AddDriverOperation(6),
                    new AddRiderOperation(1),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(2),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 1]),
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([6, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new CancelRiderOperation(1),
                    new AddDriverOperation(5),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new AddRiderOperation(3),
                    new CancelRiderOperation(2),
                    new AddDriverOperation(5),
                    new AddDriverOperation(6),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 1]),
                    new MatchDriverWithRiderOperation.Result([6, 3])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new CancelRiderOperation(2),
                    new AddDriverOperation(5),
                    new AddDriverOperation(6),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 1]),
                    new MatchDriverWithRiderOperation.Result([-1, -1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new CancelRiderOperation(1),
                    new CancelRiderOperation(2),
                    new AddDriverOperation(5),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(3),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 3])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new CancelRiderOperation(1),
                    new CancelRiderOperation(1),
                    new AddDriverOperation(5),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(2),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new CancelRiderOperation(1), new AddRiderOperation(1), new AddDriverOperation(5), new MatchDriverWithRiderOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new AddRiderOperation(1), new CancelRiderOperation(2), new AddDriverOperation(5), new MatchDriverWithRiderOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddDriverOperation(5),
                    new MatchDriverWithRiderOperation(),
                    new CancelRiderOperation(1),
                    new AddRiderOperation(2),
                    new AddDriverOperation(6),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 1]),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([6, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new AddRiderOperation(3),
                    new CancelRiderOperation(1),
                    new CancelRiderOperation(2),
                    new AddDriverOperation(5),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 3])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new CancelRiderOperation(1),
                    new MatchDriverWithRiderOperation(),
                    new AddDriverOperation(5),
                    new AddRiderOperation(2),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddDriverOperation(5),
                    new AddDriverOperation(6),
                    new AddRiderOperation(1),
                    new CancelRiderOperation(1),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(2),
                    new AddRiderOperation(3),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([5, 2]),
                    new MatchDriverWithRiderOperation.Result([6, 3])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddDriverOperation(1),
                    new CancelRiderOperation(1),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(2),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([1, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [new AddRiderOperation(1000), new AddDriverOperation(1000), new MatchDriverWithRiderOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new MatchDriverWithRiderOperation.Result([1000, 1000])])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddRiderOperation(1000),
                    new AddDriverOperation(1000),
                    new AddDriverOperation(1),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([1000, 1]),
                    new MatchDriverWithRiderOperation.Result([1, 1000])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new CancelRiderOperation(1000),
                    new CancelRiderOperation(1000),
                    new AddDriverOperation(1),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(1000),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([1, 1000])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(4),
                    new AddDriverOperation(8),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(3),
                    new AddDriverOperation(7),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([8, 4]),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([7, 3]),
                    new MatchDriverWithRiderOperation.Result([-1, -1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new AddRiderOperation(3),
                    new AddRiderOperation(4),
                    new CancelRiderOperation(4),
                    new CancelRiderOperation(2),
                    new AddDriverOperation(9),
                    new AddDriverOperation(8),
                    new AddDriverOperation(7),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation(),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(5),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([9, 1]),
                    new MatchDriverWithRiderOperation.Result([8, 3]),
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([7, 5])
                ])
        ];

        yield return
        [
            new Scenario<IDesignRideSharingSystem>(
                [
                    new AddRiderOperation(1),
                    new AddRiderOperation(2),
                    new AddDriverOperation(9),
                    new CancelRiderOperation(2),
                    new MatchDriverWithRiderOperation(),
                    new CancelRiderOperation(1),
                    new AddDriverOperation(8),
                    new MatchDriverWithRiderOperation(),
                    new AddRiderOperation(3),
                    new MatchDriverWithRiderOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([9, 1]),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([-1, -1]),
                    VoidOperationResult.Instance,
                    new MatchDriverWithRiderOperation.Result([8, 3])
                ])
        ];

        const int pairCount = 333;
        const int operationCount = 1000;

        var matchingOperations = new IOperation<IDesignRideSharingSystem>[operationCount];
        var matchingResults = new IOperationResult[operationCount];

        for (var i = 0; i < pairCount; i++)
        {
            var riderId = i + 1;
            var driverId = 1000 - i;

            matchingOperations[i] = new AddRiderOperation(riderId);
            matchingResults[i] = VoidOperationResult.Instance;

            matchingOperations[pairCount + i] = new AddDriverOperation(driverId);
            matchingResults[pairCount + i] = VoidOperationResult.Instance;

            matchingOperations[(pairCount * 2) + i] = new MatchDriverWithRiderOperation();
            matchingResults[(pairCount * 2) + i] = new MatchDriverWithRiderOperation.Result([driverId, riderId]);
        }

        matchingOperations[^1] = new MatchDriverWithRiderOperation();
        matchingResults[^1] = new MatchDriverWithRiderOperation.Result([-1, -1]);

        yield return [new Scenario<IDesignRideSharingSystem>(matchingOperations, matchingResults)];

        const int canceledRiderCount = 499;

        var cancellationOperations = new IOperation<IDesignRideSharingSystem>[operationCount];
        var cancellationResults = new IOperationResult[operationCount];

        for (var i = 0; i < canceledRiderCount; i++)
        {
            var riderId = i + 1;

            cancellationOperations[i] = new AddRiderOperation(riderId);
            cancellationResults[i] = VoidOperationResult.Instance;

            cancellationOperations[canceledRiderCount + i] = new CancelRiderOperation(riderId);
            cancellationResults[canceledRiderCount + i] = VoidOperationResult.Instance;
        }

        cancellationOperations[^2] = new AddDriverOperation(1000);
        cancellationResults[^2] = VoidOperationResult.Instance;

        cancellationOperations[^1] = new MatchDriverWithRiderOperation();
        cancellationResults[^1] = new MatchDriverWithRiderOperation.Result([-1, -1]);

        yield return [new Scenario<IDesignRideSharingSystem>(cancellationOperations, cancellationResults)];
    }

    private sealed class AddRiderOperation : IOperation<IDesignRideSharingSystem>
    {
        private readonly int _riderId;

        public AddRiderOperation(int riderId)
        {
            _riderId = riderId;
        }

        public IOperationResult Execute(IDesignRideSharingSystem solution)
        {
            solution.AddRider(_riderId);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class AddDriverOperation : IOperation<IDesignRideSharingSystem>
    {
        private readonly int _driverId;

        public AddDriverOperation(int driverId)
        {
            _driverId = driverId;
        }

        public IOperationResult Execute(IDesignRideSharingSystem solution)
        {
            solution.AddDriver(_driverId);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class CancelRiderOperation : IOperation<IDesignRideSharingSystem>
    {
        private readonly int _riderId;

        public CancelRiderOperation(int riderId)
        {
            _riderId = riderId;
        }

        public IOperationResult Execute(IDesignRideSharingSystem solution)
        {
            solution.CancelRider(_riderId);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class MatchDriverWithRiderOperation : IOperation<IDesignRideSharingSystem>
    {
        public IOperationResult Execute(IDesignRideSharingSystem solution)
        {
            var result = solution.MatchDriverWithRider();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int[] _match;

            public Result(int[] match)
            {
                _match = match;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _match.SequenceEqual(other._match);
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                var hashCode = new HashCode();

                foreach (var value in _match)
                {
                    hashCode.Add(value);
                }

                return hashCode.ToHashCode();
            }
        }
    }
}