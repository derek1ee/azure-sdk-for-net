// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    public partial class AliasType
    {
        /// <summary>
        /// Initializes a new instance of the AliasType class.
        /// </summary>
        public AliasType() { }

        /// <summary>
        /// Initializes a new instance of the AliasType class.
        /// </summary>
        /// <param name="name">The alias name.</param>
        /// <param name="paths">The paths for an alias.</param>
        public AliasType(string name = default(string), System.Collections.Generic.IList<AliasPathType> paths = default(System.Collections.Generic.IList<AliasPathType>))
        {
            Name = name;
            Paths = paths;
        }

        /// <summary>
        /// Gets or sets the alias name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the paths for an alias.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "paths")]
        public System.Collections.Generic.IList<AliasPathType> Paths { get; set; }

    }
}