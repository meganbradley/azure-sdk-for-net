// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The load distribution policy for this rule. </summary>
    public readonly partial struct LoadDistribution : IEquatable<LoadDistribution>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LoadDistribution"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LoadDistribution(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string SourceIPValue = "SourceIP";
        private const string SourceIPProtocolValue = "SourceIPProtocol";

        /// <summary> Default. </summary>
        public static LoadDistribution Default { get; } = new LoadDistribution(DefaultValue);
        /// <summary> SourceIP. </summary>
        public static LoadDistribution SourceIP { get; } = new LoadDistribution(SourceIPValue);
        /// <summary> SourceIPProtocol. </summary>
        public static LoadDistribution SourceIPProtocol { get; } = new LoadDistribution(SourceIPProtocolValue);
        /// <summary> Determines if two <see cref="LoadDistribution"/> values are the same. </summary>
        public static bool operator ==(LoadDistribution left, LoadDistribution right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LoadDistribution"/> values are not the same. </summary>
        public static bool operator !=(LoadDistribution left, LoadDistribution right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LoadDistribution"/>. </summary>
        public static implicit operator LoadDistribution(string value) => new LoadDistribution(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LoadDistribution other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LoadDistribution other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
