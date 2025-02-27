// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Provisioning state of the Media Services account. </summary>
    public readonly partial struct MediaProvisioningState : IEquatable<MediaProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FailedValue = "Failed";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";

        /// <summary> Provisioning state failed. </summary>
        public static MediaProvisioningState Failed { get; } = new MediaProvisioningState(FailedValue);
        /// <summary> Provisioning state in progress. </summary>
        public static MediaProvisioningState InProgress { get; } = new MediaProvisioningState(InProgressValue);
        /// <summary> Provisioning state succeeded. </summary>
        public static MediaProvisioningState Succeeded { get; } = new MediaProvisioningState(SucceededValue);
        /// <summary> Determines if two <see cref="MediaProvisioningState"/> values are the same. </summary>
        public static bool operator ==(MediaProvisioningState left, MediaProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(MediaProvisioningState left, MediaProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaProvisioningState"/>. </summary>
        public static implicit operator MediaProvisioningState(string value) => new MediaProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
