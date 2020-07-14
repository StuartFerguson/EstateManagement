﻿namespace EstateManagement.DataTransferObjects.Requests
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public class AddProductToContractRequest
    {
        #region Properties

        /// <summary>
        /// Gets or sets the display text.
        /// </summary>
        /// <value>
        /// The display text.
        /// </value>
        [JsonProperty("display_text")]
        public String DisplayText { get; set; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        [JsonProperty("product_name")]
        public String ProductName { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty("value")]
        public Decimal? Value { get; set; }

        #endregion
    }
}