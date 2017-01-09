// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Represents the response to a List Azure SQL database replication link
    /// request.
    /// </summary>
    public partial class ReplicationLinkListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the ReplicationLinkListResultInner
        /// class.
        /// </summary>
        public ReplicationLinkListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the ReplicationLinkListResultInner
        /// class.
        /// </summary>
        /// <param name="value">The list of Azure SQL database replication
        /// links housed in the database.</param>
        public ReplicationLinkListResultInner(System.Collections.Generic.IList<ReplicationLinkInner> value = default(System.Collections.Generic.IList<ReplicationLinkInner>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the list of Azure SQL database replication links
        /// housed in the database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<ReplicationLinkInner> Value { get; set; }

    }
}