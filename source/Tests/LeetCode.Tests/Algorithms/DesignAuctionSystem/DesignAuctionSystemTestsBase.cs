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

using LeetCode.Algorithms.DesignAuctionSystem;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignAuctionSystem;

public abstract class DesignAuctionSystemTestsBase<T> where T : IDesignAuctionSystem, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignAuctionSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IDesignAuctionSystem> scenario)
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

    private static IEnumerable<IScenario<IDesignAuctionSystem>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 7, 5),
                    new AddBidOperation(2, 7, 6),
                    new GetHighestBidderOperation(7),
                    new UpdateBidOperation(1, 7, 8),
                    new GetHighestBidderOperation(7),
                    new RemoveBidOperation(2, 7),
                    new GetHighestBidderOperation(7),
                    new GetHighestBidderOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1),
                    new GetHighestBidderOperation.Result(-1)
                ])
        ];

        yield return [new Scenario<IDesignAuctionSystem>([new GetHighestBidderOperation(1)], [new GetHighestBidderOperation.Result(-1)])];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new GetHighestBidderOperation(50000), new GetHighestBidderOperation(50000)],
                [new GetHighestBidderOperation.Result(-1), new GetHighestBidderOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(1, 1, 1), new GetHighestBidderOperation(1)],
                [VoidOperationResult.Instance, new GetHighestBidderOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(50000, 50000, 1000000000), new GetHighestBidderOperation(50000)],
                [VoidOperationResult.Instance, new GetHighestBidderOperation.Result(50000)])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(1, 2, 10), new AddBidOperation(2, 2, 20), new AddBidOperation(3, 2, 30), new GetHighestBidderOperation(2)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(1, 2, 30), new AddBidOperation(2, 2, 20), new AddBidOperation(3, 2, 10), new GetHighestBidderOperation(2)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(1, 1, 10), new AddBidOperation(2, 1, 10), new GetHighestBidderOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetHighestBidderOperation.Result(2)])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(2, 1, 10), new AddBidOperation(1, 1, 10), new GetHighestBidderOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetHighestBidderOperation.Result(2)])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(2, 1, 10),
                    new AddBidOperation(3, 1, 10),
                    new AddBidOperation(1, 1, 10),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(3, 1),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(2, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(3),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(1, 1, 10), new AddBidOperation(2, 1, 20), new AddBidOperation(1, 1, 30), new GetHighestBidderOperation(1)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 30),
                    new AddBidOperation(2, 1, 20),
                    new AddBidOperation(1, 1, 10),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(2, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 10),
                    new AddBidOperation(1, 1, 10),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(1, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 10), new AddBidOperation(2, 1, 20), new UpdateBidOperation(1, 1, 30), new GetHighestBidderOperation(1)
                ],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetHighestBidderOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 30),
                    new AddBidOperation(2, 1, 20),
                    new UpdateBidOperation(1, 1, 10),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(2, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 10),
                    new UpdateBidOperation(1, 1, 10),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(1, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 20), new AddBidOperation(2, 1, 10), new UpdateBidOperation(2, 1, 20), new GetHighestBidderOperation(1)
                ],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetHighestBidderOperation.Result(2)])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 10), new AddBidOperation(2, 1, 20), new UpdateBidOperation(1, 1, 20), new GetHighestBidderOperation(1)
                ],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetHighestBidderOperation.Result(2)])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(1, 1, 10), new RemoveBidOperation(1, 1), new GetHighestBidderOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetHighestBidderOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 30),
                    new AddBidOperation(2, 1, 20),
                    new AddBidOperation(3, 1, 10),
                    new RemoveBidOperation(1, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(1, 1, 30), new AddBidOperation(2, 1, 20), new RemoveBidOperation(2, 1), new GetHighestBidderOperation(1)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 10),
                    new AddBidOperation(2, 1, 20),
                    new RemoveBidOperation(1, 1),
                    new RemoveBidOperation(2, 1),
                    new GetHighestBidderOperation(1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(-1),
                    new GetHighestBidderOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 100),
                    new RemoveBidOperation(1, 1),
                    new AddBidOperation(1, 1, 1),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(1, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [new AddBidOperation(1, 1, 100), new RemoveBidOperation(1, 1), new AddBidOperation(2, 1, 1), new GetHighestBidderOperation(1)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 10),
                    new AddBidOperation(1, 2, 20),
                    new UpdateBidOperation(1, 1, 30),
                    new RemoveBidOperation(1, 2),
                    new GetHighestBidderOperation(1),
                    new GetHighestBidderOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1),
                    new GetHighestBidderOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 10),
                    new AddBidOperation(2, 1, 20),
                    new AddBidOperation(1, 2, 30),
                    new AddBidOperation(2, 2, 5),
                    new GetHighestBidderOperation(1),
                    new GetHighestBidderOperation(2),
                    new RemoveBidOperation(2, 1),
                    new GetHighestBidderOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(2),
                    new GetHighestBidderOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 2, 10),
                    new AddBidOperation(2, 1, 20),
                    new GetHighestBidderOperation(2),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(1, 2),
                    new GetHighestBidderOperation(2),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1),
                    new GetHighestBidderOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(-1),
                    new GetHighestBidderOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 10),
                    new UpdateBidOperation(1, 1, 20),
                    new AddBidOperation(2, 1, 30),
                    new AddBidOperation(1, 1, 40),
                    new GetHighestBidderOperation(1),
                    new UpdateBidOperation(1, 1, 1),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(2, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(50000, 1, 1000000000),
                    new AddBidOperation(1, 1, 1000000000),
                    new GetHighestBidderOperation(1),
                    new UpdateBidOperation(50000, 1, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(50000),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(2, 1, 30),
                    new AddBidOperation(1, 1, 20),
                    new AddBidOperation(2, 1, 20),
                    new GetHighestBidderOperation(1),
                    new AddBidOperation(2, 1, 10),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(50000, 50000, 1),
                    new UpdateBidOperation(50000, 50000, 1000000000),
                    new GetHighestBidderOperation(50000),
                    new UpdateBidOperation(50000, 50000, 1),
                    new RemoveBidOperation(50000, 50000),
                    new GetHighestBidderOperation(50000)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(50000),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAuctionSystem>(
                [
                    new AddBidOperation(1, 1, 1000000000),
                    new AddBidOperation(50000, 1, 1),
                    new GetHighestBidderOperation(1),
                    new RemoveBidOperation(1, 1),
                    new GetHighestBidderOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetHighestBidderOperation.Result(50000)
                ])
        ];

        const int bidCount = 16666;
        const int itemId = 50000;
        const int bidAmount = 1000000000;

        var rankedOperations = new IOperation<IDesignAuctionSystem>[bidCount * 3];
        var rankedResults = new IOperationResult[rankedOperations.Length];

        for (var i = 0; i < bidCount; i++)
        {
            rankedOperations[i] = new AddBidOperation(i + 1, itemId, bidAmount);
            rankedResults[i] = VoidOperationResult.Instance;

            var operationIndex = bidCount + (i * 2);
            var highestUserId = bidCount - i;

            rankedOperations[operationIndex] = new GetHighestBidderOperation(itemId);
            rankedResults[operationIndex] = new GetHighestBidderOperation.Result(highestUserId);

            rankedOperations[operationIndex + 1] = new RemoveBidOperation(highestUserId, itemId);
            rankedResults[operationIndex + 1] = VoidOperationResult.Instance;
        }

        yield return [new Scenario<IDesignAuctionSystem>(rankedOperations, rankedResults)];

        const int operationCount = 50000;
        const int operationsPerBid = 5;

        var lifecycleOperations = new IOperation<IDesignAuctionSystem>[operationCount];
        var lifecycleResults = new IOperationResult[operationCount];

        for (var i = 0; i < operationCount; i += operationsPerBid)
        {
            var userId = (i / operationsPerBid) + 1;

            lifecycleOperations[i] = new AddBidOperation(userId, itemId, 1);
            lifecycleResults[i] = VoidOperationResult.Instance;

            lifecycleOperations[i + 1] = new UpdateBidOperation(userId, itemId, bidAmount);
            lifecycleResults[i + 1] = VoidOperationResult.Instance;

            lifecycleOperations[i + 2] = new GetHighestBidderOperation(itemId);
            lifecycleResults[i + 2] = new GetHighestBidderOperation.Result(userId);

            lifecycleOperations[i + 3] = new RemoveBidOperation(userId, itemId);
            lifecycleResults[i + 3] = VoidOperationResult.Instance;

            lifecycleOperations[i + 4] = new GetHighestBidderOperation(itemId);
            lifecycleResults[i + 4] = new GetHighestBidderOperation.Result(-1);
        }

        yield return [new Scenario<IDesignAuctionSystem>(lifecycleOperations, lifecycleResults)];
    }

    private sealed class AddBidOperation : IOperation<IDesignAuctionSystem>
    {
        private readonly int _bidAmount;
        private readonly int _itemId;
        private readonly int _userId;

        public AddBidOperation(int userId, int itemId, int bidAmount)
        {
            _userId = userId;
            _itemId = itemId;
            _bidAmount = bidAmount;
        }

        public IOperationResult Execute(IDesignAuctionSystem solution)
        {
            solution.AddBid(_userId, _itemId, _bidAmount);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class UpdateBidOperation : IOperation<IDesignAuctionSystem>
    {
        private readonly int _itemId;
        private readonly int _newAmount;
        private readonly int _userId;

        public UpdateBidOperation(int userId, int itemId, int newAmount)
        {
            _userId = userId;
            _itemId = itemId;
            _newAmount = newAmount;
        }

        public IOperationResult Execute(IDesignAuctionSystem solution)
        {
            solution.UpdateBid(_userId, _itemId, _newAmount);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class RemoveBidOperation : IOperation<IDesignAuctionSystem>
    {
        private readonly int _itemId;
        private readonly int _userId;

        public RemoveBidOperation(int userId, int itemId)
        {
            _userId = userId;
            _itemId = itemId;
        }

        public IOperationResult Execute(IDesignAuctionSystem solution)
        {
            solution.RemoveBid(_userId, _itemId);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class GetHighestBidderOperation : IOperation<IDesignAuctionSystem>
    {
        private readonly int _itemId;

        public GetHighestBidderOperation(int itemId)
        {
            _itemId = itemId;
        }

        public IOperationResult Execute(IDesignAuctionSystem solution)
        {
            var result = solution.GetHighestBidder(_itemId);

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