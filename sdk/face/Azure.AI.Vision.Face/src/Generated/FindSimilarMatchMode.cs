// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Vision.Face
{
    /// <summary> Similar face searching mode. </summary>
    public readonly partial struct FindSimilarMatchMode : IEquatable<FindSimilarMatchMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FindSimilarMatchMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FindSimilarMatchMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MatchPersonValue = "matchPerson";
        private const string MatchFaceValue = "matchFace";

        /// <summary> Match person. </summary>
        public static FindSimilarMatchMode MatchPerson { get; } = new FindSimilarMatchMode(MatchPersonValue);
        /// <summary> Match face. </summary>
        public static FindSimilarMatchMode MatchFace { get; } = new FindSimilarMatchMode(MatchFaceValue);
        /// <summary> Determines if two <see cref="FindSimilarMatchMode"/> values are the same. </summary>
        public static bool operator ==(FindSimilarMatchMode left, FindSimilarMatchMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FindSimilarMatchMode"/> values are not the same. </summary>
        public static bool operator !=(FindSimilarMatchMode left, FindSimilarMatchMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FindSimilarMatchMode"/>. </summary>
        public static implicit operator FindSimilarMatchMode(string value) => new FindSimilarMatchMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FindSimilarMatchMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FindSimilarMatchMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
