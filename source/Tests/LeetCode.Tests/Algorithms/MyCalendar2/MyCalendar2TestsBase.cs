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

using LeetCode.Algorithms.MyCalendar2;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.MyCalendar2;

public abstract class MyCalendar2TestsBase<T> where T : IMyCalendar2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void MyCalendar2_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IMyCalendar2> scenario)
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

    private static IEnumerable<IScenario<IMyCalendar2>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(10, 20),
                    new BookOperation(50, 60),
                    new BookOperation(10, 40),
                    new BookOperation(5, 15),
                    new BookOperation(5, 10),
                    new BookOperation(25, 55)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(1, 2)
                ],
                [
                    new BookOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(1, 2),
                    new BookOperation(1, 2),
                    new BookOperation(1, 2)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(1, 5),
                    new BookOperation(1, 5)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(1, 5),
                    new BookOperation(1, 5),
                    new BookOperation(1, 5),
                    new BookOperation(2, 3)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(10, 20),
                    new BookOperation(15, 25),
                    new BookOperation(12, 18)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(0, 1000000000),
                    new BookOperation(0, 1000000000),
                    new BookOperation(0, 1)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(0, 1000000000),
                    new BookOperation(0, 500000000),
                    new BookOperation(500000000, 1000000000),
                    new BookOperation(499999999, 500000001)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(1, 3),
                    new BookOperation(3, 5),
                    new BookOperation(5, 7),
                    new BookOperation(2, 6)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(1, 10),
                    new BookOperation(2, 9),
                    new BookOperation(3, 8),
                    new BookOperation(4, 7)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(5, 10),
                    new BookOperation(1, 5),
                    new BookOperation(10, 15),
                    new BookOperation(4, 11)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(20, 30),
                    new BookOperation(10, 25),
                    new BookOperation(15, 22),
                    new BookOperation(5, 35)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(25, 27),
                    new BookOperation(15, 20),
                    new BookOperation(1, 2),
                    new BookOperation(4, 12),
                    new BookOperation(24, 30),
                    new BookOperation(10, 11),
                    new BookOperation(8, 16),
                    new BookOperation(25, 29),
                    new BookOperation(23, 30),
                    new BookOperation(29, 30),
                    new BookOperation(6, 11),
                    new BookOperation(21, 23)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(27, 30),
                    new BookOperation(10, 12),
                    new BookOperation(11, 18),
                    new BookOperation(25, 30),
                    new BookOperation(14, 16),
                    new BookOperation(24, 28),
                    new BookOperation(22, 27),
                    new BookOperation(3, 4),
                    new BookOperation(18, 22),
                    new BookOperation(26, 30),
                    new BookOperation(15, 19),
                    new BookOperation(16, 17)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(20, 26),
                    new BookOperation(7, 14),
                    new BookOperation(9, 15),
                    new BookOperation(18, 20),
                    new BookOperation(2, 6),
                    new BookOperation(3, 8),
                    new BookOperation(9, 13),
                    new BookOperation(12, 20),
                    new BookOperation(7, 10),
                    new BookOperation(19, 23),
                    new BookOperation(26, 27),
                    new BookOperation(6, 9)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(0, 6),
                    new BookOperation(17, 22),
                    new BookOperation(11, 18),
                    new BookOperation(16, 23),
                    new BookOperation(9, 12),
                    new BookOperation(21, 29),
                    new BookOperation(1, 4),
                    new BookOperation(13, 20),
                    new BookOperation(3, 11),
                    new BookOperation(7, 9),
                    new BookOperation(28, 30),
                    new BookOperation(14, 21)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(25, 27),
                    new BookOperation(16, 23),
                    new BookOperation(15, 20),
                    new BookOperation(22, 29),
                    new BookOperation(2, 6),
                    new BookOperation(23, 28),
                    new BookOperation(14, 22),
                    new BookOperation(23, 26),
                    new BookOperation(0, 1),
                    new BookOperation(17, 19),
                    new BookOperation(8, 14),
                    new BookOperation(6, 11)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(16, 24),
                    new BookOperation(10, 15),
                    new BookOperation(13, 20),
                    new BookOperation(19, 27),
                    new BookOperation(8, 16),
                    new BookOperation(21, 29),
                    new BookOperation(15, 18),
                    new BookOperation(23, 30),
                    new BookOperation(15, 20),
                    new BookOperation(20, 28),
                    new BookOperation(10, 16),
                    new BookOperation(21, 24)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(79, 86),
                    new BookOperation(88, 98),
                    new BookOperation(34, 40),
                    new BookOperation(82, 89),
                    new BookOperation(62, 74),
                    new BookOperation(20, 35),
                    new BookOperation(37, 46),
                    new BookOperation(0, 10),
                    new BookOperation(57, 58),
                    new BookOperation(23, 24),
                    new BookOperation(78, 91),
                    new BookOperation(72, 74),
                    new BookOperation(87, 99),
                    new BookOperation(47, 53),
                    new BookOperation(63, 77),
                    new BookOperation(75, 76),
                    new BookOperation(24, 27),
                    new BookOperation(34, 44),
                    new BookOperation(1, 8),
                    new BookOperation(67, 75),
                    new BookOperation(9, 17),
                    new BookOperation(29, 31),
                    new BookOperation(47, 53),
                    new BookOperation(18, 29),
                    new BookOperation(80, 84),
                    new BookOperation(77, 83),
                    new BookOperation(18, 19),
                    new BookOperation(80, 91),
                    new BookOperation(12, 24),
                    new BookOperation(13, 14),
                    new BookOperation(82, 90),
                    new BookOperation(59, 71),
                    new BookOperation(8, 19),
                    new BookOperation(3, 15),
                    new BookOperation(70, 73),
                    new BookOperation(78, 92),
                    new BookOperation(10, 13),
                    new BookOperation(79, 90),
                    new BookOperation(33, 48),
                    new BookOperation(83, 91),
                    new BookOperation(63, 75),
                    new BookOperation(2, 15),
                    new BookOperation(81, 84),
                    new BookOperation(24, 39),
                    new BookOperation(56, 64),
                    new BookOperation(99, 100),
                    new BookOperation(57, 66),
                    new BookOperation(35, 43),
                    new BookOperation(91, 100),
                    new BookOperation(8, 22),
                    new BookOperation(37, 43),
                    new BookOperation(36, 42),
                    new BookOperation(4, 6),
                    new BookOperation(64, 78),
                    new BookOperation(35, 40),
                    new BookOperation(35, 43),
                    new BookOperation(55, 63),
                    new BookOperation(47, 48),
                    new BookOperation(91, 93),
                    new BookOperation(31, 45)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(619, 660),
                    new BookOperation(244, 279),
                    new BookOperation(763, 766),
                    new BookOperation(756, 768),
                    new BookOperation(344, 368),
                    new BookOperation(32, 36),
                    new BookOperation(974, 1000),
                    new BookOperation(783, 832),
                    new BookOperation(972, 986),
                    new BookOperation(717, 745),
                    new BookOperation(351, 356),
                    new BookOperation(161, 208),
                    new BookOperation(692, 700),
                    new BookOperation(409, 445),
                    new BookOperation(138, 168),
                    new BookOperation(760, 792),
                    new BookOperation(654, 659),
                    new BookOperation(131, 136),
                    new BookOperation(358, 392),
                    new BookOperation(31, 43),
                    new BookOperation(538, 584),
                    new BookOperation(153, 165),
                    new BookOperation(288, 336),
                    new BookOperation(154, 187),
                    new BookOperation(582, 607),
                    new BookOperation(815, 830),
                    new BookOperation(967, 982),
                    new BookOperation(712, 749),
                    new BookOperation(732, 741),
                    new BookOperation(429, 474),
                    new BookOperation(167, 216),
                    new BookOperation(324, 340),
                    new BookOperation(574, 611),
                    new BookOperation(4, 41),
                    new BookOperation(395, 408),
                    new BookOperation(778, 799),
                    new BookOperation(875, 900),
                    new BookOperation(538, 567),
                    new BookOperation(9, 35),
                    new BookOperation(865, 899),
                    new BookOperation(564, 607),
                    new BookOperation(139, 185),
                    new BookOperation(239, 281),
                    new BookOperation(556, 604),
                    new BookOperation(381, 399),
                    new BookOperation(682, 694),
                    new BookOperation(995, 1000),
                    new BookOperation(168, 213),
                    new BookOperation(640, 649),
                    new BookOperation(393, 398),
                    new BookOperation(62, 63),
                    new BookOperation(40, 71),
                    new BookOperation(777, 781),
                    new BookOperation(117, 159),
                    new BookOperation(728, 763),
                    new BookOperation(102, 146),
                    new BookOperation(376, 415),
                    new BookOperation(32, 36),
                    new BookOperation(555, 570),
                    new BookOperation(805, 832),
                    new BookOperation(230, 279),
                    new BookOperation(578, 623),
                    new BookOperation(944, 963),
                    new BookOperation(94, 125),
                    new BookOperation(79, 126),
                    new BookOperation(587, 591),
                    new BookOperation(172, 215),
                    new BookOperation(448, 456),
                    new BookOperation(981, 989),
                    new BookOperation(718, 730),
                    new BookOperation(51, 95),
                    new BookOperation(941, 943),
                    new BookOperation(768, 812),
                    new BookOperation(746, 774),
                    new BookOperation(666, 712),
                    new BookOperation(293, 310),
                    new BookOperation(454, 469),
                    new BookOperation(206, 248),
                    new BookOperation(797, 832),
                    new BookOperation(806, 848),
                    new BookOperation(219, 237),
                    new BookOperation(606, 607),
                    new BookOperation(261, 295),
                    new BookOperation(809, 856),
                    new BookOperation(762, 808),
                    new BookOperation(892, 936),
                    new BookOperation(338, 388),
                    new BookOperation(529, 535),
                    new BookOperation(598, 637),
                    new BookOperation(660, 663),
                    new BookOperation(370, 394),
                    new BookOperation(707, 715),
                    new BookOperation(231, 280),
                    new BookOperation(28, 52),
                    new BookOperation(943, 988),
                    new BookOperation(970, 992),
                    new BookOperation(446, 490),
                    new BookOperation(852, 856),
                    new BookOperation(352, 361),
                    new BookOperation(31, 32)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true)
                ])
        ];
    }

    private sealed class BookOperation : IOperation<IMyCalendar2>
    {
        private readonly int _end;
        private readonly int _start;

        public BookOperation(int start, int end)
        {
            _start = start;
            _end = end;
        }

        public IOperationResult Execute(IMyCalendar2 solution)
        {
            var result = solution.Book(_start, _end);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _value;

            public Result(bool value)
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