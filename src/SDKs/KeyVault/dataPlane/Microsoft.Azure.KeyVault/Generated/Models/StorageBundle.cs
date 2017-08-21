// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Azure;
    using KeyVault;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Storage account bundle consists of key vault storage account details
    /// plus its attributes.
    /// </summary>
    public partial class StorageBundle
    {
        /// <summary>
        /// Initializes a new instance of the StorageBundle class.
        /// </summary>
        public StorageBundle() { }

        /// <summary>
        /// Initializes a new instance of the StorageBundle class.
        /// </summary>
        /// <param name="id">The storage account id.</param>
        /// <param name="resourceId">The storage account resource id.</param>
        /// <param name="activeKeyName">The current active storage account key
        /// name.</param>
        /// <param name="autoRegenerateKey">whether keyvault should manage the
        /// storage account for the user.</param>
        /// <param name="regenerationPeriod">The key regeneration time duration
        /// specified in ISO-8601 format.</param>
        /// <param name="attributes">The storage account attributes.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs</param>
        public StorageBundle(string id = default(string), string resourceId = default(string), string activeKeyName = default(string), bool? autoRegenerateKey = default(bool?), string regenerationPeriod = default(string), StorageAccountAttributes attributes = default(StorageAccountAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Id = id;
            ResourceId = resourceId;
            ActiveKeyName = activeKeyName;
            AutoRegenerateKey = autoRegenerateKey;
            RegenerationPeriod = regenerationPeriod;
            Attributes = attributes;
            Tags = tags;
        }

        /// <summary>
        /// Gets the storage account id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }

        /// <summary>
        /// Gets the storage account resource id.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; protected set; }

        /// <summary>
        /// Gets the current active storage account key name.
        /// </summary>
        [JsonProperty(PropertyName = "activeKeyName")]
        public string ActiveKeyName { get; protected set; }

        /// <summary>
        /// Gets whether keyvault should manage the storage account for the
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "autoRegenerateKey")]
        public bool? AutoRegenerateKey { get; protected set; }

        /// <summary>
        /// Gets the key regeneration time duration specified in ISO-8601
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "regenerationPeriod")]
        public string RegenerationPeriod { get; protected set; }

        /// <summary>
        /// Gets the storage account attributes.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public StorageAccountAttributes Attributes { get; protected set; }

        /// <summary>
        /// Gets application specific metadata in the form of key-value pairs
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; protected set; }

    }
}
