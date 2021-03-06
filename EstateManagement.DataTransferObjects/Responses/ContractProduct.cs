﻿namespace EstateManagement.DataTransferObjects.Responses
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ContractProduct
    {
        /// <summary>
        /// Gets or sets the display text.
        /// </summary>
        /// <value>
        /// The display text.
        /// </value>
        [JsonProperty("display_text")]
        public String DisplayText { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        [JsonProperty("product_id")]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the transaction fees.
        /// </summary>
        /// <value>
        /// The transaction fees.
        /// </value>
        [JsonProperty("transaction_fees")]
        public List<ContractProductTransactionFee> TransactionFees { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty("value")]
        public Decimal? Value { get; set; }
    }
}