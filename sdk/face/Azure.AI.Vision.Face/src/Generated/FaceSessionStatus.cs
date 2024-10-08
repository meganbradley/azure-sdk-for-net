// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Vision.Face
{
    /// <summary> The current status of the session. </summary>
    public readonly partial struct FaceSessionStatus : IEquatable<FaceSessionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FaceSessionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FaceSessionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string StartedValue = "Started";
        private const string ResultAvailableValue = "ResultAvailable";

        /// <summary> Session has not started. </summary>
        public static FaceSessionStatus NotStarted { get; } = new FaceSessionStatus(NotStartedValue);
        /// <summary> Session has started. </summary>
        public static FaceSessionStatus Started { get; } = new FaceSessionStatus(StartedValue);
        /// <summary> Session has available result. </summary>
        public static FaceSessionStatus ResultAvailable { get; } = new FaceSessionStatus(ResultAvailableValue);
        /// <summary> Determines if two <see cref="FaceSessionStatus"/> values are the same. </summary>
        public static bool operator ==(FaceSessionStatus left, FaceSessionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FaceSessionStatus"/> values are not the same. </summary>
        public static bool operator !=(FaceSessionStatus left, FaceSessionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FaceSessionStatus"/>. </summary>
        public static implicit operator FaceSessionStatus(string value) => new FaceSessionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FaceSessionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FaceSessionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
