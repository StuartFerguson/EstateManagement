﻿namespace EstateManagement.Models.Estate
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public class Operator
    {
        #region Properties

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public String Name { get; set; }

        /// <summary>
        /// Gets the operator identifier.
        /// </summary>
        /// <value>
        /// The operator identifier.
        /// </value>
        public Guid OperatorId { get; set; }

        /// <summary>
        /// Gets a value indicating whether [require custom merchant number].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [require custom merchant number]; otherwise, <c>false</c>.
        /// </value>
        public Boolean RequireCustomMerchantNumber { get; set; }

        /// <summary>
        /// Gets a value indicating whether [require customterminal number].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [require customterminal number]; otherwise, <c>false</c>.
        /// </value>
        public Boolean RequireCustomTerminalNumber { get; set; }

        #endregion
    }
}