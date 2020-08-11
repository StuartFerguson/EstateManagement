using System;
using Xunit;

namespace EstateManagement.ContractAggregate.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Models.Contract;
    using Shouldly;
    using Testing;

    public class ContractAggregateTests
    {
        [Fact]
        public void ContractAggregate_CanBeCreated_IsCreated()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);

            aggregate.AggregateId.ShouldBe(TestData.ContractId);
        }

        [Fact]
        public void ContractAggregate_Create_IsCreated()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            aggregate.AggregateId.ShouldBe(TestData.ContractId);
            aggregate.EstateId.ShouldBe(TestData.EstateId);
            aggregate.OperatorId.ShouldBe(TestData.OperatorId);
            aggregate.Description.ShouldBe(TestData.ContractDescription);
            aggregate.IsCreated.ShouldBeTrue();
        }

        [Fact]
        public void ContractAggregate_Create_InvalidEstateId_ErrorThrown()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);

            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.Create(Guid.Empty, TestData.OperatorId, TestData.ContractDescription);
                                                });
        }

        [Fact]
        public void ContractAggregate_Create_InvalidOperatorId_ErrorThrown()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);

            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.Create(TestData.EstateId, Guid.Empty, TestData.ContractDescription);
                                                });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ContractAggregate_Create_InvalidDescription_ErrorThrown(String description)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);

            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.Create(TestData.EstateId, TestData.OperatorId, description);
                                                });
        }

        [Fact]
        public void ContractAggregate_AddFixedValueProduct_ProductAdded()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            aggregate.AddFixedValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText, TestData.ProductFixedValue);

            List<Product> products = aggregate.GetProducts();
            products.Count.ShouldBe(1);
            products.First().ProductId.ShouldNotBe(Guid.Empty);
            products.First().Name.ShouldBe(TestData.ProductName);
            products.First().DisplayText.ShouldBe(TestData.ProductDisplayText);
            products.First().Value.ShouldBe(TestData.ProductFixedValue);

        }

        [Fact]
        public void ContractAggregate_AddFixedValueProduct_DuplicateProduct_ErrorThrown()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            aggregate.AddFixedValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText, TestData.ProductFixedValue);

            Should.Throw<InvalidOperationException>(() =>
                                                {
                                                    aggregate.AddFixedValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText, TestData.ProductFixedValue);
                                                });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ContractAggregate_AddFixedValueProduct_InvalidProductName_ErrorThrown(String productName)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            
            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.AddFixedValueProduct(TestData.ProductId, productName, TestData.ProductDisplayText, TestData.ProductFixedValue);
                                                });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ContractAggregate_AddFixedValueProduct_InvalidProductDisplayText_ErrorThrown(String displayText)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.AddFixedValueProduct(TestData.ProductId, TestData.ProductName, displayText, TestData.ProductFixedValue);
                                                });
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ContractAggregate_AddFixedValueProduct_InvalidProductValue_ErrorThrown(Decimal value)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            Should.Throw<ArgumentOutOfRangeException>(() =>
                                                {
                                                    aggregate.AddFixedValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText, value);
                                                });
        }

        [Fact]
        public void ContractAggregate_AddVariableValueProduct_ProductAdded()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            products.Count.ShouldBe(1);
            products.First().ProductId.ShouldNotBe(Guid.Empty);
            products.First().Name.ShouldBe(TestData.ProductName);
            products.First().DisplayText.ShouldBe(TestData.ProductDisplayText);
            products.First().Value.ShouldBeNull();

        }

        [Fact]
        public void ContractAggregate_AddVariableValueProduct_DuplicateProduct_ErrorThrown()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            Should.Throw<InvalidOperationException>(() =>
            {
                aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ContractAggregate_AddVariableValueProduct_InvalidProductName_ErrorThrown(String productName)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            Should.Throw<ArgumentNullException>(() =>
            {
                aggregate.AddVariableValueProduct(TestData.ProductId, productName, TestData.ProductDisplayText);
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ContractAggregate_AddVariableValueProduct_InvalidProductDisplayText_ErrorThrown(String displayText)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            Should.Throw<ArgumentNullException>(() =>
            {
                aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, displayText);
            });
        }

        [Fact]
        public void ContractAggregate_GetContract_ContractReturned()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            Contract contract = aggregate.GetContract();

            contract.EstateId.ShouldBe(TestData.EstateId);
            contract.ContractId.ShouldBe(TestData.ContractId);
            contract.Description.ShouldBe(TestData.ContractDescription);
            contract.IsCreated.ShouldBeTrue();
            contract.OperatorId.ShouldBe(TestData.OperatorId);
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider)]
        public void ContractAggregate_AddTransactionFee_FixedValueProduct_TransactionFeeAdded(CalculationType calculationType, FeeType feeType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddFixedValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText, TestData.ProductFixedValue);
            
            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            aggregate.AddTransactionFee(product, TestData.TransactionFeeId, TestData.TransactionFeeDescription, calculationType, feeType, TestData.TransactionFeeValue);

            List<Product> productsAfterFeeAdded = aggregate.GetProducts();
            Product productWithFees = productsAfterFeeAdded.Single();

            productWithFees.TransactionFees.ShouldHaveSingleItem();
            TransactionFee fee = productWithFees.TransactionFees.Single();
            fee.Description.ShouldBe(TestData.TransactionFeeDescription);
            fee.TransactionFeeId.ShouldBe(TestData.TransactionFeeId);
            fee.CalculationType.ShouldBe(calculationType);
            fee.FeeType.ShouldBe(feeType);
            fee.Value.ShouldBe(TestData.TransactionFeeValue);
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider)]
        public void ContractAggregate_AddTransactionFee_FixedValueProduct_InvalidFeeId_ErrorThrown(CalculationType calculationType, FeeType feeType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddFixedValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText, TestData.ProductFixedValue);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.AddTransactionFee(product, Guid.Empty, TestData.TransactionFeeDescription, calculationType, feeType, TestData.TransactionFeeValue);
                                                });
        }

        [Theory]
        [InlineData(CalculationType.Fixed,FeeType.Merchant, null)]
        [InlineData(CalculationType.Fixed, FeeType.Merchant, "")]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider, null)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider, "")]
        [InlineData(CalculationType.Percentage, FeeType.Merchant, null)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant, "")]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider, null)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider, "")]
        public void ContractAggregate_AddTransactionFee_FixedValueProduct_InvalidFeeDescription_ErrorThrown(CalculationType calculationType, FeeType feeType, String feeDescription)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddFixedValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText, TestData.ProductFixedValue);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.AddTransactionFee(product, TestData.TransactionFeeId, feeDescription, calculationType, feeType, TestData.TransactionFeeValue);
                                                });
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider)]
        public void ContractAggregate_AddTransactionFee_VariableValueProduct_TransactionFeeAdded(CalculationType calculationType, FeeType feeType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            aggregate.AddTransactionFee(product, TestData.TransactionFeeId, TestData.TransactionFeeDescription, calculationType, feeType, TestData.TransactionFeeValue);

            List<Product> productsAfterFeeAdded = aggregate.GetProducts();
            Product productWithFees = productsAfterFeeAdded.Single();

            productWithFees.TransactionFees.ShouldHaveSingleItem();
            TransactionFee fee = productWithFees.TransactionFees.Single();
            fee.Description.ShouldBe(TestData.TransactionFeeDescription);
            fee.TransactionFeeId.ShouldBe(TestData.TransactionFeeId);
            fee.CalculationType.ShouldBe(calculationType);
            fee.FeeType.ShouldBe(feeType);
            fee.Value.ShouldBe(TestData.TransactionFeeValue);
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider)]
        public void ContractAggregate_AddTransactionFee_VariableValueProduct_InvalidFeeId_ErrorThrown(CalculationType calculationType, FeeType feeType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.AddTransactionFee(product, Guid.Empty, TestData.TransactionFeeDescription, calculationType, feeType, TestData.TransactionFeeValue);
                                                });
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant, null)]
        [InlineData(CalculationType.Fixed, FeeType.Merchant, "")]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider, null)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider, "")]
        [InlineData(CalculationType.Percentage, FeeType.Merchant, null)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant, "")]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider, null)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider, "")]
        public void ContractAggregate_AddTransactionFee_VariableValueProduct_InvalidFeeDescription_ErrorThrown(CalculationType calculationType, FeeType feeType, String feeDescription)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.AddTransactionFee(product, TestData.TransactionFeeId, feeDescription, calculationType, feeType, TestData.TransactionFeeValue);
                                                });
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider)]
        public void ContractAggregate_AddTransactionFee_NullProduct_ErrorThrown(CalculationType calculationType, FeeType feeType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            Should.Throw<ArgumentNullException>(() =>
                                                {
                                                    aggregate.AddTransactionFee(null, TestData.TransactionFeeId, TestData.TransactionFeeDescription, calculationType, feeType, TestData.TransactionFeeValue);
                                                });
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider)]
        public void ContractAggregate_AddTransactionFee_ProductNotFound_ErrorThrown(CalculationType calculationType, FeeType feeType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddFixedValueProduct(TestData.ProductId,TestData.ProductName, TestData.ProductDisplayText, TestData.ProductFixedValue);

            Should.Throw<InvalidOperationException>(() =>
                                                {
                                                    aggregate.AddTransactionFee(new Product(), TestData.TransactionFeeId, TestData.TransactionFeeDescription, calculationType, feeType,TestData.TransactionFeeValue);
                                                });
        }

        [Theory]
        [InlineData(FeeType.Merchant)]
        [InlineData(FeeType.ServiceProvider)]
        public void ContractAggregate_AddTransactionFee_FixedValueProduct_InvalidCalculationType_ErrorThrown(FeeType feeType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentOutOfRangeException>(() =>
                                                      {
                                                          aggregate.AddTransactionFee(product, TestData.TransactionFeeId, TestData.TransactionFeeDescription, (CalculationType)99, feeType, TestData.TransactionFeeValue);
                                                      });
        }

        [Theory]
        [InlineData(CalculationType.Percentage)]
        [InlineData(CalculationType.Fixed)]
        public void ContractAggregate_AddTransactionFee_FixedValueProduct_InvalidFeeType_ErrorThrown(CalculationType calculationType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentOutOfRangeException>(() =>
                                                      {
                                                          aggregate.AddTransactionFee(product, TestData.TransactionFeeId, TestData.TransactionFeeDescription, calculationType, (FeeType)99, TestData.TransactionFeeValue);
                                                      });
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant,0)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant, 0)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider, 0)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider, 0)]
        [InlineData(CalculationType.Fixed, FeeType.Merchant, -1)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant, -1)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider, -1)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider, -1)]
        public void ContractAggregate_AddTransactionFee_VariableValueProduct_InvalidFeeValue_ErrorThrown(CalculationType calculationType, FeeType feeType, Decimal feeValue)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentOutOfRangeException>(() =>
                                                      {
                                                          aggregate.AddTransactionFee(product, TestData.TransactionFeeId, TestData.TransactionFeeDescription, calculationType, feeType, feeValue);
                                                      });
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant, 0)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant, 0)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider, 0)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider, 0)]
        [InlineData(CalculationType.Fixed, FeeType.Merchant, -1)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant, -1)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider, -1)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider, -1)]
        public void ContractAggregate_AddTransactionFee_FixedValueProduct_InvalidFeeValue_ErrorThrown(CalculationType calculationType, FeeType feeType, Decimal feeValue)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentOutOfRangeException>(() =>
                                                      {
                                                          aggregate.AddTransactionFee(product, TestData.TransactionFeeId, TestData.TransactionFeeDescription, calculationType,feeType, feeValue);
                                                      });
        }

        [Theory]
        [InlineData(FeeType.Merchant)]
        [InlineData(FeeType.ServiceProvider)]
        public void ContractAggregate_AddTransactionFee_VariableValueProduct_InvalidCalculationType_ErrorThrown(FeeType feeType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentOutOfRangeException>(() =>
                                                      {
                                                          aggregate.AddTransactionFee(product, TestData.TransactionFeeId, TestData.TransactionFeeDescription, (CalculationType)99, feeType, TestData.TransactionFeeValue);
                                                      });
        }

        [Theory]
        [InlineData(CalculationType.Percentage)]
        [InlineData(CalculationType.Fixed)]
        public void ContractAggregate_AddTransactionFee_VariableValueProduct_InvalidFeeType_ErrorThrown(CalculationType calculationType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            Should.Throw<ArgumentOutOfRangeException>(() =>
                                                      {
                                                          aggregate.AddTransactionFee(product, TestData.TransactionFeeId, TestData.TransactionFeeDescription, calculationType,(FeeType)99, TestData.TransactionFeeValue);
                                                      });
        }

        [Theory]
        [InlineData(CalculationType.Fixed, FeeType.Merchant)]
        [InlineData(CalculationType.Percentage, FeeType.Merchant)]
        [InlineData(CalculationType.Fixed, FeeType.ServiceProvider)]
        [InlineData(CalculationType.Percentage, FeeType.ServiceProvider)]
        public void ContractAggregate_DisableTransactionFee_TransactionFeeIsDisabled(CalculationType calculationType, FeeType feeType)
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);

            List<Product> products = aggregate.GetProducts();
            Product product = products.Single();

            aggregate.AddTransactionFee(product, TestData.TransactionFeeId, TestData.TransactionFeeDescription, calculationType, feeType, TestData.TransactionFeeValue);

            List<Product> productsAfterFeeAdded = aggregate.GetProducts();
            Product productWithFees = productsAfterFeeAdded.Single();
            productWithFees.TransactionFees.ShouldHaveSingleItem();
            TransactionFee fee = productWithFees.TransactionFees.Single();
            fee.IsEnabled.ShouldBeTrue();

            aggregate.DisableTransactionFee(TestData.ProductId, TestData.TransactionFeeId);

            productsAfterFeeAdded = aggregate.GetProducts();
            productWithFees = productsAfterFeeAdded.Single();
            productWithFees.TransactionFees.ShouldHaveSingleItem();
            fee = productWithFees.TransactionFees.Single();
            fee.IsEnabled.ShouldBeFalse();
        }

        [Fact]
        public void ContractAggregate_DisableTransactionFee_ProductNotFound_ErrorThrown()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);

            Should.Throw<InvalidOperationException>(() =>
                                                    {
                                                        aggregate.DisableTransactionFee(TestData.ProductId, TestData.TransactionFeeId);
                                                    });
        }

        [Fact]
        public void ContractAggregate_DisableTransactionFee_TransactionFeeNotFound_ErrorThrown()
        {
            ContractAggregate aggregate = ContractAggregate.Create(TestData.ContractId);
            aggregate.Create(TestData.EstateId, TestData.OperatorId, TestData.ContractDescription);
            aggregate.AddVariableValueProduct(TestData.ProductId, TestData.ProductName, TestData.ProductDisplayText);
            
            Should.Throw<InvalidOperationException>(() =>
                                                    {
                                                        aggregate.DisableTransactionFee(TestData.ProductId, TestData.TransactionFeeId);
                                                    });
        }
    }
}
