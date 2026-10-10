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

using LeetCode.Algorithms.ImplementStackUsingQueues;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.ImplementStackUsingQueues;

public abstract class ImplementStackUsingQueuesTestsBase<T> where T : IImplementStackUsingQueues, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void ImplementStackUsingQueues_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        IScenario<IImplementStackUsingQueues> scenario)
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

    private static IEnumerable<IScenario<IImplementStackUsingQueues>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [new PushOperation(1), new PushOperation(2), new PushOperation(3), new TopOperation(), new PopOperation(), new TopOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(3),
                    new PopOperation.Result(3),
                    new TopOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(5),
                    new PushOperation(10),
                    new PushOperation(15),
                    new PushOperation(20),
                    new TopOperation(),
                    new PopOperation(),
                    new TopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(20),
                    new PopOperation.Result(20),
                    new TopOperation.Result(15)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [new PushOperation(42), new TopOperation(), new PopOperation()],
                [VoidOperationResult.Instance, new TopOperation.Result(42), new PopOperation.Result(42)])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [new PushOperation(0), new EmptyOperation()],
                [VoidOperationResult.Instance, new EmptyOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(1),
                    new PushOperation(2),
                    new PushOperation(3),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(3),
                    new PopOperation.Result(2),
                    new PopOperation.Result(1),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(5),
                    new PushOperation(10),
                    new PushOperation(15),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(15),
                    new PopOperation.Result(10),
                    new PopOperation.Result(5),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return [new Scenario<IImplementStackUsingQueues>([new EmptyOperation()], [new EmptyOperation.Result(true)])];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(15),
                    new TopOperation(),
                    new PushOperation(6),
                    new PushOperation(15)
                ],
                [
                    VoidOperationResult.Instance,
                    new TopOperation.Result(15),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(92),
                    new TopOperation(),
                    new PushOperation(95),
                    new PushOperation(8),
                    new PushOperation(69)
                ],
                [
                    VoidOperationResult.Instance,
                    new TopOperation.Result(92),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(68),
                    new PushOperation(76),
                    new PushOperation(3),
                    new TopOperation(),
                    new EmptyOperation(),
                    new PushOperation(27)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(3),
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(47),
                    new PopOperation(),
                    new PushOperation(93),
                    new PushOperation(75),
                    new TopOperation(),
                    new PushOperation(7),
                    new EmptyOperation(),
                    new PushOperation(27)
                ],
                [
                    VoidOperationResult.Instance,
                    new PopOperation.Result(47),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(75),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(49),
                    new PushOperation(95),
                    new PopOperation(),
                    new PushOperation(28),
                    new PushOperation(56),
                    new TopOperation(),
                    new PushOperation(83),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(95),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(56),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(34),
                    new PushOperation(43),
                    new PopOperation(),
                    new PushOperation(84),
                    new EmptyOperation(),
                    new EmptyOperation(),
                    new EmptyOperation(),
                    new EmptyOperation(),
                    new TopOperation(),
                    new PushOperation(23)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(43),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    new EmptyOperation.Result(false),
                    new EmptyOperation.Result(false),
                    new EmptyOperation.Result(false),
                    new TopOperation.Result(84),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(70),
                    new EmptyOperation(),
                    new PushOperation(23),
                    new PushOperation(77),
                    new PushOperation(13),
                    new TopOperation(),
                    new PushOperation(40),
                    new PopOperation(),
                    new EmptyOperation(),
                    new PushOperation(59),
                    new PushOperation(43),
                    new PushOperation(7)
                ],
                [
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(13),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(40),
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(16),
                    new PushOperation(82),
                    new PushOperation(25),
                    new PushOperation(21),
                    new TopOperation(),
                    new EmptyOperation(),
                    new PushOperation(64),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation(),
                    new EmptyOperation(),
                    new PushOperation(76)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(21),
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(64),
                    new PopOperation.Result(21),
                    new EmptyOperation.Result(false),
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(15),
                    new PushOperation(93),
                    new PopOperation(),
                    new PushOperation(99),
                    new PushOperation(63),
                    new TopOperation(),
                    new EmptyOperation(),
                    new PushOperation(2),
                    new PushOperation(75),
                    new PushOperation(23),
                    new EmptyOperation(),
                    new PushOperation(73),
                    new EmptyOperation(),
                    new PushOperation(79),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(93),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(63),
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(39),
                    new TopOperation(),
                    new PopOperation(),
                    new PushOperation(66),
                    new PopOperation(),
                    new EmptyOperation(),
                    new PushOperation(68),
                    new PushOperation(79),
                    new PushOperation(92),
                    new EmptyOperation(),
                    new PushOperation(48),
                    new PushOperation(45),
                    new TopOperation(),
                    new EmptyOperation(),
                    new TopOperation(),
                    new PopOperation(),
                    new PushOperation(86),
                    new PushOperation(55),
                    new PushOperation(32),
                    new PushOperation(40)
                ],
                [
                    VoidOperationResult.Instance,
                    new TopOperation.Result(39),
                    new PopOperation.Result(39),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(66),
                    new EmptyOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(45),
                    new EmptyOperation.Result(false),
                    new TopOperation.Result(45),
                    new PopOperation.Result(45),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(92),
                    new PushOperation(76),
                    new PushOperation(100),
                    new PushOperation(5),
                    new PushOperation(79),
                    new EmptyOperation(),
                    new PushOperation(69),
                    new PushOperation(90),
                    new PushOperation(52),
                    new PushOperation(57),
                    new PushOperation(26),
                    new PushOperation(42),
                    new PushOperation(90),
                    new EmptyOperation(),
                    new PushOperation(28),
                    new PushOperation(32),
                    new EmptyOperation(),
                    new TopOperation(),
                    new EmptyOperation(),
                    new PushOperation(84),
                    new PushOperation(24),
                    new PushOperation(9),
                    new PushOperation(39),
                    new EmptyOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    new TopOperation.Result(32),
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    new EmptyOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new EmptyOperation(),
                    new PushOperation(35),
                    new TopOperation(),
                    new PushOperation(32),
                    new PopOperation(),
                    new PushOperation(100),
                    new EmptyOperation(),
                    new PushOperation(19),
                    new EmptyOperation(),
                    new PopOperation(),
                    new PushOperation(13),
                    new TopOperation(),
                    new TopOperation(),
                    new PushOperation(70),
                    new PushOperation(40),
                    new TopOperation(),
                    new PopOperation(),
                    new EmptyOperation(),
                    new PushOperation(50),
                    new PushOperation(28),
                    new PopOperation(),
                    new PushOperation(53),
                    new PushOperation(74),
                    new PushOperation(91),
                    new PushOperation(53),
                    new TopOperation(),
                    new PushOperation(14),
                    new TopOperation(),
                    new PushOperation(32),
                    new TopOperation()
                ],
                [
                    new EmptyOperation.Result(true),
                    VoidOperationResult.Instance,
                    new TopOperation.Result(35),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(32),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    new PopOperation.Result(19),
                    VoidOperationResult.Instance,
                    new TopOperation.Result(13),
                    new TopOperation.Result(13),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(40),
                    new PopOperation.Result(40),
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(28),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(53),
                    VoidOperationResult.Instance,
                    new TopOperation.Result(14),
                    VoidOperationResult.Instance,
                    new TopOperation.Result(32)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(55),
                    new PushOperation(7),
                    new PushOperation(6),
                    new EmptyOperation(),
                    new PushOperation(57),
                    new PopOperation(),
                    new PushOperation(64),
                    new EmptyOperation(),
                    new PushOperation(62),
                    new TopOperation(),
                    new TopOperation(),
                    new PushOperation(87),
                    new EmptyOperation(),
                    new TopOperation(),
                    new PushOperation(22),
                    new EmptyOperation(),
                    new PushOperation(46),
                    new PushOperation(73),
                    new PushOperation(42),
                    new PopOperation(),
                    new PushOperation(29),
                    new EmptyOperation(),
                    new TopOperation(),
                    new EmptyOperation(),
                    new PushOperation(94),
                    new PushOperation(97),
                    new PushOperation(95),
                    new TopOperation(),
                    new EmptyOperation(),
                    new PopOperation(),
                    new PushOperation(31),
                    new PopOperation(),
                    new TopOperation(),
                    new PushOperation(18),
                    new EmptyOperation(),
                    new PushOperation(91),
                    new EmptyOperation(),
                    new PushOperation(49),
                    new PushOperation(36),
                    new PushOperation(54)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(57),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    new TopOperation.Result(62),
                    new TopOperation.Result(62),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    new TopOperation.Result(87),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(42),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    new TopOperation.Result(29),
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(95),
                    new EmptyOperation.Result(false),
                    new PopOperation.Result(95),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(31),
                    new TopOperation.Result(97),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(1),
                    new PushOperation(2),
                    new PushOperation(3),
                    new PushOperation(4),
                    new PushOperation(5),
                    new PushOperation(6),
                    new PushOperation(7),
                    new PushOperation(8),
                    new PushOperation(9),
                    new PushOperation(10),
                    new PushOperation(11),
                    new PushOperation(12),
                    new PushOperation(13),
                    new PushOperation(14),
                    new PushOperation(15),
                    new PushOperation(16),
                    new PushOperation(17),
                    new PushOperation(18),
                    new PushOperation(19),
                    new PushOperation(20),
                    new PushOperation(21),
                    new PushOperation(22),
                    new PushOperation(23),
                    new PushOperation(24),
                    new PushOperation(25),
                    new PushOperation(26),
                    new PushOperation(27),
                    new PushOperation(28),
                    new PushOperation(29),
                    new PushOperation(30),
                    new PushOperation(31),
                    new PushOperation(32),
                    new PushOperation(33),
                    new PushOperation(34),
                    new PushOperation(35),
                    new PushOperation(36),
                    new PushOperation(37),
                    new PushOperation(38),
                    new PushOperation(39),
                    new PushOperation(40),
                    new PushOperation(41),
                    new PushOperation(42),
                    new PushOperation(43),
                    new PushOperation(44),
                    new PushOperation(45),
                    new PushOperation(46),
                    new PushOperation(47),
                    new PushOperation(48),
                    new PushOperation(49),
                    new PushOperation(50),
                    new PushOperation(51),
                    new PushOperation(52),
                    new PushOperation(53),
                    new PushOperation(54),
                    new PushOperation(55),
                    new PushOperation(56),
                    new PushOperation(57),
                    new PushOperation(58),
                    new PushOperation(59),
                    new PushOperation(60),
                    new PushOperation(61),
                    new PushOperation(62),
                    new PushOperation(63),
                    new PushOperation(64),
                    new PushOperation(65),
                    new PushOperation(66),
                    new PushOperation(67),
                    new PushOperation(68),
                    new PushOperation(69),
                    new PushOperation(70),
                    new PushOperation(71),
                    new PushOperation(72),
                    new PushOperation(73),
                    new PushOperation(74),
                    new PushOperation(75),
                    new PushOperation(76),
                    new PushOperation(77),
                    new PushOperation(78),
                    new PushOperation(79),
                    new PushOperation(80),
                    new PushOperation(81),
                    new PushOperation(82),
                    new PushOperation(83),
                    new PushOperation(84),
                    new PushOperation(85),
                    new PushOperation(86),
                    new PushOperation(87),
                    new PushOperation(88),
                    new PushOperation(89),
                    new PushOperation(90),
                    new PushOperation(91),
                    new PushOperation(92),
                    new PushOperation(93),
                    new PushOperation(94),
                    new PushOperation(95),
                    new PushOperation(96),
                    new PushOperation(97),
                    new PushOperation(98),
                    new PushOperation(99),
                    new PushOperation(100),
                    new TopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
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
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(100),
                    new PopOperation.Result(100),
                    new PopOperation.Result(99),
                    new PopOperation.Result(98),
                    new PopOperation.Result(97),
                    new PopOperation.Result(96),
                    new PopOperation.Result(95),
                    new PopOperation.Result(94),
                    new PopOperation.Result(93),
                    new PopOperation.Result(92),
                    new PopOperation.Result(91),
                    new PopOperation.Result(90),
                    new PopOperation.Result(89),
                    new PopOperation.Result(88),
                    new PopOperation.Result(87),
                    new PopOperation.Result(86),
                    new PopOperation.Result(85),
                    new PopOperation.Result(84),
                    new PopOperation.Result(83),
                    new PopOperation.Result(82),
                    new PopOperation.Result(81),
                    new PopOperation.Result(80),
                    new PopOperation.Result(79),
                    new PopOperation.Result(78),
                    new PopOperation.Result(77),
                    new PopOperation.Result(76),
                    new PopOperation.Result(75),
                    new PopOperation.Result(74),
                    new PopOperation.Result(73),
                    new PopOperation.Result(72),
                    new PopOperation.Result(71),
                    new PopOperation.Result(70),
                    new PopOperation.Result(69),
                    new PopOperation.Result(68),
                    new PopOperation.Result(67),
                    new PopOperation.Result(66),
                    new PopOperation.Result(65),
                    new PopOperation.Result(64),
                    new PopOperation.Result(63),
                    new PopOperation.Result(62),
                    new PopOperation.Result(61),
                    new PopOperation.Result(60),
                    new PopOperation.Result(59),
                    new PopOperation.Result(58),
                    new PopOperation.Result(57),
                    new PopOperation.Result(56),
                    new PopOperation.Result(55),
                    new PopOperation.Result(54),
                    new PopOperation.Result(53),
                    new PopOperation.Result(52),
                    new PopOperation.Result(51),
                    new PopOperation.Result(50),
                    new PopOperation.Result(49),
                    new PopOperation.Result(48),
                    new PopOperation.Result(47),
                    new PopOperation.Result(46),
                    new PopOperation.Result(45),
                    new PopOperation.Result(44),
                    new PopOperation.Result(43),
                    new PopOperation.Result(42),
                    new PopOperation.Result(41),
                    new PopOperation.Result(40),
                    new PopOperation.Result(39),
                    new PopOperation.Result(38),
                    new PopOperation.Result(37),
                    new PopOperation.Result(36),
                    new PopOperation.Result(35),
                    new PopOperation.Result(34),
                    new PopOperation.Result(33),
                    new PopOperation.Result(32),
                    new PopOperation.Result(31),
                    new PopOperation.Result(30),
                    new PopOperation.Result(29),
                    new PopOperation.Result(28),
                    new PopOperation.Result(27),
                    new PopOperation.Result(26),
                    new PopOperation.Result(25),
                    new PopOperation.Result(24),
                    new PopOperation.Result(23),
                    new PopOperation.Result(22),
                    new PopOperation.Result(21),
                    new PopOperation.Result(20),
                    new PopOperation.Result(19),
                    new PopOperation.Result(18),
                    new PopOperation.Result(17),
                    new PopOperation.Result(16),
                    new PopOperation.Result(15),
                    new PopOperation.Result(14),
                    new PopOperation.Result(13),
                    new PopOperation.Result(12),
                    new PopOperation.Result(11),
                    new PopOperation.Result(10),
                    new PopOperation.Result(9),
                    new PopOperation.Result(8),
                    new PopOperation.Result(7),
                    new PopOperation.Result(6),
                    new PopOperation.Result(5),
                    new PopOperation.Result(4),
                    new PopOperation.Result(3),
                    new PopOperation.Result(2),
                    new PopOperation.Result(1),
                    new EmptyOperation.Result(true)
                ])
        ];
    }

    private sealed class PushOperation : IOperation<IImplementStackUsingQueues>
    {
        private readonly int _value;

        public PushOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IImplementStackUsingQueues solution)
        {
            solution.Push(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class PopOperation : IOperation<IImplementStackUsingQueues>
    {
        public IOperationResult Execute(IImplementStackUsingQueues solution)
        {
            var result = solution.Pop();

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

    private sealed class TopOperation : IOperation<IImplementStackUsingQueues>
    {
        public IOperationResult Execute(IImplementStackUsingQueues solution)
        {
            var result = solution.Top();

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

    private sealed class EmptyOperation : IOperation<IImplementStackUsingQueues>
    {
        public IOperationResult Execute(IImplementStackUsingQueues solution)
        {
            var result = solution.Empty();

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