// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Resource Connectivity Status Type identifier. </summary>
    public readonly partial struct ConnectivityStatusType : IEquatable<ConnectivityStatusType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectivityStatusType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectivityStatusType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitializingValue = "initializing";
        private const string SuccessValue = "success";
        private const string FailureValue = "failure";

        /// <summary> initializing. </summary>
        public static ConnectivityStatusType Initializing { get; } = new ConnectivityStatusType(InitializingValue);
        /// <summary> success. </summary>
        public static ConnectivityStatusType Success { get; } = new ConnectivityStatusType(SuccessValue);
        /// <summary> failure. </summary>
        public static ConnectivityStatusType Failure { get; } = new ConnectivityStatusType(FailureValue);
        /// <summary> Determines if two <see cref="ConnectivityStatusType"/> values are the same. </summary>
        public static bool operator ==(ConnectivityStatusType left, ConnectivityStatusType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectivityStatusType"/> values are not the same. </summary>
        public static bool operator !=(ConnectivityStatusType left, ConnectivityStatusType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectivityStatusType"/>. </summary>
        public static implicit operator ConnectivityStatusType(string value) => new ConnectivityStatusType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectivityStatusType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectivityStatusType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
