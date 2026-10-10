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

using LeetCode.Algorithms.ImplementRouter;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.ImplementRouter;

public abstract class ImplementRouterTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void ImplementRouter_WithMixedOperations_ProcessesOperationsAccordingToSpecification(RouterScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.MemoryLimit);

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

    protected abstract IImplementRouter GetSolution(int memoryLimit);

    private static IEnumerable<RouterScenario[]> GetScenarios()
    {
        yield return
        [
            new RouterScenario(
                3,
                [
                    new AddPacketOperation(1, 4, 90),
                    new AddPacketOperation(2, 5, 90),
                    new AddPacketOperation(1, 4, 90),
                    new AddPacketOperation(3, 5, 95),
                    new AddPacketOperation(4, 5, 105),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(5, 2, 110),
                    new GetCountOperation(5, 100, 110)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([2, 5, 90]),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1)
                ])
        ];

        yield return
        [
            new RouterScenario(
                4,
                [new AddPacketOperation(4, 2, 1), new AddPacketOperation(3, 2, 1), new GetCountOperation(2, 1, 1)],
                [new AddPacketOperation.Result(true), new AddPacketOperation.Result(true), new GetCountOperation.Result(2)])
        ];

        yield return
        [
            new RouterScenario(
                5,
                [new AddPacketOperation(1, 2, 10), new AddPacketOperation(1, 2, 10), new GetCountOperation(2, 10, 10)],
                [new AddPacketOperation.Result(true), new AddPacketOperation.Result(false), new GetCountOperation.Result(1)])
        ];

        yield return
        [
            new RouterScenario(
                3,
                [new AddPacketOperation(1, 2, 10), new ForwardPacketOperation(), new ForwardPacketOperation()],
                [new AddPacketOperation.Result(true), new ForwardPacketOperation.Result([1, 2, 10]), new ForwardPacketOperation.Result([])])
        ];

        yield return
        [
            new RouterScenario(
                5,
                [new AddPacketOperation(1, 2, 10), new GetCountOperation(99, 0, 100)],
                [new AddPacketOperation.Result(true), new GetCountOperation.Result(0)])
        ];

        yield return
        [
            new RouterScenario(
                5,
                [new AddPacketOperation(1, 2, 10), new ForwardPacketOperation(), new GetCountOperation(2, 0, 100)],
                [new AddPacketOperation.Result(true), new ForwardPacketOperation.Result([1, 2, 10]), new GetCountOperation.Result(0)])
        ];

        yield return
        [
            new RouterScenario(
                5,
                [new AddPacketOperation(1, 2, 10), new GetCountOperation(2, 20, 30)],
                [new AddPacketOperation.Result(true), new GetCountOperation.Result(0)])
        ];

        yield return
        [
            new RouterScenario(
                5,
                [new AddPacketOperation(1, 2, 7), new GetCountOperation(2, 10, 5)],
                [new AddPacketOperation.Result(true), new GetCountOperation.Result(0)])
        ];

        yield return
        [
            new RouterScenario(
                1,
                [
                    new AddPacketOperation(1, 1, 1),
                    new AddPacketOperation(2, 1, 2),
                    new GetCountOperation(1, 1, 2),
                    new ForwardPacketOperation(),
                    new ForwardPacketOperation()
                ],
                [
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new ForwardPacketOperation.Result([2, 1, 2]),
                    new ForwardPacketOperation.Result([])
                ])
        ];

        yield return
        [
            new RouterScenario(
                2,
                [
                    new AddPacketOperation(1, 2, 5),
                    new AddPacketOperation(1, 3, 5),
                    new AddPacketOperation(1, 4, 6),
                    new GetCountOperation(2, 5, 6),
                    new GetCountOperation(3, 5, 6),
                    new GetCountOperation(4, 6, 6)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new GetCountOperation.Result(1),
                    new GetCountOperation.Result(1)
                ])
        ];

        yield return
        [
            new RouterScenario(
                3,
                [
                    new ForwardPacketOperation(),
                    new GetCountOperation(1, 0, 10),
                    new AddPacketOperation(9, 9, 9),
                    new GetCountOperation(9, 9, 9),
                    new GetCountOperation(9, 10, 20)
                ],
                [
                    new ForwardPacketOperation.Result([]),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new GetCountOperation.Result(0)
                ])
        ];

        yield return
        [
            new RouterScenario(
                2,
                [
                    new AddPacketOperation(1, 1, 1),
                    new AddPacketOperation(1, 1, 1),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(1, 1, 1),
                    new GetCountOperation(1, 1, 1)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(false),
                    new ForwardPacketOperation.Result([1, 1, 1]),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1)
                ])
        ];

        yield return
        [
            new RouterScenario(
                1,
                [
                    new AddPacketOperation(1, 1, 10),
                    new AddPacketOperation(1, 1, 10),
                    new AddPacketOperation(2, 1, 10),
                    new GetCountOperation(1, 10, 10)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1)
                ])
        ];

        yield return
        [
            new RouterScenario(
                2,
                [
                    new AddPacketOperation(2, 2, 1),
                    new GetCountOperation(1, 1, 3),
                    new AddPacketOperation(1, 2, 1),
                    new GetCountOperation(1, 1, 1),
                    new GetCountOperation(1, 1, 1),
                    new AddPacketOperation(2, 2, 1),
                    new AddPacketOperation(1, 2, 4),
                    new AddPacketOperation(1, 1, 4),
                    new GetCountOperation(1, 1, 4),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(1, 2, 5),
                    new GetCountOperation(1, 2, 2)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new ForwardPacketOperation.Result([1, 2, 4]),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0)
                ])
        ];

        yield return
        [
            new RouterScenario(
                3,
                [
                    new AddPacketOperation(3, 3, 1),
                    new GetCountOperation(3, 1, 1),
                    new AddPacketOperation(1, 2, 1),
                    new GetCountOperation(2, 1, 2),
                    new GetCountOperation(2, 1, 2),
                    new AddPacketOperation(1, 3, 1),
                    new GetCountOperation(2, 1, 1),
                    new AddPacketOperation(3, 1, 1),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(1, 1, 1),
                    new ForwardPacketOperation(),
                    new ForwardPacketOperation(),
                    new GetCountOperation(3, 1, 2),
                    new GetCountOperation(1, 1, 1),
                    new AddPacketOperation(2, 2, 1)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([1, 2, 1]),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([1, 3, 1]),
                    new ForwardPacketOperation.Result([3, 1, 1]),
                    new GetCountOperation.Result(0),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true)
                ])
        ];

        yield return
        [
            new RouterScenario(
                3,
                [
                    new AddPacketOperation(4, 1, 2),
                    new GetCountOperation(2, 1, 3),
                    new AddPacketOperation(2, 1, 2),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(1, 2, 5),
                    new AddPacketOperation(1, 2, 7),
                    new AddPacketOperation(2, 1, 9),
                    new GetCountOperation(2, 8, 8),
                    new AddPacketOperation(4, 1, 9),
                    new GetCountOperation(2, 6, 7),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(4, 2, 9),
                    new AddPacketOperation(2, 1, 9),
                    new AddPacketOperation(3, 2, 9),
                    new ForwardPacketOperation(),
                    new GetCountOperation(2, 7, 9),
                    new GetCountOperation(1, 3, 5),
                    new AddPacketOperation(4, 1, 9),
                    new AddPacketOperation(2, 2, 11),
                    new AddPacketOperation(2, 1, 14)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([4, 1, 2]),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new ForwardPacketOperation.Result([1, 2, 7]),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([4, 1, 9]),
                    new GetCountOperation.Result(2),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true)
                ])
        ];

        yield return
        [
            new RouterScenario(
                4,
                [
                    new AddPacketOperation(1, 3, 1),
                    new GetCountOperation(3, 1, 3),
                    new AddPacketOperation(1, 1, 1),
                    new AddPacketOperation(2, 3, 1),
                    new AddPacketOperation(2, 3, 1),
                    new ForwardPacketOperation(),
                    new GetCountOperation(1, 1, 2),
                    new AddPacketOperation(2, 3, 1),
                    new GetCountOperation(1, 1, 3),
                    new AddPacketOperation(3, 2, 3),
                    new AddPacketOperation(3, 1, 3),
                    new AddPacketOperation(1, 2, 3),
                    new AddPacketOperation(2, 1, 3),
                    new GetCountOperation(3, 3, 3),
                    new GetCountOperation(3, 2, 2),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(2, 2, 3),
                    new AddPacketOperation(1, 1, 6),
                    new AddPacketOperation(2, 3, 6),
                    new AddPacketOperation(2, 2, 6)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(false),
                    new ForwardPacketOperation.Result([1, 3, 1]),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(false),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new GetCountOperation.Result(0),
                    new ForwardPacketOperation.Result([3, 2, 3]),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true)
                ])
        ];

        yield return
        [
            new RouterScenario(
                5,
                [
                    new AddPacketOperation(1, 4, 1),
                    new AddPacketOperation(4, 3, 2),
                    new AddPacketOperation(4, 3, 2),
                    new ForwardPacketOperation(),
                    new GetCountOperation(3, 1, 2),
                    new AddPacketOperation(2, 1, 2),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(4, 1, 5),
                    new GetCountOperation(4, 2, 7),
                    new AddPacketOperation(3, 1, 6),
                    new GetCountOperation(3, 3, 7),
                    new GetCountOperation(2, 2, 7),
                    new AddPacketOperation(4, 2, 6),
                    new GetCountOperation(4, 4, 7),
                    new AddPacketOperation(2, 4, 6),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(2, 1, 6),
                    new AddPacketOperation(3, 1, 6),
                    new AddPacketOperation(4, 4, 6),
                    new GetCountOperation(2, 2, 2),
                    new AddPacketOperation(3, 1, 9),
                    new AddPacketOperation(1, 3, 12),
                    new AddPacketOperation(2, 4, 13),
                    new GetCountOperation(1, 1, 11),
                    new AddPacketOperation(2, 2, 13)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(false),
                    new ForwardPacketOperation.Result([1, 4, 1]),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([4, 3, 2]),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([2, 1, 2]),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(2),
                    new AddPacketOperation.Result(true)
                ])
        ];

        yield return
        [
            new RouterScenario(
                2,
                [
                    new AddPacketOperation(2, 2, 1),
                    new ForwardPacketOperation(),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(2, 1, 3),
                    new GetCountOperation(1, 1, 1),
                    new AddPacketOperation(1, 2, 3),
                    new AddPacketOperation(2, 2, 3),
                    new ForwardPacketOperation(),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(2, 2, 5),
                    new AddPacketOperation(1, 2, 8),
                    new GetCountOperation(1, 4, 8),
                    new GetCountOperation(2, 3, 3),
                    new AddPacketOperation(1, 2, 11),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(1, 2, 11),
                    new AddPacketOperation(2, 1, 11),
                    new GetCountOperation(2, 3, 12),
                    new ForwardPacketOperation(),
                    new GetCountOperation(1, 11, 13),
                    new AddPacketOperation(2, 1, 11),
                    new AddPacketOperation(2, 2, 11),
                    new GetCountOperation(1, 6, 7),
                    new AddPacketOperation(1, 1, 13),
                    new GetCountOperation(1, 10, 10)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([2, 2, 1]),
                    new ForwardPacketOperation.Result([]),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([1, 2, 3]),
                    new ForwardPacketOperation.Result([2, 2, 3]),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([1, 2, 8]),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new ForwardPacketOperation.Result([1, 2, 11]),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0)
                ])
        ];

        yield return
        [
            new RouterScenario(
                6,
                [
                    new GetCountOperation(5, 1, 3),
                    new AddPacketOperation(3, 1, 1),
                    new AddPacketOperation(5, 4, 1),
                    new GetCountOperation(2, 1, 3),
                    new AddPacketOperation(2, 4, 4),
                    new AddPacketOperation(2, 1, 7),
                    new GetCountOperation(4, 3, 7),
                    new GetCountOperation(2, 6, 7),
                    new GetCountOperation(4, 4, 5),
                    new AddPacketOperation(5, 3, 7),
                    new ForwardPacketOperation(),
                    new GetCountOperation(2, 2, 9),
                    new GetCountOperation(1, 5, 8),
                    new AddPacketOperation(2, 4, 7),
                    new AddPacketOperation(5, 1, 10),
                    new GetCountOperation(3, 2, 7),
                    new GetCountOperation(2, 8, 8),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(3, 2, 10),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(3, 1, 10),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(2, 4, 11),
                    new GetCountOperation(1, 8, 9),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(3, 1, 11),
                    new AddPacketOperation(3, 4, 11),
                    new AddPacketOperation(5, 5, 11),
                    new AddPacketOperation(5, 4, 11),
                    new AddPacketOperation(5, 3, 11)
                ],
                [
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new GetCountOperation.Result(0),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([3, 1, 1]),
                    new GetCountOperation.Result(0),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new GetCountOperation.Result(0),
                    new ForwardPacketOperation.Result([5, 4, 1]),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([2, 4, 4]),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([2, 1, 7]),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new ForwardPacketOperation.Result([5, 3, 7]),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true)
                ])
        ];

        yield return
        [
            new RouterScenario(
                1,
                [
                    new AddPacketOperation(1, 2, 3),
                    new AddPacketOperation(3, 3, 6),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(1, 3, 9),
                    new GetCountOperation(2, 2, 7),
                    new AddPacketOperation(2, 3, 11),
                    new AddPacketOperation(2, 1, 11),
                    new AddPacketOperation(1, 1, 12),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(3, 2, 12),
                    new AddPacketOperation(3, 1, 13),
                    new AddPacketOperation(1, 1, 13),
                    new AddPacketOperation(3, 3, 13),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(3, 2, 15)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([3, 3, 6]),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([1, 1, 12]),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([3, 3, 13]),
                    new AddPacketOperation.Result(true)
                ])
        ];

        yield return
        [
            new RouterScenario(
                10,
                [
                    new GetCountOperation(5, 1, 1),
                    new AddPacketOperation(5, 4, 1),
                    new AddPacketOperation(1, 3, 1),
                    new GetCountOperation(2, 1, 3),
                    new AddPacketOperation(6, 3, 4),
                    new AddPacketOperation(1, 1, 4),
                    new AddPacketOperation(2, 6, 6),
                    new AddPacketOperation(3, 6, 6),
                    new ForwardPacketOperation(),
                    new GetCountOperation(6, 1, 6),
                    new GetCountOperation(6, 4, 8),
                    new AddPacketOperation(2, 5, 6),
                    new GetCountOperation(1, 6, 6),
                    new AddPacketOperation(4, 2, 8),
                    new GetCountOperation(5, 1, 7),
                    new AddPacketOperation(2, 3, 9),
                    new AddPacketOperation(6, 4, 9),
                    new AddPacketOperation(2, 3, 12),
                    new GetCountOperation(3, 3, 14),
                    new AddPacketOperation(3, 6, 13),
                    new GetCountOperation(1, 12, 12),
                    new AddPacketOperation(3, 5, 13),
                    new AddPacketOperation(2, 6, 13),
                    new AddPacketOperation(3, 3, 13),
                    new AddPacketOperation(6, 2, 13),
                    new GetCountOperation(2, 1, 15),
                    new GetCountOperation(6, 4, 11),
                    new GetCountOperation(2, 9, 10),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(3, 2, 13),
                    new AddPacketOperation(1, 2, 13),
                    new AddPacketOperation(1, 1, 13),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(3, 6, 13),
                    new AddPacketOperation(4, 4, 13),
                    new GetCountOperation(3, 9, 9),
                    new AddPacketOperation(3, 4, 13),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(3, 2, 13),
                    new AddPacketOperation(6, 3, 13)
                ],
                [
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([5, 4, 1]),
                    new GetCountOperation.Result(2),
                    new GetCountOperation.Result(2),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(3),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(2),
                    new GetCountOperation.Result(0),
                    new GetCountOperation.Result(0),
                    new ForwardPacketOperation.Result([2, 5, 6]),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([6, 4, 9]),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(0),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([3, 6, 13]),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true)
                ])
        ];

        yield return
        [
            new RouterScenario(
                10,
                [
                    new AddPacketOperation(1, 2, 1),
                    new AddPacketOperation(1, 2, 2),
                    new AddPacketOperation(1, 2, 3),
                    new AddPacketOperation(1, 2, 4),
                    new AddPacketOperation(1, 2, 5),
                    new AddPacketOperation(1, 2, 6),
                    new AddPacketOperation(1, 2, 7),
                    new AddPacketOperation(1, 2, 8),
                    new AddPacketOperation(1, 2, 9),
                    new AddPacketOperation(1, 2, 10),
                    new AddPacketOperation(1, 2, 11),
                    new AddPacketOperation(1, 2, 12),
                    new AddPacketOperation(1, 2, 13),
                    new AddPacketOperation(1, 2, 14),
                    new AddPacketOperation(1, 2, 15),
                    new AddPacketOperation(1, 2, 16),
                    new AddPacketOperation(1, 2, 17),
                    new AddPacketOperation(1, 2, 18),
                    new AddPacketOperation(1, 2, 19),
                    new AddPacketOperation(1, 2, 20),
                    new GetCountOperation(2, 5, 15),
                    new ForwardPacketOperation(),
                    new GetCountOperation(2, 1, 20)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(5),
                    new ForwardPacketOperation.Result([1, 2, 11]),
                    new GetCountOperation.Result(9)
                ])
        ];
    }

    public sealed class RouterScenario : IScenario<IImplementRouter>
    {
        public RouterScenario(int memoryLimit, IOperation<IImplementRouter>[] operations, IOperationResult[] operationResults)
        {
            MemoryLimit = memoryLimit;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int MemoryLimit { get; }

        public IOperation<IImplementRouter>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class AddPacketOperation : IOperation<IImplementRouter>
    {
        private readonly int _destination;
        private readonly int _source;
        private readonly int _timestamp;

        public AddPacketOperation(int source, int destination, int timestamp)
        {
            _source = source;
            _destination = destination;
            _timestamp = timestamp;
        }

        public IOperationResult Execute(IImplementRouter implementRouter)
        {
            var result = implementRouter.AddPacket(_source, _destination, _timestamp);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _added;

            public Result(bool added)
            {
                _added = added;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _added == other._added;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_added);
            }
        }
    }

    private sealed class ForwardPacketOperation : IOperation<IImplementRouter>
    {
        public IOperationResult Execute(IImplementRouter implementRouter)
        {
            var packet = implementRouter.ForwardPacket();

            return new Result(packet);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int[] _packet;

            public Result(int[] packet)
            {
                _packet = new int[packet.Length];

                Array.Copy(packet, _packet, packet.Length);
            }

            public bool Equals(Result? other)
            {
                if (other is null || _packet.Length != other._packet.Length)
                {
                    return false;
                }

                for (var i = 0; i < _packet.Length; i++)
                {
                    if (_packet[i] != other._packet[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                var hashCode = new HashCode();

                for (var i = 0; i < _packet.Length; i++)
                {
                    var value = _packet[i];

                    hashCode.Add(value);
                }

                return hashCode.ToHashCode();
            }
        }
    }

    private sealed class GetCountOperation : IOperation<IImplementRouter>
    {
        private readonly int _destination;
        private readonly int _endTime;
        private readonly int _startTime;

        public GetCountOperation(int destination, int startTime, int endTime)
        {
            _destination = destination;
            _startTime = startTime;
            _endTime = endTime;
        }

        public IOperationResult Execute(IImplementRouter implementRouter)
        {
            var count = implementRouter.GetCount(_destination, _startTime, _endTime);

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