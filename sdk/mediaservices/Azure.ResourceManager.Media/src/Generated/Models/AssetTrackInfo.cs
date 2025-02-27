// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base type for concrete track types. A derived type must be used to represent the Track.
    /// Please note <see cref="AssetTrackInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AudioTrack"/>, <see cref="TextTrack"/> and <see cref="VideoTrack"/>.
    /// </summary>
    public abstract partial class AssetTrackInfo
    {
        /// <summary> Initializes a new instance of AssetTrackInfo. </summary>
        protected AssetTrackInfo()
        {
        }

        /// <summary> Initializes a new instance of AssetTrackInfo. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal AssetTrackInfo(string odataType)
        {
            OdataType = odataType;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}
