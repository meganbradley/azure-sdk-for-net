// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Verbosity level. </summary>
    public readonly partial struct VerbosityLevel : IEquatable<VerbosityLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VerbosityLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VerbosityLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NormalValue = "Normal";
        private const string MinimumValue = "Minimum";
        private const string FullValue = "Full";

        /// <summary> Normal. </summary>
        public static VerbosityLevel Normal { get; } = new VerbosityLevel(NormalValue);
        /// <summary> Minimum. </summary>
        public static VerbosityLevel Minimum { get; } = new VerbosityLevel(MinimumValue);
        /// <summary> Full. </summary>
        public static VerbosityLevel Full { get; } = new VerbosityLevel(FullValue);
        /// <summary> Determines if two <see cref="VerbosityLevel"/> values are the same. </summary>
        public static bool operator ==(VerbosityLevel left, VerbosityLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VerbosityLevel"/> values are not the same. </summary>
        public static bool operator !=(VerbosityLevel left, VerbosityLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VerbosityLevel"/>. </summary>
        public static implicit operator VerbosityLevel(string value) => new VerbosityLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VerbosityLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VerbosityLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
