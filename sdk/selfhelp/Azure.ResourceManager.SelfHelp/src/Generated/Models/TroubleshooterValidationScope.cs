// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Validation scope. </summary>
    public readonly partial struct TroubleshooterValidationScope : IEquatable<TroubleshooterValidationScope>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TroubleshooterValidationScope"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TroubleshooterValidationScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string UrlFormatValue = "URLFormat";
        private const string GuidFormatValue = "GuidFormat";
        private const string IPAddressFormatValue = "IpAddressFormat";
        private const string NumberOnlyFormatValue = "NumberOnlyFormat";

        /// <summary> None. </summary>
        public static TroubleshooterValidationScope None { get; } = new TroubleshooterValidationScope(NoneValue);
        /// <summary> URLFormat. </summary>
        public static TroubleshooterValidationScope UrlFormat { get; } = new TroubleshooterValidationScope(UrlFormatValue);
        /// <summary> GuidFormat. </summary>
        public static TroubleshooterValidationScope GuidFormat { get; } = new TroubleshooterValidationScope(GuidFormatValue);
        /// <summary> IpAddressFormat. </summary>
        public static TroubleshooterValidationScope IPAddressFormat { get; } = new TroubleshooterValidationScope(IPAddressFormatValue);
        /// <summary> NumberOnlyFormat. </summary>
        public static TroubleshooterValidationScope NumberOnlyFormat { get; } = new TroubleshooterValidationScope(NumberOnlyFormatValue);
        /// <summary> Determines if two <see cref="TroubleshooterValidationScope"/> values are the same. </summary>
        public static bool operator ==(TroubleshooterValidationScope left, TroubleshooterValidationScope right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TroubleshooterValidationScope"/> values are not the same. </summary>
        public static bool operator !=(TroubleshooterValidationScope left, TroubleshooterValidationScope right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TroubleshooterValidationScope"/>. </summary>
        public static implicit operator TroubleshooterValidationScope(string value) => new TroubleshooterValidationScope(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TroubleshooterValidationScope other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TroubleshooterValidationScope other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
