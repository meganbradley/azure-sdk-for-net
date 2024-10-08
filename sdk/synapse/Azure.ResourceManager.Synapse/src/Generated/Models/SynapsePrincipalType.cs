// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Principal type. </summary>
    public readonly partial struct SynapsePrincipalType : IEquatable<SynapsePrincipalType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapsePrincipalType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapsePrincipalType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AppValue = "App";
        private const string GroupValue = "Group";
        private const string UserValue = "User";

        /// <summary> App. </summary>
        public static SynapsePrincipalType App { get; } = new SynapsePrincipalType(AppValue);
        /// <summary> Group. </summary>
        public static SynapsePrincipalType Group { get; } = new SynapsePrincipalType(GroupValue);
        /// <summary> User. </summary>
        public static SynapsePrincipalType User { get; } = new SynapsePrincipalType(UserValue);
        /// <summary> Determines if two <see cref="SynapsePrincipalType"/> values are the same. </summary>
        public static bool operator ==(SynapsePrincipalType left, SynapsePrincipalType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapsePrincipalType"/> values are not the same. </summary>
        public static bool operator !=(SynapsePrincipalType left, SynapsePrincipalType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SynapsePrincipalType"/>. </summary>
        public static implicit operator SynapsePrincipalType(string value) => new SynapsePrincipalType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapsePrincipalType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapsePrincipalType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
