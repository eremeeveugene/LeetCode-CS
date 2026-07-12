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

using LeetCode.Algorithms.DesignUndergroundSystem;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignUndergroundSystem;

public abstract class DesignUndergroundSystemTestsBase<T> where T : IDesignUndergroundSystem, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignUndergroundSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IDesignUndergroundSystem> scenario)
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

    private static IEnumerable<IScenario<IDesignUndergroundSystem>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(45, "Leyton", 3),
                    new CheckInOperation(32, "Paradise", 8),
                    new CheckInOperation(27, "Leyton", 10),
                    new CheckOutOperation(45, "Waterloo", 15),
                    new CheckOutOperation(27, "Waterloo", 20),
                    new CheckOutOperation(32, "Cambridge", 22),
                    new GetAverageTimeOperation("Paradise", "Cambridge"),
                    new GetAverageTimeOperation("Leyton", "Waterloo"),
                    new CheckInOperation(10, "Leyton", 24),
                    new GetAverageTimeOperation("Leyton", "Waterloo"),
                    new CheckOutOperation(10, "Waterloo", 38),
                    new GetAverageTimeOperation("Leyton", "Waterloo")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(14d),
                    new GetAverageTimeOperation.Result(11d),
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(11d),
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(12d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(10, "Leyton", 3),
                    new CheckOutOperation(10, "Paradise", 8),
                    new GetAverageTimeOperation("Leyton", "Paradise"),
                    new CheckInOperation(5, "Leyton", 10),
                    new CheckOutOperation(5, "Paradise", 16),
                    new GetAverageTimeOperation("Leyton", "Paradise"),
                    new CheckInOperation(2, "Leyton", 21),
                    new CheckOutOperation(2, "Paradise", 30),
                    new GetAverageTimeOperation("Leyton", "Paradise")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(5d),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(5.5d),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(20d / 3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [new CheckInOperation(1, "A", 1), new CheckOutOperation(1, "B", 11), new GetAverageTimeOperation("A", "B")],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetAverageTimeOperation.Result(10d)])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckOutOperation(1, "B", 6),
                    new CheckInOperation(2, "A", 2),
                    new CheckOutOperation(2, "B", 10),
                    new GetAverageTimeOperation("A", "B")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(6.5d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckOutOperation(1, "B", 5),
                    new CheckInOperation(2, "B", 2),
                    new CheckOutOperation(2, "A", 10),
                    new GetAverageTimeOperation("A", "B"),
                    new GetAverageTimeOperation("B", "A")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(4d),
                    new GetAverageTimeOperation.Result(8d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "X", 1),
                    new CheckOutOperation(1, "Y", 4),
                    new CheckInOperation(1, "Y", 5),
                    new CheckOutOperation(1, "Z", 9),
                    new GetAverageTimeOperation("X", "Y"),
                    new GetAverageTimeOperation("Y", "Z")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(3d),
                    new GetAverageTimeOperation.Result(4d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckOutOperation(1, "B", 2),
                    new CheckInOperation(2, "A", 1),
                    new CheckOutOperation(2, "B", 3),
                    new CheckInOperation(3, "A", 1),
                    new CheckOutOperation(3, "B", 5),
                    new GetAverageTimeOperation("A", "B")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(7d / 3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckInOperation(2, "A", 3),
                    new CheckOutOperation(1, "B", 5),
                    new CheckOutOperation(2, "B", 13),
                    new GetAverageTimeOperation("A", "B")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(7d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckOutOperation(1, "B", 11),
                    new GetAverageTimeOperation("A", "B"),
                    new CheckInOperation(2, "A", 5),
                    new CheckOutOperation(2, "B", 25),
                    new GetAverageTimeOperation("A", "B")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(10d),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(15d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckOutOperation(1, "B", 3),
                    new CheckInOperation(2, "C", 1),
                    new CheckOutOperation(2, "D", 6),
                    new GetAverageTimeOperation("A", "B"),
                    new GetAverageTimeOperation("C", "D")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(2d),
                    new GetAverageTimeOperation.Result(5d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "Hub", 1),
                    new CheckOutOperation(1, "North", 4),
                    new CheckInOperation(2, "Hub", 1),
                    new CheckOutOperation(2, "South", 9),
                    new GetAverageTimeOperation("Hub", "North"),
                    new GetAverageTimeOperation("Hub", "South")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(3d),
                    new GetAverageTimeOperation.Result(8d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [new CheckInOperation(1, "Loop", 1), new CheckOutOperation(1, "Loop", 5), new GetAverageTimeOperation("Loop", "Loop")],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetAverageTimeOperation.Result(4d)])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [new CheckInOperation(1, "A", 1), new CheckOutOperation(1, "B", 1000000), new GetAverageTimeOperation("A", "B")],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetAverageTimeOperation.Result(999999d)])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckOutOperation(1, "B", 11),
                    new CheckInOperation(2, "A", 1),
                    new CheckOutOperation(2, "B", 21),
                    new CheckInOperation(3, "A", 1),
                    new CheckOutOperation(3, "B", 31),
                    new CheckInOperation(4, "A", 1),
                    new CheckOutOperation(4, "B", 41),
                    new GetAverageTimeOperation("A", "B")
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
                    new GetAverageTimeOperation.Result(25d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckOutOperation(1, "B", 2),
                    new CheckInOperation(2, "A", 10),
                    new CheckOutOperation(2, "B", 12),
                    new GetAverageTimeOperation("A", "B")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(1.5d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckInOperation(2, "A", 2),
                    new CheckInOperation(3, "A", 3),
                    new CheckOutOperation(2, "B", 4),
                    new GetAverageTimeOperation("A", "B"),
                    new CheckOutOperation(1, "B", 10),
                    new CheckOutOperation(3, "B", 13),
                    new GetAverageTimeOperation("A", "B")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(2d),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(7d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckInOperation(2, "C", 2),
                    new CheckOutOperation(1, "B", 5),
                    new CheckOutOperation(2, "D", 10),
                    new GetAverageTimeOperation("A", "B"),
                    new GetAverageTimeOperation("C", "D")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(4d),
                    new GetAverageTimeOperation.Result(8d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "Station1", 1),
                    new CheckOutOperation(1, "Station2", 6),
                    new GetAverageTimeOperation("Station1", "Station2")
                ],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetAverageTimeOperation.Result(5d)])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckOutOperation(1, "B", 4),
                    new GetAverageTimeOperation("A", "B"),
                    new GetAverageTimeOperation("A", "B")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(3d),
                    new GetAverageTimeOperation.Result(3d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "P", 1),
                    new CheckOutOperation(1, "Q", 4),
                    new CheckInOperation(2, "P", 1),
                    new CheckOutOperation(2, "Q", 5),
                    new CheckInOperation(3, "P", 2),
                    new CheckOutOperation(3, "Q", 6),
                    new GetAverageTimeOperation("P", "Q")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(11d / 3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(1, "A", 1),
                    new CheckOutOperation(1, "B", 3),
                    new CheckInOperation(2, "B", 1),
                    new CheckOutOperation(2, "A", 4),
                    new GetAverageTimeOperation("A", "B"),
                    new GetAverageTimeOperation("B", "A"),
                    new CheckInOperation(3, "A", 1),
                    new CheckOutOperation(3, "B", 7),
                    new GetAverageTimeOperation("A", "B")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(2d),
                    new GetAverageTimeOperation.Result(3d),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(4d)
                ])
        ];

        yield return
        [
            new Scenario<IDesignUndergroundSystem>(
                [
                    new CheckInOperation(7, "A", 1),
                    new CheckOutOperation(7, "B", 3),
                    new CheckInOperation(7, "B", 4),
                    new CheckOutOperation(7, "C", 9),
                    new CheckInOperation(7, "C", 10),
                    new CheckOutOperation(7, "A", 12),
                    new GetAverageTimeOperation("A", "B"),
                    new GetAverageTimeOperation("B", "C"),
                    new GetAverageTimeOperation("C", "A")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetAverageTimeOperation.Result(2d),
                    new GetAverageTimeOperation.Result(5d),
                    new GetAverageTimeOperation.Result(2d)
                ])
        ];
    }

    private sealed class CheckInOperation : IOperation<IDesignUndergroundSystem>
    {
        private readonly int _id;
        private readonly string _stationName;
        private readonly int _time;

        public CheckInOperation(int id, string stationName, int time)
        {
            _id = id;
            _stationName = stationName;
            _time = time;
        }

        public IOperationResult Execute(IDesignUndergroundSystem designUndergroundSystem)
        {
            designUndergroundSystem.CheckIn(_id, _stationName, _time);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class CheckOutOperation : IOperation<IDesignUndergroundSystem>
    {
        private readonly int _id;
        private readonly string _stationName;
        private readonly int _time;

        public CheckOutOperation(int id, string stationName, int time)
        {
            _id = id;
            _stationName = stationName;
            _time = time;
        }

        public IOperationResult Execute(IDesignUndergroundSystem designUndergroundSystem)
        {
            designUndergroundSystem.CheckOut(_id, _stationName, _time);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class GetAverageTimeOperation : IOperation<IDesignUndergroundSystem>
    {
        private readonly string _endStation;
        private readonly string _startStation;

        public GetAverageTimeOperation(string startStation, string endStation)
        {
            _startStation = startStation;
            _endStation = endStation;
        }

        public IOperationResult Execute(IDesignUndergroundSystem designUndergroundSystem)
        {
            var averageTime = designUndergroundSystem.GetAverageTime(_startStation, _endStation);

            return new Result(averageTime);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private const double Tolerance = 1e-5;
            private readonly double _averageTime;

            public Result(double averageTime)
            {
                _averageTime = averageTime;
            }

            public bool Equals(Result? other)
            {
                return other is not null && Math.Abs(_averageTime - other._averageTime) < Tolerance;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return Math.Round(_averageTime, 5).GetHashCode();
            }
        }
    }
}