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

using LeetCode.Algorithms.MyCalendar3;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.MyCalendar3;

public abstract class MyCalendar3TestsBase<T> where T : IMyCalendar3, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void MyCalendar3_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IMyCalendar3> scenario)
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

    private static IEnumerable<IScenario<IMyCalendar3>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(10, 20),
                    new BookOperation(50, 60),
                    new BookOperation(10, 40),
                    new BookOperation(5, 15),
                    new BookOperation(5, 10),
                    new BookOperation(25, 55)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3)
                ])
        ];

        yield return [new Scenario<IMyCalendar3>([new BookOperation(1, 2)], [new BookOperation.Result(1)])];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [new BookOperation(1, 2), new BookOperation(2, 3), new BookOperation(3, 4)],
                [new BookOperation.Result(1), new BookOperation.Result(1), new BookOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [new BookOperation(5, 10), new BookOperation(5, 10), new BookOperation(5, 10)],
                [new BookOperation.Result(1), new BookOperation.Result(2), new BookOperation.Result(3)])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [new BookOperation(1, 10), new BookOperation(2, 9), new BookOperation(3, 8)],
                [new BookOperation.Result(1), new BookOperation.Result(2), new BookOperation.Result(3)])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(1, 2)
                ],
                [
                    new BookOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(1, 2),
                    new BookOperation(1, 2),
                    new BookOperation(1, 2)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(1, 5),
                    new BookOperation(1, 5)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(1, 5),
                    new BookOperation(1, 5),
                    new BookOperation(1, 5),
                    new BookOperation(2, 3)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(4)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(10, 20),
                    new BookOperation(15, 25),
                    new BookOperation(12, 18)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(0, 1000000000),
                    new BookOperation(0, 1000000000),
                    new BookOperation(0, 1)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(0, 1000000000),
                    new BookOperation(0, 500000000),
                    new BookOperation(500000000, 1000000000),
                    new BookOperation(499999999, 500000001)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(1, 3),
                    new BookOperation(3, 5),
                    new BookOperation(5, 7),
                    new BookOperation(2, 6)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(1, 10),
                    new BookOperation(2, 9),
                    new BookOperation(3, 8),
                    new BookOperation(4, 7)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(4)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(5, 10),
                    new BookOperation(1, 5),
                    new BookOperation(10, 15),
                    new BookOperation(4, 11)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(20, 30),
                    new BookOperation(10, 25),
                    new BookOperation(15, 22),
                    new BookOperation(5, 35)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(4)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(10, 12),
                    new BookOperation(15, 16),
                    new BookOperation(14, 19),
                    new BookOperation(2, 7),
                    new BookOperation(7, 10),
                    new BookOperation(4, 11),
                    new BookOperation(17, 20),
                    new BookOperation(7, 14),
                    new BookOperation(19, 26),
                    new BookOperation(18, 26),
                    new BookOperation(29, 30),
                    new BookOperation(8, 11)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3),
                    new BookOperation.Result(4)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(9, 10),
                    new BookOperation(6, 14),
                    new BookOperation(3, 6),
                    new BookOperation(18, 20),
                    new BookOperation(29, 30),
                    new BookOperation(16, 19),
                    new BookOperation(3, 6),
                    new BookOperation(18, 25),
                    new BookOperation(15, 23),
                    new BookOperation(27, 30),
                    new BookOperation(6, 13),
                    new BookOperation(4, 12)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(27, 28),
                    new BookOperation(10, 17),
                    new BookOperation(8, 14),
                    new BookOperation(4, 9),
                    new BookOperation(11, 17),
                    new BookOperation(7, 8),
                    new BookOperation(24, 29),
                    new BookOperation(5, 7),
                    new BookOperation(13, 17),
                    new BookOperation(29, 30),
                    new BookOperation(6, 13),
                    new BookOperation(13, 16)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(5)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(24, 27),
                    new BookOperation(16, 17),
                    new BookOperation(16, 24),
                    new BookOperation(29, 30),
                    new BookOperation(28, 30),
                    new BookOperation(26, 30),
                    new BookOperation(27, 30),
                    new BookOperation(20, 22),
                    new BookOperation(8, 11),
                    new BookOperation(1, 3),
                    new BookOperation(18, 21),
                    new BookOperation(26, 28)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(176, 182),
                    new BookOperation(22, 30),
                    new BookOperation(55, 78),
                    new BookOperation(86, 97),
                    new BookOperation(186, 200),
                    new BookOperation(44, 56),
                    new BookOperation(57, 66),
                    new BookOperation(122, 152),
                    new BookOperation(159, 167),
                    new BookOperation(185, 200),
                    new BookOperation(34, 64),
                    new BookOperation(50, 87),
                    new BookOperation(95, 105),
                    new BookOperation(85, 102),
                    new BookOperation(17, 35),
                    new BookOperation(192, 193),
                    new BookOperation(15, 17),
                    new BookOperation(122, 152),
                    new BookOperation(81, 85),
                    new BookOperation(2, 20),
                    new BookOperation(184, 191),
                    new BookOperation(98, 138),
                    new BookOperation(86, 93),
                    new BookOperation(188, 200),
                    new BookOperation(36, 46),
                    new BookOperation(94, 125),
                    new BookOperation(190, 200),
                    new BookOperation(4, 39),
                    new BookOperation(38, 45),
                    new BookOperation(114, 138),
                    new BookOperation(3, 12),
                    new BookOperation(173, 200),
                    new BookOperation(122, 139),
                    new BookOperation(18, 49),
                    new BookOperation(30, 56),
                    new BookOperation(180, 193),
                    new BookOperation(139, 150),
                    new BookOperation(112, 134),
                    new BookOperation(65, 100),
                    new BookOperation(198, 200),
                    new BookOperation(75, 110),
                    new BookOperation(176, 194),
                    new BookOperation(115, 151),
                    new BookOperation(183, 186),
                    new BookOperation(128, 144),
                    new BookOperation(169, 200),
                    new BookOperation(0, 34),
                    new BookOperation(126, 162),
                    new BookOperation(137, 154),
                    new BookOperation(43, 46),
                    new BookOperation(82, 83),
                    new BookOperation(53, 90),
                    new BookOperation(77, 90),
                    new BookOperation(39, 57),
                    new BookOperation(14, 32),
                    new BookOperation(186, 200),
                    new BookOperation(179, 200),
                    new BookOperation(55, 66),
                    new BookOperation(152, 153),
                    new BookOperation(23, 46),
                    new BookOperation(147, 159),
                    new BookOperation(89, 101),
                    new BookOperation(122, 137),
                    new BookOperation(121, 146),
                    new BookOperation(140, 180),
                    new BookOperation(91, 99),
                    new BookOperation(167, 173),
                    new BookOperation(110, 114),
                    new BookOperation(149, 189),
                    new BookOperation(52, 91),
                    new BookOperation(112, 130),
                    new BookOperation(56, 60),
                    new BookOperation(123, 156),
                    new BookOperation(134, 151),
                    new BookOperation(133, 151),
                    new BookOperation(163, 187),
                    new BookOperation(76, 104),
                    new BookOperation(191, 200),
                    new BookOperation(24, 59),
                    new BookOperation(106, 117)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(4),
                    new BookOperation.Result(5),
                    new BookOperation.Result(5),
                    new BookOperation.Result(5),
                    new BookOperation.Result(5),
                    new BookOperation.Result(5),
                    new BookOperation.Result(6),
                    new BookOperation.Result(6),
                    new BookOperation.Result(6),
                    new BookOperation.Result(6),
                    new BookOperation.Result(7),
                    new BookOperation.Result(7),
                    new BookOperation.Result(7),
                    new BookOperation.Result(7),
                    new BookOperation.Result(7),
                    new BookOperation.Result(7),
                    new BookOperation.Result(8),
                    new BookOperation.Result(8),
                    new BookOperation.Result(8),
                    new BookOperation.Result(8),
                    new BookOperation.Result(9),
                    new BookOperation.Result(9),
                    new BookOperation.Result(9),
                    new BookOperation.Result(9),
                    new BookOperation.Result(9),
                    new BookOperation.Result(9),
                    new BookOperation.Result(9),
                    new BookOperation.Result(9),
                    new BookOperation.Result(9),
                    new BookOperation.Result(9),
                    new BookOperation.Result(10),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(11),
                    new BookOperation.Result(12),
                    new BookOperation.Result(12),
                    new BookOperation.Result(13),
                    new BookOperation.Result(13),
                    new BookOperation.Result(13),
                    new BookOperation.Result(13),
                    new BookOperation.Result(13),
                    new BookOperation.Result(13),
                    new BookOperation.Result(13),
                    new BookOperation.Result(13)
                ])
        ];
    }

    private sealed class BookOperation : IOperation<IMyCalendar3>
    {
        private readonly int _endTime;
        private readonly int _startTime;

        public BookOperation(int startTime, int endTime)
        {
            _startTime = startTime;
            _endTime = endTime;
        }

        public IOperationResult Execute(IMyCalendar3 myCalendar3)
        {
            var maxBooking = myCalendar3.Book(_startTime, _endTime);

            return new Result(maxBooking);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _maxBooking;

            public Result(int maxBooking)
            {
                _maxBooking = maxBooking;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _maxBooking == other._maxBooking;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_maxBooking);
            }
        }
    }
}