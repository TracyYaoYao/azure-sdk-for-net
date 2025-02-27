// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Symmetric key for authentication. </summary>
    internal partial class SymmetricKey
    {
        /// <summary> Initializes a new instance of SymmetricKey. </summary>
        public SymmetricKey()
        {
        }

        /// <summary> Initializes a new instance of SymmetricKey. </summary>
        /// <param name="connectionString"> Connection string based on the symmetric key. </param>
        internal SymmetricKey(AsymmetricEncryptedSecret connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary> Connection string based on the symmetric key. </summary>
        public AsymmetricEncryptedSecret ConnectionString { get; set; }
    }
}
