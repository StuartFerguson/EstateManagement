﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EstateManagement.ContractAggregate.Tests
{
    using Contract.DomainEvents;
    using Models.Contract;
    using Shouldly;
    using Testing;
    using Xunit;

    public class DomainEventTests
    {
        [Fact]
        public void ContractCreatedEvent_CanBeCreated_IsCreated()
        {
            ContractCreatedEvent contractCreatedEvent = ContractCreatedEvent.Create(TestData.ContractId, TestData.EstateId,
                                                                                    TestData.OperatorId, TestData.ContractDescription);

            contractCreatedEvent.ShouldNotBeNull();
            contractCreatedEvent.AggregateId.ShouldBe(TestData.ContractId);
            contractCreatedEvent.EventCreatedDateTime.ShouldNotBe(DateTime.MinValue);
            contractCreatedEvent.EventId.ShouldNotBe(Guid.Empty);
            contractCreatedEvent.ContractId.ShouldBe(TestData.ContractId);
            contractCreatedEvent.Description.ShouldBe(TestData.ContractDescription);
            contractCreatedEvent.OperatorId.ShouldBe(TestData.OperatorId);
            contractCreatedEvent.EstateId.ShouldBe(TestData.EstateId);
        }

        [Fact]
        public void ProductAddedToContractEvent_CanBeCreated_IsCreated()
        {
            FixedValueProductAddedToContractEvent fixedValueProductAddedToContractEvent = FixedValueProductAddedToContractEvent.Create(TestData.ContractId, TestData.EstateId,
                                                                                                                             TestData.ProductId, TestData.ProductName,
                                                                                                                             TestData.ProductDisplayText,
                                                                                                                             TestData.ProductFixedValue);

            fixedValueProductAddedToContractEvent.ShouldNotBeNull();
            fixedValueProductAddedToContractEvent.AggregateId.ShouldBe(TestData.ContractId);
            fixedValueProductAddedToContractEvent.EventCreatedDateTime.ShouldNotBe(DateTime.MinValue);
            fixedValueProductAddedToContractEvent.EventId.ShouldNotBe(Guid.Empty);
            fixedValueProductAddedToContractEvent.ContractId.ShouldBe(TestData.ContractId);
            fixedValueProductAddedToContractEvent.EstateId.ShouldBe(TestData.EstateId);
            fixedValueProductAddedToContractEvent.ProductId.ShouldBe(TestData.ProductId);
            fixedValueProductAddedToContractEvent.ProductName.ShouldBe(TestData.ProductName);
            fixedValueProductAddedToContractEvent.DisplayText.ShouldBe(TestData.ProductDisplayText);
            fixedValueProductAddedToContractEvent.Value.ShouldBe(TestData.ProductFixedValue);
        }

        [Fact]
        public void VariableValueProductAddedToContractEvent_CanBeCreated_IsCreated()
        {
            VariableValueProductAddedToContractEvent variableValueProductAddedToContractEvent = VariableValueProductAddedToContractEvent.Create(TestData.ContractId, TestData.EstateId,
                                                                                                                                             TestData.ProductId, TestData.ProductName,
                                                                                                                                             TestData.ProductDisplayText);

            variableValueProductAddedToContractEvent.ShouldNotBeNull();
            variableValueProductAddedToContractEvent.AggregateId.ShouldBe(TestData.ContractId);
            variableValueProductAddedToContractEvent.EventCreatedDateTime.ShouldNotBe(DateTime.MinValue);
            variableValueProductAddedToContractEvent.EventId.ShouldNotBe(Guid.Empty);
            variableValueProductAddedToContractEvent.ContractId.ShouldBe(TestData.ContractId);
            variableValueProductAddedToContractEvent.EstateId.ShouldBe(TestData.EstateId);
            variableValueProductAddedToContractEvent.ProductId.ShouldBe(TestData.ProductId);
            variableValueProductAddedToContractEvent.ProductName.ShouldBe(TestData.ProductName);
            variableValueProductAddedToContractEvent.DisplayText.ShouldBe(TestData.ProductDisplayText);
        }

        [Theory]
        [InlineData(CalculationType.Fixed)]
        [InlineData(CalculationType.Percentage)]
        public void TransactionFeeForProductAddedToContractEvent_CanBeCreated_IsCreated(CalculationType calculationType)
        {
            TransactionFeeForProductAddedToContractEvent transactionFeeForProductAddedToContractEvent = TransactionFeeForProductAddedToContractEvent.Create(TestData.ContractId,
                                                                                                                                                            TestData.EstateId,
                                                                                                                                                            TestData.ProductId,
                                                                                                                                                            TestData.TransactionFeeId,
                                                                                                                                                            TestData.TransactionFeeDescription,
                                                                                                                                                            (Int32)calculationType,
                                                                                                                                                            TestData.TransactionFeeValue);

            transactionFeeForProductAddedToContractEvent.ShouldNotBeNull();
            transactionFeeForProductAddedToContractEvent.AggregateId.ShouldBe(TestData.ContractId);
            transactionFeeForProductAddedToContractEvent.EventCreatedDateTime.ShouldNotBe(DateTime.MinValue);
            transactionFeeForProductAddedToContractEvent.EventId.ShouldNotBe(Guid.Empty);
            transactionFeeForProductAddedToContractEvent.ContractId.ShouldBe(TestData.ContractId);
            transactionFeeForProductAddedToContractEvent.EstateId.ShouldBe(TestData.EstateId);
            transactionFeeForProductAddedToContractEvent.ProductId.ShouldBe(TestData.ProductId);
            transactionFeeForProductAddedToContractEvent.TransactionFeeId.ShouldBe(TestData.TransactionFeeId);
            transactionFeeForProductAddedToContractEvent.Description.ShouldBe(TestData.TransactionFeeDescription);
            transactionFeeForProductAddedToContractEvent.CalculationType.ShouldBe((Int32)calculationType);
            transactionFeeForProductAddedToContractEvent.Value.ShouldBe(TestData.TransactionFeeValue);
        }
    }
}
