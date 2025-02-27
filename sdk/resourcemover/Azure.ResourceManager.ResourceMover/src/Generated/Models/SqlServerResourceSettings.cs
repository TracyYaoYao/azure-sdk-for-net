// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the SQL Server resource settings. </summary>
    public partial class SqlServerResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of SqlServerResourceSettings. </summary>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        public SqlServerResourceSettings(string targetResourceName) : base(targetResourceName)
        {
            if (targetResourceName == null)
            {
                throw new ArgumentNullException(nameof(targetResourceName));
            }

            ResourceType = "Microsoft.Sql/servers";
        }

        /// <summary> Initializes a new instance of SqlServerResourceSettings. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        internal SqlServerResourceSettings(string resourceType, string targetResourceName) : base(resourceType, targetResourceName)
        {
            ResourceType = resourceType ?? "Microsoft.Sql/servers";
        }
    }
}
